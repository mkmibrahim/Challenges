//30.Write a C# Sharp program to create a string like "aababcabcd" from
//a given string "abcd". Go to the editor

//Sample Input:
//"abcd"
//"abc"
//"a"
//Expected Output:
//aababcabcd
//aababc
//a

using System;
using System.Runtime.CompilerServices;
[assembly:InternalsVisibleTo("53_RepeatFirstChars.Tests")]

namespace _53_RepeatFirstChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Provide a string: ");
            var str = Console.ReadLine();
            //var result = str.RepeatFirstChars();
        }
    }

    internal static class stringExtension
    {
        internal static string RepeatFirstChars(this string str)
        {
            var result = "";
            for (var i = 0; i < str.Length; i++)
            {
                for (var j = 0; j <= i; j++)
                    result += str[j];
            }
            return result;
        }
    }
}
