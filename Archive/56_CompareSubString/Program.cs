//35.Write a C# Sharp program to compare two given
//strings and return the number of the positions
//where they contain the same length 2 substring.

//Sample Input:
//"abcdefgh", "abijsklm"
//"abcde", "osuefrcd"
//"pqrstuvwx", "pqkdiewx"
//Expected Output:
//1
//1
//2

using System;
using System.Runtime.CompilerServices;
[assembly:InternalsVisibleTo("56_CompareSubString.Tests")]

namespace _56_CompareSubString
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
        internal static int CheckSubString(this string str, string otherString)
        {
            int result = 0;
            char currentChar;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < otherString.Length; j++)
                {
                    if (str[i] == otherString[j] &&
                        i+1 < str.Length &&
                        j+1 < otherString.Length &&
                        str[i+1] == otherString[j+1])
                        result++;
                }
            }
            return result;
        }
    }
}
