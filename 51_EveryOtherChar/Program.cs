//29.Write a C# Sharp program to create a new string made of every other character
//starting with the first from a given string. Go to the editor

//Sample Input:
//"Python"
//"PHP"
//"JS"
//Expected Output:
//Pto
//PP
//J

using System;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("51_EveryOtherChar.Tests")]

namespace _51_EveryOtherChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Provide a string: ");
            var str = Console.ReadLine();
            var result = str.EveryOtherChar();
        }
    }

    internal static class stringExtension
    {
        internal static  string EveryOtherChar(this string str)
        {
            var result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                    result += str[i];
            }

            return result.Trim();
        }
    }
}
