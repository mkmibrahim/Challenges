//28.Write a C# Sharp program to check if the first appearance
//of "a" in a given string is immediately followed by
//another "a". Go to the editor

//Sample Input:
//"caabb"
//"babaaba"
//"aaaaa"
//Expected Output:
//True
//False
//True


using System;
using System.Runtime.CompilerServices;
[assembly:InternalsVisibleTo("50_CheckFirstA.Tests")]

namespace _50_CheckFirstA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string:");
            var str = Console.ReadLine();

        }
    }

    internal static class stringExtension
    {
        internal static bool CheckFirstA(this string str)
        {
            var result = false;
            if (str == null || String.IsNullOrEmpty(str))
                return result;
            var firstA = false;
            for(var i= 0; i<str.Length; i++)
            {
                if (str[i]== 'a' && !firstA)
                {
                    firstA = true;
                    if (i+1 <str.Length && str[i+1]== 'a') 
                        result = true;
                }
            }
            return result;
        }
    }


}
