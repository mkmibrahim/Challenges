//17.Write a C# Sharp program to check if a string 'yt'
//appears at index 1 in a given string. If it appears
//return a string without 'yt' otherwise return
//the original string.

//Sample Input:
//"Python"
//"ytade"
//"jsues"
//Expected Output:
//Phon
//ytade
//jsues
using System;
using System.Runtime.CompilerServices;
[assembly:InternalsVisibleTo("42_Findyt.Tests")]

namespace _42_Findyt
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
        internal static string Checkyt(this string str)
        {
            var result = str;
            if (str[1] == 'y' && str[2] == 't')
                result = str[0] + str[3..];
            return result;
        }
    }
}
