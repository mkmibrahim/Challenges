//8.Write a C# Sharp program to create a new string
//which is 4 copies of the 2 front characters
//of a given string. If the given string length
//is less than 2 return the original string.
//Go to the editor

//Sample Input:
//"C Sharp"
//"JS"
//"a"
//Expected Output:
//C C C C 
//JSJSJSJS
//a

using System;
using System.Runtime.CompilerServices;
[assembly:InternalsVisibleTo("40_RepeatFirstTwo.Tests")]

namespace _40_RepeatFirstTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string:");
            var str = Console.ReadLine();
            Console.Write("output is: ");
            Console.WriteLine(str.RepeatFirstTwo());

        }
    }

    internal static class stringExtension
    {
        internal static string RepeatFirstTwo(this string str)
        {
            var result = str;
            if(str.Length > 1)
            {
                result = str[0].ToString() + str[1].ToString()
                    + str[0].ToString() + str[1].ToString()
                    + str[0].ToString() + str[1].ToString()
                    + str[0].ToString() + str[1].ToString(); ;


            }
            return result;
        }
    }
}
