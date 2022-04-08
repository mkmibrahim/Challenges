//36.Write a C# Sharp program to create a new string from a give
//string where a specified character have been removed except
//starting and ending position of the given string. Go to the editor

//Sample Input:
//"xxHxix", "x"
//"abxdddca", "a"
//"xabjbhtrb", "b"
//Expected Output:
//xHix
//abxdddca
//xajhtrb

using System;
using System.Runtime.CompilerServices;
[assembly:InternalsVisibleTo("57_RemoveChar.Tests")]

namespace _57_RemoveChar
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
        internal static string RemoveChar(this string str, char inputChar)
        {
            var result = str[0].ToString();
            for(int i = 1; i < str.Length-1; i++)
            {
                if (str[i] != inputChar)
                    result += str[i];
            }
            result += str[str.Length-1];
            return result;
        }
    }
}
