//47.Write a C# Sharp program to check if it is possible
//to add two integers to get the third integer from three
//given integers. Go to the editor

//Sample Input:
//1, 2, 3
//4, 5, 6
//- 1, 1, 0
//Expected Output:
//True
//False
//True

using System;
using System.Linq;
using System.Runtime.CompilerServices;
[assembly:InternalsVisibleTo("65_CheckAddition.Tests")]

namespace _65_CheckAddition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Provide string: ");
            var str = Console.ReadLine();
            var result = str.CheckAddition();
            Console.WriteLine(result);
        }
    }

    internal static class stringExtensions
    {
        internal static bool CheckAddition(this string str)
        {
            var result = false;
            var arrayofInt = str.Split(',').Select(int.Parse).ToArray();
            if (arrayofInt[0] + arrayofInt[1] == arrayofInt[2])
                result = true;
            return result;
        }
    }
}
