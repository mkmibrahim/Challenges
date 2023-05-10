using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace _17_RegExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
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
                //Console.WriteLine("Before: " + beforeSeparator);
                //Console.WriteLine("After: " + afterSeparator);
                //Console.WriteLine("----");
            }
            return result.ToArray();
        }

        public int CountQuotedPasswords(string lines)
        {
            throw new NotImplementedException($"Please implement the LogParser.CountQuotedPasswords() method");
        }

        public string RemoveEndOfLineText(string line)
        {
            throw new NotImplementedException($"Please implement the LogParser.RemoveEndOfLineText() method");
        }

        public string[] ListLinesWithPasswords(string[] lines)
        {
            throw new NotImplementedException($"Please implement the LogParser.ListLinesWithPasswords() method");
        }
    }

}