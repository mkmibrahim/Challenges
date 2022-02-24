//26.Write a C# Sharp program to create a new string which
//is n (non-negative integer) copies of the the first 3 characters
//of a given string. If the length of the given string is less
//than 3 then return n copies of the string. Go to the editor

//Sample Input:
//"Python", 2
//"Python", 3
//"JS", 3
//Expected Output:
//PytPyt
//PytPytPyt
//JSJSJS

using System;
using System.Linq;
using System.Runtime.CompilerServices;
[assembly:InternalsVisibleTo("48_RepeatFirstChars.Tests")]

namespace _48_RepeatFirstChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    internal static class stringExtension
    {
        internal static string RepeatFirstChars(this string str, int inputInt)
        {
            if (str == null)
                return String.Empty;
            var repitionChars = str.Length <= inputInt ? str.Length : 3;
            var sub = str.Substring(0, repitionChars);
            var result = string.Concat(Enumerable.Repeat(sub, inputInt));
            return result;
        }
    }
    
}
