
using System.Runtime.CompilerServices;

[assembly:InternalsVisibleTo("22_Strings.Tests")]

namespace _22_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            LogLine.Message("test");
        }
    }

    static class LogLine
    {
        public static string Message(string logLine) => 
                        logLine.Substring(logLine.LastIndexOf(':') + 1).Trim();

        public static string LogLevel(string logLine) => 
                        logLine.Substring(logLine.IndexOf('[') + 1, logLine.IndexOf(']') - 1)
                          .Trim().ToLower();

        public static string Reformat(string logLine) => 
                        LogLine.Message(logLine) + " (" + LogLine.LogLevel(logLine) + ")";
    }

}