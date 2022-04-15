//42.Write a C# Sharp program to test if a given non-negative number is
//a multiple of 13 or it is one more than a multiple of 13. 

//Sample Input:
//13
//14
//27
//41
//Expected Output:
//Truen
//True
//True
//False

using System;
using System.Runtime.CompilerServices;
[assembly:InternalsVisibleTo("61_Multiple13.Tests")]

namespace _61_Multiple13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number");
            var str = Console.ReadLine();
            if (!int.TryParse(str, out var val))
                Console.WriteLine(str + " is not a number");
            var result = val.CheckMultiple13();
        }
    }

    internal static class intExtensions
    {
        static internal bool CheckMultiple13(this int num)
        {
            return num % 13 == 0 || num % 13 == 1;
        }
    }
}
