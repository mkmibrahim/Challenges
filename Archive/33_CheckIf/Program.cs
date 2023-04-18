using System;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("33_CheckIf.Tests")]

namespace _33_CheckIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter String:");
            var str = Console.ReadLine();
            var result = str.IfCheck();
            Console.WriteLine(result);

        }
    }

    public static class StringExtension
    {
        public static string IfCheck(this string str)
        {
            var result = "";
            if (str.Substring(0, 3) != "if ")
                result = "if " + str;
            else 
                result = str;
            return result;
        }
    }
}
