//15. Write a C# Sharp program to check whether three given integer values
//are in the range 20..50 inclusive. Return true if 1 or more of them
//are in the said range otherwise false. Go to the editor

//Sample Input:
//11, 20, 12
//30, 30, 17
//25, 35, 50
//15, 12, 8
//Expected Output:
//True
//True
//True
//False

using System;
using System.Runtime.CompilerServices;
[assembly:InternalsVisibleTo("41_CheckInts.Tests")]

namespace _41_CheckInts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();
            Console.WriteLine(str.CheckInts());
        }

    }

    internal static class stringExtension
    {
        internal static bool CheckInts(this string str)
        {
            var result = false;
            var stringArray = str.Split(',');
            for (int i = 0; i < stringArray.Length; i++)
            {
                var value = int.Parse(stringArray[i].Trim());
                result = (value >= 20 && value <= 50) ? true : result;
            }
            return result; ;
        }
    }
}
