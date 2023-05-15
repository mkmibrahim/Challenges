using System;
using System.Collections.Generic;
using System.Globalization;
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
        private string validLinePattern  =  @"^\[(TRC|DBG|INF|WRN|ERR|FTL)\]";
        private readonly string splitLinePattern = @"<[\^*=-]+>";
        private readonly string quotedPasswordsPattern =  @""".*password.*""";
        private readonly string endOfLinePattern = @"end-of-line\d+";

        public bool IsValidLine(string text) => Regex.IsMatch(text, validLinePattern);

        public string[] SplitLogLine(string text) => Regex.Split(text, splitLinePattern);

        public int CountQuotedPasswords(string lines) => Regex.Matches(lines, quotedPasswordsPattern, RegexOptions.IgnoreCase).Count;

        public string RemoveEndOfLineText(string line) => Regex.Replace(line, endOfLinePattern, string.Empty);


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
