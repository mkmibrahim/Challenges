//Write a C# program to check if a given string is a palindrome or not
using System;

namespace Strings_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            var str = Console.ReadLine();
            if (str.Palindromecheck())
                Console.WriteLine("string is palindrome.");
            else
                Console.WriteLine("string is not palindrome.");
        }
    }

    public static class stringExtension
    {
        public static bool Palindromecheck(this string str)
        {
            var result = true;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                    result = false;
            }
            return result;
        }
    }
}
