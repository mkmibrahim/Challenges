//24.Write a C# Sharp program to convert the last 3 characters of a given
//string in upper case. If the length of the string has less than 3 then
//uppercase all the characters.

//Sample Input:
//"Python"
//"Javascript"
//"js"
//"PHP"
//Expected Output:
//PytHON
//JavascrIPT
//JS
//PHP

using System;
using System.Runtime.CompilerServices;
[assembly:InternalsVisibleTo("47_ConvertLastThreeChars.Tests")]

namespace _47_ConvertLastThreeChars
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
        internal static string ConvertLastThreeChars(this string str)
        {
            var result = "";
            if (String.IsNullOrEmpty(str))
                return result;
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str.Length - i > 3)
                        result += str[i];
                    else
                        result += Char.ToUpper(str[i]);
                }
                
            }
            return result;

        }
    }
}
