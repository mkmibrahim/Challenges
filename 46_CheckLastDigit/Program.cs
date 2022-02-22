//23.Write a C# Sharp program to check if two given
//non-negative integers have the same last digit.


//Sample Input:
//123, 456
//12, 512
//7, 87
//12, 45
//Expected Output:
//False
//True
//True
//False

using System;
using System.Runtime.CompilerServices;
[assembly:InternalsVisibleTo("46_CheckLastDigit.Tests")]

namespace _46_CheckLastDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    internal static class Helper
    {
        internal static bool CheckLastDigits(int firstInt, int secondInt)
        {
            var lastDigitFirstInt = firstInt % 10;
            var lastDigitSecondInt = secondInt % 10;
            var result = lastDigitFirstInt == lastDigitSecondInt;
            return result;
        }
    }
}
