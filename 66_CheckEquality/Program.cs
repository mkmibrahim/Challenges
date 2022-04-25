//49.Write a C# Sharp program to check if three given numbers are in strict
//increasing order, such as 4 7 15, or 45, 56, 67, but not 4 ,5, 8 or 6, 6, 8.
//However,if a fourth parameter is true, equality is allowed, such as 6, 6, 8
//or 7, 7, 7. Go to the editor

//Sample Input:
//1, 2, 3, false
//1, 2, 3, true
//10, 2, 30, false
//10, 10, 30, true
//Expected Output:
//True
//True
//False
//True

using System;
using System.Runtime.CompilerServices;
[assembly:InternalsVisibleTo("66_CheckEquality.Tests")]

namespace _66_CheckEquality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            var str = Console.ReadLine();
            var result = str.CheckEquality();
            Console.WriteLine(result);
        }
    }

    internal static class stringExtensions
    {
        internal static bool CheckEquality(this string str)
        {
            var result = false;
            var firstNumber = getNumber(str, 0);
            var secondNumber = getNumber(str, 1);
            var thirdNumber = getNumber(str, 2);
            var equalityAllowed = bool.Parse(str.Split(',')[3]);
            if (equalityAllowed)
            {
                if (firstNumber <= secondNumber &&
                    secondNumber <= thirdNumber)
                    result = true;
            }
            else
            {
                if (firstNumber < secondNumber &&
                    secondNumber < thirdNumber)
                    result = true;
            }

            return result;
        }

        private static int getNumber(string str, int v)
        {
            if (v < 3)
                return int.Parse(str.Split(',')[v]);
            else
                return 0;
        }
    }
}
