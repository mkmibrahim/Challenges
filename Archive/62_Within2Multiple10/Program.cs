//44.Write a C# Sharp program to check if a given number is within 2 of a multiple of 10.


//Sample Input:
//3
//7
//8
//21
//Expected Output:
//False
//False
//True
//True

using System;
using System.Runtime.CompilerServices;
[assembly:InternalsVisibleTo("62_Within2Multiple10.Tests")]

namespace _62_Within2Multiple10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Provide string: ");
            var str = Console.ReadLine();
            bool result = str.CheckWithin2Multiple10();
            Console.WriteLine("Result is " + result);
        }
    }

    internal static class stringExtensions
    {
        internal static bool CheckWithin2Multiple10(this string str)
        {
            var result = false;
            if (int.TryParse(str, out int num))
            {
                var numWithout10s = num % 10;
                if (10 - numWithout10s <= 2 ||
                    numWithout10s <= 2)
                    result = true;
            }
            return result;
        }
    }
}
