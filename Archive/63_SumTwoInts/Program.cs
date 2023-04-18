//45.Write a C# Sharp program to compute the sum of the two
//given integers. If one of the given integer value is in
//the range 10..20 inclusive return 18. Go to the editor

//Sample Input:
//3, 7
//10, 11
//10, 20
//21, 220
//Expected Output:
//10
//18
//18
//241

using System;
using System.Runtime.CompilerServices;
[assembly:InternalsVisibleTo("63_SumTwoInts.Tests")]

namespace _63_SumTwoInts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Provide string: ");
            var str = Console.ReadLine();

        }
    }

    internal static class stringExtensions
    {
        internal static int GetSpecialSum(this string str)
        {
            var firstInt = GetInt(str, 0);
            var secondInt = GetInt(str, 1);
            var result = 0;
            if (firstInt >= 10 && firstInt <= 20)
                result = 18;
            else
                result = firstInt + secondInt;
            return result;
        }

        private static int GetInt(string str, int position)
        {
            return int.Parse(str.Split(',')[position]);
        }
    }
}
