//20.Write a C# Sharp program to check whether two given
//integers are in the range 40..50 inclusive, or they are
//both in the range 50..60 inclusive. Go to the editor

//Sample Input:
//78, 95
//25, 35
//40, 50
//55, 60
//Expected Output:
//False
//False
//True
//True

using System;
using System.Runtime.CompilerServices;
[assembly:InternalsVisibleTo("44_RangeInclusive.Tests")]

namespace _44_RangeInclusive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    internal static class ArrayExtension
    {
        internal static bool CheckRange(this int[] inputArray)
        {
            var result = false;
            result = CheckRange(inputArray, 40, 50) | CheckRange(inputArray, 50, 60);
            return result;
        }

        private static bool CheckRange(int[] inputArray1, int v1, int v2)
        {
            var result = false;
            result = inputArray1[0] >= v1 && inputArray1[0] <= v2
                && inputArray1[1] >= v1 && (inputArray1[1] <= v2);

            return result;
        }
    }
}
