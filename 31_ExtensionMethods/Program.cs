using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace _31_ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class LogAnalysis
    {
        public static string SubstringAfter(this string str, string searchSubstring)
        {
            var columnPosition = str.IndexOf(searchSubstring);
            return str.Substring(columnPosition+searchSubstring.Length);
        }

        public static string SubstringBetween(this string str, string firstString, string secondString)
        {
            var firstIndex = str.IndexOf(firstString)+firstString.Length;
            var secondIndex = str.IndexOf(secondString);
            return str.Substring(firstIndex, secondIndex - firstIndex);
        }

        public static string Message(this string str) => str.SubstringAfter(": ");

        public static string LogLevel(this string str) => str.SubstringBetween("[","]");
    }
}