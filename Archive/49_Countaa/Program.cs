//27.Write a C# Sharp program to count the string "aa" in
//a given string and assume "aaa" contains two "aa".

//Sample Input:
//"bbaaccaag"
//"jjkiaaasew"
//"JSaaakoiaa"
//Expected Output:
//2
//2
//3



using System;
using System.Runtime.CompilerServices;
[assembly:InternalsVisibleTo("49_Countaa.Tests")]

namespace _49_Countaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string:");
            var str = Console.ReadLine();
            //var count = str.Countaa();
        }
    }

    internal static class stringExtension
    {
        internal static int Countaa(this string str)
        {
            var result = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a')
                {
                    if (i+1< str.Length && str[i+1]=='a')
                        result++;
                }
                
            }
            
            return result;
        }
    }
}
