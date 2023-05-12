using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _17_RegExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class LogParser
    {
        public bool IsValidLine(string text)
        {
            var pattern =  @"^\[(\w{3})\]";
            Match match = Regex.Match(text, pattern);

            if (match.Success)
            {
                var result = Enum.TryParse<LogLevel>(match.Groups[1].Value, out LogLevel test);
                return result;
            }
            else
                return false;

        }

        enum LogLevel
        {
            TRC,
            DBG,
            INF,
            WRN,
            ERR,
            FTL
        }
       

        public string[] SplitLogLine(string text)
        {
            var result = new List<string>();
            string pattern = @"(.*?)<[-=^*]+>(.*?)(?=<[-=^*]+>|$)";

            MatchCollection matches = Regex.Matches(text, pattern);
            foreach (Match match in matches)
            {
                string beforeSeparator = match.Groups[1].Value.Trim();
                string afterSeparator = match.Groups[2].Value.Trim();

                if (!result.Contains(beforeSeparator) && !String.IsNullOrEmpty(beforeSeparator))
                    result.Add(beforeSeparator);
                if (!result.Contains(afterSeparator) && !string.IsNullOrEmpty(afterSeparator))
                    result.Add(afterSeparator);
            }
            if (result.Count ==  0)
                result.Add(String.Empty);
            return result.ToArray();
        }

        public int CountQuotedPasswords(string lines)
        {
            string pattern = @"""[^""\n]*password[^""\n]*""";

            MatchCollection matches = Regex.Matches(lines, pattern, RegexOptions.IgnoreCase);
            var result = matches.Count;
            return result;
        }

        public string RemoveEndOfLineText(string line)
        {
            return Regex.Replace(line, @"end-of-line\d+", "");
            
        }

        public string[] ListLinesWithPasswords(string[] lines)
        {
            List<string> result = new List<string>();

            foreach (string line in lines)
            {
                if (HasOffendingPassword(line))
                {
                    string offendingPassword = GetOffendingPassword(line);
                    result.Add($"{offendingPassword}: {line}");
                }
                else
                {
                    result.Add($"--------: {line}");
                }
            }

            return result.ToArray();
        }

        private bool HasOffendingPassword(string line)
        {
            
            string expressionString = @"\bpassword[a-zA-Z0-9]+\b";
            var result =  Regex.IsMatch(line, expressionString, RegexOptions.IgnoreCase);
            return result;
        }

        private string GetOffendingPassword(string line)
        {
            Match match = Regex.Match(line, @"\bpassword[a-zA-Z0-9]+\b", RegexOptions.IgnoreCase);
            return match.Value;
        }
        
    }
}
