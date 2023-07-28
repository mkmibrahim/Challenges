using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Diagnostics;
using KOG.RTDB.SimpleServer;
using System.Threading;
using System;
using KOG.FrameWork.Toolslib.Core;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;
using Serilog;
using KestrelHelpers;
using KOG.ToolsLib.SharedCode;
using System.Security.Permissions;
using System.ServiceProcess;
using System.ServiceModel.Channels;

namespace NetCoreRtdbClient
{


    public class RtdbClient : IRtdbClientConfig, ISubscribeDataNotify
    {
        private class Pair<FT, ST>
        {
            public FT First { get; set; }
            public ST Second { get; set; }
        }

        private class RangeDictionary : ConcurrentDictionary<int, Pair<int, int>>
        {
            public void Add(int subscription, int minId, int maxId)
            {
                base.Add(subscription, new Pair<int, int> { First = minId, Second = maxId });
            }
        }

        private class TagIdDictionary : ConcurrentDictionary<int, string>
        {
            public void RemoveIds(int min, int max)
            {
                ExtraLockedAction((d) =>
                {
                    for (var i = min; i <= max; i++)
                        d.Remove(i);
                });
            }

            public bool AssignStrings(SimpleTaData[] vals)
            {
                var ret = true;
                ExtraLockedAction((d) =>
                {
                    foreach (var val in vals)
                        if (d.TryGetValue(val.m_ID, out var tag))
                            val.m_strProp = tag;
                        else
                            ret = false;
                });
                return ret;
            }
        }


        private class TagsByGuid
        {
            private readonly KogSortedSet2<Tag, Guid> _tagsByGuid = new KogSortedSet2<Tag, Guid>((g) => new Tag { UniqueId = g });
            public string NameFromGuid(Guid g)
            {
                var ret = _tagsByGuid.Find(g);
                if (ret == null)
                    return "Unknown binding";
                return ret.Name;
            }
            public string NameFromBinding(BindingDef def)
            {
                var ret = _tagsByGuid.Find(def.Binding);
                if (ret == null)
                    throw new Exception($"A tag with guid {def.Binding} does not exist in SynEnergy");
                if (def.Prop != TagProperty.None)
                    return ret.Name + "." + def.Prop.ToString();
                return ret.Name + ".Value";
            }
            public void Clear()
            {
                _tagsByGuid.Clear();
            }
            public void Add(Tag t)
            {
                _tagsByGuid.Add(t);
            }

            public Tag Find(Guid guid)
            {
                return _tagsByGuid.Find(guid);
            }
        }

        private class TagsByName : KogSortedSet2<Tag, string>
        {
            public TagsByName():base((n) => new Tag { Name = n })
            { }
            public bool Exists(string name)
            {
                var tn = new TagName(name);
                if (!tn.IsValid)
                    return false;
                return base.Find(tn.Name) != null;
            }

            public new (Tag,TagProperty) Find(string name)
            {
				var tn = new TagName(name);
				if (!tn.IsValid)
					return (null,TagProperty.None);
                return (base.Find(tn.Name), tn.RtdbProperty);

			}
		}


		private readonly StringListDictionaryQueue _backupFileNames = new StringListDictionaryQueue();
        private readonly IRtdbClientConnection _connection;
        private readonly IXmlProvider _xmlProvider;

        private readonly TagIdDictionary _tagIds = new TagIdDictionary();
        private readonly RangeDictionary _tagIdRanges=new RangeDictionary();
        private readonly Dictionary<int, HashSet<string>> _tagsInSubscription = new Dictionary<int, HashSet<string>>();

        private readonly TagsByName _tagsByName = new TagsByName();
        private readonly Dictionary<Guid,PropValueType> _dataTypes=new Dictionary<Guid,PropValueType>();
        private readonly TagsByGuid _tagsByGuid = new TagsByGuid();
        private readonly ILogger _logger;
        private readonly ISubscriptionManager _subscriptionManager;

        private readonly object _tagsLock = new object();
        private readonly string[] _userColumns=new string[5];
        private string _projectName = null;
        private string _defaultUser=null;


        private readonly IControlLogLevel _controlLogLevel;
        private readonly ManualResetEvent _systemEvent = new ManualResetEvent(false);

        private int _nextId = 0;
        private readonly Action _onShutdown;
        private IXmlDoc _xmlDoc;

        public IXmlDoc XmlDoc => _xmlDoc;
        public string DefaultUser => _defaultUser;

        public RtdbClient(IShutdown host, IControlLogLevel controlLogLevel,ISubscriptionManager subscriptionManager, IRtdbClientConnection rtdbClientConnection, ILogger logger)
        {
            _logger = logger?.ForContext<RtdbClient>() ?? throw new ArgumentNullException(nameof(logger));
            _connection = rtdbClientConnection;
            _xmlProvider = new XmlProvider();
            _onShutdown = () => { host.Shutdown(); };
            _controlLogLevel = controlLogLevel;
            _subscriptionManager = subscriptionManager;
            Connect();
            SubscribeLoggingTag();
            Task.Run(() =>
            {
                _connection.ForceClientUpdate("__system");
                for (;;)
                    _controlLogLevel.SetLevel(GetChangedLoggingTagValue());
            });
        }

        public RtdbClient(IShutdown host, IControlLogLevel controlLogLevel, IRtdbClientConnection connection,IXmlProvider xmlPropvider, ISubscriptionManager subscriptionManager, ILogger logger)
        {
            _logger = logger?.ForContext<RtdbClient>() ?? throw new ArgumentNullException(nameof(logger));
            _connection = connection;
            _xmlProvider = xmlPropvider;
            _onShutdown = () => { host.Shutdown(); };
            _subscriptionManager = subscriptionManager;
            _controlLogLevel = controlLogLevel;
            Connect();
            SubscribeLoggingTag();
            Task.Run(() =>
            {
				_connection.ForceClientUpdate("__system");
				for (; ; )
                    _controlLogLevel.SetLevel(GetChangedLoggingTagValue());
            });
        }

        public BindingReading ToAbstract(SimpleTaData ta)
        {
            if (string.IsNullOrEmpty(ta.m_strProp))
                return null;
            var res = _tagsByName.Find(ta.m_strProp);
            if (res.Item1==null)
                throw new Exception($"Tag {ta.m_strProp} does not exist in SynEnergy");
            return new BindingReading(new BindingDef (res.Item1.UniqueId,res.Item2), ta.TDValue, ta.m_PropertyStatus.ToString(), ta.m_TimeStamp);
        }

        public IEnumerable<BindingReading> ToAbstract(SimpleTaData[] ta)
        {
            var ret = new List<BindingReading>();
            foreach (var t in ta)
            {
                var res = _tagsByName.Find(t.m_strProp);
                if (res.Item1 == null)
                    throw new Exception($"Tag {t.m_strProp} does not exist in SynEnegry");
                ret.Add(new BindingReading(new BindingDef(res.Item1.UniqueId, res.Item2 ), t.TDValue, t.m_PropertyStatus.ToString(), t.m_TimeStamp));
            }
            return ret;
        }


        public BindingReading GetRtdbReading(BindingDef binding)
        {
            var name = _tagsByGuid.NameFromBinding(binding);
            return ToAbstract(_connection.GetValueByName(name));
        }

        public IEnumerable<BindingReading> GetRtdbReadings(ICollection<BindingDef> bindings)
        {
            var tags = new string[bindings.Count];
            var i = 0;
            foreach (var b in bindings)
            {
                var name = _tagsByGuid.NameFromBinding(b);
                tags[i++] = name;
            }
            return ToAbstract(_connection.GetSpecificValues(tags));
        }

        public IEnumerable<BindingReading> GetRtdbReadings(ICollection<Guid> bindings)
        {
            var tags = new string[bindings.Count];
            var i = 0;
            foreach (var b in bindings)
            {
                var name = _tagsByGuid.NameFromBinding(new BindingDef(b));
                tags[i++] = name;
            }
            return ToAbstract(_connection.GetSpecificValues(tags));
        }


        public bool SetTagValue(BindingTagValue bindingTagValue)
        {
            var name = _tagsByGuid.NameFromBinding(bindingTagValue.Binding);
            var ta = SimpleTaDataCreator.Create(new TagNameValue(name,bindingTagValue));
            if (ta == null)
                return false;
            _connection.SetValue(ta);
            return true;
        }

        public bool SetTagValues(ICollection<BindingTagValue> bindingTagValues)
        {
            var l = new List<TagNameValue>();
            foreach (var btv in bindingTagValues)
            {
                var name = _tagsByGuid.NameFromBinding(btv.Binding);
                l.Add(new TagNameValue(name, btv));
            }
            var tal = SimpleTaDataCreator.Create(l);
            if (tal == null)
                return false;
            _connection.SetValues(tal);
            return true;
        }

        public Reading GetTagValueByName(string tagName)
        {
            var ta = _connection.GetValueByName(tagName);
            return new Reading(ta.TDValue, ta.m_PropertyStatus.ToString(), ta.m_TimeStamp);
        }

        private void UnSubscribe(int subscription)
        {
            _logger.Warning($"SubscriptionLogging: Unsubscribe {subscription} is called.");
            _connection.UnSubscribe(subscription.ToString());

            if (_tagIdRanges.TryGetAndRemoveValue(subscription, out var range))
                _tagIds.RemoveIds(range.First, range.Second);
            _tagsInSubscription.Remove(subscription);
        }

        private bool ReSubscribe(int subscription, HashSet<string> tags)
        {
            var removed = new HashSet<string>();
            foreach (var t in tags)
                if (!_tagsByName.Exists(t))
                    removed.Add(t);
            foreach (var t in removed)
                tags.Remove(t);
            if (tags.Count == 0)
            {
                _subscriptionManager.UnSubscribe(subscription);
                return false;
            }
			var tas = SimpleTaDataCreator.Create(tags.Count);
            var i = 0;
			foreach (var t in tags)
			{
				tas[i].m_ID = Interlocked.Increment(ref _nextId);
                tas[i].m_strProp = t;
				_tagIds.Add(tas[i].m_ID, tas[i].m_strProp);
				i++;
			}
			_tagIdRanges.Add(subscription, tas[0].m_ID, tas[i - 1].m_ID);
			_connection.Subscribe(subscription.ToString(), tas);
            return true;
		}

		private void ReSubscribe()
        {
			SubscribeLoggingTag();
			_tagIds.Clear();
            _tagIdRanges.Clear();
            var removed = new HashSet<int>();
            foreach (var sub in _tagsInSubscription)
                if (!ReSubscribe(sub.Key, sub.Value))
                    removed.Add(sub.Key);
            foreach (var r in removed)
                _tagsInSubscription.Remove(r);
        }

        private void SubscribeLoggingTag()
        {
            var tas = SimpleTaDataCreator.Create(1);
            tas[0].m_strProp = KnownSystemTags.CurrentLoggingLevel;
            _connection.Subscribe("__system", tas);
        }
        private string GetChangedLoggingTagValue()
        {
            _systemEvent.WaitOne();
            _systemEvent.Reset();
            var ta = _connection.GetChangedValuesName("__system");
            if (ta == null)
                return null;
            foreach (var t in ta)
            {
                if (t.m_strProp == KnownSystemTags.CurrentLoggingLevel)
                    return (string)t.TDValue;
            }
            return null;
        }


        public bool Subscribe(int subscription, ICollection<BindingDef> bindings,CancellationToken token)
        {
            if (bindings.Count == 0)
                return false;
            _subscriptionManager.Subscribe(subscription, token, () => UnSubscribe(subscription));
            var tas = SimpleTaDataCreator.Create(bindings.Count);
            var i = 0;
            var tags = new HashSet<string>();
            foreach (var binding in  bindings)
            {
                tas[i].m_ID= Interlocked.Increment(ref _nextId);
                tas[i].m_strProp = _tagsByGuid.NameFromBinding(binding);
                tags.Add(tas[i].m_strProp);
                _tagIds.Add(tas[i].m_ID, tas[i].m_strProp);
                i++;
            }
            _tagsInSubscription.Add(subscription, tags);
            _tagIdRanges.Add(subscription, tas[0].m_ID, tas[i - 1].m_ID);
            return _connection.Subscribe(subscription.ToString(), tas);
        }

        public void Backup(int subscription,string destFolder,CancellationToken token)
        {
            _subscriptionManager.Subscribe(subscription, token, () => _backupFileNames.TryGetAndRemoveValue(subscription, out var dummy));
            _connection.StartBackup(destFolder,subscription);
        }


        public IEnumerable<string> GetBackupName(int subscription)
        {
            if (!_subscriptionManager.WaitForSubscription(subscription, 5000))
            {
                _subscriptionManager.UnSubscribe(subscription);
                return null;
            }
            return _backupFileNames.Get(subscription);
        }

        public void SaveConfigXml(string xmlFile)
        {
            _connection.SaveConfigXml(xmlFile);
        }

        public IEnumerable<BindingReading> GetChangedTagValues(int subscription)
        {
            if (!_subscriptionManager.WaitForSubscription(subscription))
            { 
                _logger.Warning($"SubscriptionLogging: WaitForSubscription {subscription} returns false.");
                return null;
            }
            var vals =_connection.GetChangedValuesName(subscription.ToString());
            if (vals == null)
            { 
                _logger.Warning($"SubscriptionLogging: GetChangedValuesName {subscription} returns null.");
                return null;
            }
            if (!_tagIds.AssignStrings(vals))
                return null;
            return ToAbstract(vals);
        }

        public void DataReady(string[] subs)
        {
            var intsubs = new List<int>();
            for (var i = 0; i < subs.Length; i++)
            {
                if (subs[i] == SystemPropertySets.__system.ToString())
                    _systemEvent.Set();
                else if (int.TryParse(subs[i], out var sub))
                    intsubs.Add(sub);
            }
            _subscriptionManager.NotifySubscriptions(intsubs);
        }

        public void Connect()
        {
            _connection.Connect(this);
        }

        private static PropValueType DataType(string SeDataType)
        {
            if (SeDataType == "Double" ||
                SeDataType == "Float")
                return PropValueType.Double;
            if (SeDataType == "String")
                return PropValueType.String;
            if (SeDataType == "DateTime")
                return PropValueType.DateTime;
            if (SeDataType == "Bit")
                return PropValueType.Bool;
            if (SeDataType == "Byte" ||
                SeDataType == "Ushort" ||
                SeDataType == "Short" ||
                SeDataType == "Ulong" ||
                SeDataType == "Long")
                return PropValueType.Integer;
            throw new Exception($"{SeDataType} is not a supported datatype");
        }

        public void NewConfig()
        {
            //Debugger.Launch();
            _xmlDoc = _xmlProvider.SharedXml(_connection.SharedXmlFileNo);
            if (_xmlDoc == null)
                return;
            lock (_tagsLock)
            {
                try
                {
                    _tagsByName.Clear();
                    _tagsByGuid.Clear();
                    _dataTypes.Clear();
                    var conf = _xmlDoc.Root.Element("Configuration");
                    foreach (var tag in _xmlDoc.Tags())
                    {
                        var name = TagName.Create(tag, TagProperty.None);
                        var guid = tag.ElementAttributeVal<Guid>("UniqueId");
                        var dataType = tag.ElementAttributeValue("DataType");
                        var alias = tag.ElementAttributeValue("Alias");
                        var description = tag.ElementAttributeValue("Description");
                        var useTrend = tag.ElementAttributeVal<bool>("UseTrend");
                        var pvt = DataType(dataType);
                        var t = new Tag { Alias = alias ?? "", Description = description ?? "", UseTrend = useTrend, Name = name, ValueType = pvt, UniqueId = guid };
                        _dataTypes.Add(guid, pvt);
                        _tagsByName.Add(t);
                        _tagsByGuid.Add(t);
                    }
                    var userColumns = conf.Element("UserColumns").Element("ArrayOfUserColumn").Elements("UserColumn");
                    for (var i = 0; i < 5; i++)
                        _userColumns[i] = null;
                    var j = 0;
                    foreach (var uc in userColumns)
                    {
                        if (!uc.ChildElementVal<bool>("InUse"))
                            break;
                        _userColumns[j++] = uc.Element("Name").Value;
                    }
                    _projectName = conf.Element("Project").Attribute("ProjectName").Value;
                    var other = _xmlDoc.SystemSettings().Element("OtherSettings");
                    _defaultUser = other.ElementAttributeValue("DefaultUser");
                    ReSubscribe();
                }
                catch (Exception e)
                {
                    _logger.Error(e,e.Message);
                }
            }
        }

        public void Ping()
        {
            _connection.Ping();
        }

        public IEnumerable<Tag> GetTags()
        {
            var ret = new List<Tag>();
            lock (_tagsLock)
            {
               ret.AddRange(_tagsByName);
            }
            return ret;
        }

        public IEnumerable<string> UserColumns()
        {
            lock (_tagsLock)
            {
                var ret = new List<string>();
                for (var i = 0; i < 5; i++)
                    if (_userColumns[i] != null)
                        ret.Add(_userColumns[i]);
                    else
                        break;
                return ret;
            }

        }

        public String ProjectName()
        {
            return _projectName;
        }

        public string BindingTagName(Guid binding)
        {
            return _tagsByGuid.NameFromGuid(binding);
        }

        public PropValueType? DataType(Guid binding)
        {
            if (!_dataTypes.TryGetValue(binding, out var pvt))
                return null;
            return pvt;
        }

        public Tag GetTagByGuid(Guid guid)
        {
            return _tagsByGuid.Find(guid);
        }

        public void ShutDown()
        {
            _onShutdown();
        }

        public void Exception(Exception e)
        {
            _logger.Error(e,"exception in RtdbClient");
        }

        public void KeepAlive()
        {
        }

        public void Maintenance()
        {
        }

        public void Start()
        {
        }

        public void Stop()
        {
        }


        public void Command(string cmd, int id)
        {
            throw new NotImplementedException();
        }

        public void CommandResponse(string cmd, int id)
        {
            throw new NotImplementedException();
        }

        public void StartBackup(string destFolder, int sub)
        {
        }

        public void BackupFileToBeCreated(string filename, int sub)
        {
            _backupFileNames.Add(sub, filename);
            _subscriptionManager.NotifySubscription(sub);
        }

        public Tag GetTagByName(string name)
        {
            return _tagsByName.Find(name).Item1;
        }

        public void ResetDefaultUser()
        {
            _defaultUser = null;
        }
    }
}
