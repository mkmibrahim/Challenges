//41.Write a C# Sharp program that accept two integers and return true
//if either one is 5 or their sum or difference is 5. Go to the editor

//Sample Input:
//5, 4
//4, 3
//1, 4
//Expected Output:
//True
//False
//True

using System;
using System.Runtime.CompilerServices;
[assembly:InternalsVisibleTo("60_SumIsFive.Tests")]

namespace _60_SumIsFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide string:");
            var str = Console.ReadLine();
            var result = str.IsSumFive();
            Console.WriteLine(result);

        }
    }

    internal static class stringExtension
    {
        internal static bool IsSumFive(this string str)
        {
            var result = false;
            var firstNumber = int.Parse(str.Split(',')[0]);
            var secondNumber = int.Parse(str.Split(',')[1].Trim());
            result = firstNumber == 5 ||
                     secondNumber == 5 ||
                     Math.Abs(firstNumber - secondNumber) == 5 ||
                     firstNumber + secondNumber == 5;
            return result;
        }
    }
}
