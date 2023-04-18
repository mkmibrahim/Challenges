//Write a program that receives a string.
//If the string ends in "ly" it displays true, otherwise it displays false.
using System;

namespace Strings_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("String:");
            var input = Console.ReadLine();
            Console.WriteLine(input.LyCheck());
        }
    }

    public static class StringExtension
    {
        public static bool LyCheck(this string str)
        {
            var result = false;
            var strLength = str.Length;
            if (str[strLength - 1] == 'y' && str[strLength - 2] == 'l')
                result = true;
            return result;
        }
    }
}
