//22.Write a C# Sharp program to check if a given string
//contains between 2 and 4 'z' character. Go to the editor

//Sample Input:
//"frizz"
//"zane"
//"Zazz"
//"false"
//"zzzz"
//"ZZZZ"
//Expected Output:
//True
//False
//True
//False
//True
//False

using System;
using System.Runtime.CompilerServices;
[assembly:InternalsVisibleTo("45_ContainsZ.Tests")]

namespace _45_ContainsZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string:");
            var str = Console.ReadLine();
            var result = str.CheckZ();
        }
    }

    internal static class stringExtension
    {
        internal static bool CheckZ(this string inputString)
        {
            var result = false;
            var zCount = 0;
            for(var i = 0; i < inputString.Length; i++)
                zCount = inputString[i]== 'z' ? zCount + 1 : zCount;
            if (zCount >= 2 && zCount <= 4)
                result = true;
            return result;
        }
    }
}
