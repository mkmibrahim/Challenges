using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly:InternalsVisibleTo("89_Enums.Tests")]

namespace _89_Enums
{
        internal class Logs
    {

    }

    enum LogLevel
    {
        Unknown = 0,
        Trace = 1, //TRC
        Debug = 2, //DBG
        Info = 4, //INF
        Warning = 5, //WRN
        Error = 6, //ERR
        Fatal = 42, //FTL
    }
    
    static class LogLine
    {
        public static LogLevel ParseLogLevel(string logLine)
        {
            var shortLogLevelString = logLine.Substring(1,3);
            LogLevel result = LogLevel.Unknown;
            if (shortLogLevelString == "TRC")
                result = LogLevel.Trace;
            if (shortLogLevelString == "DBG")
                result = LogLevel.Debug;
            if (shortLogLevelString == "INF")
                result = LogLevel.Info;
            if (shortLogLevelString == "WRN")
                result = LogLevel.Warning;
            if (shortLogLevelString == "ERR")
                result = LogLevel.Error;
            if (shortLogLevelString == "FTL")
                result = LogLevel.Fatal;
            return result; 
        }

        public static string OutputForShortLog(LogLevel logLevel, string message)
        {
            var result = (int) logLevel + ":" + message;
            return result;
        }


    }
}
