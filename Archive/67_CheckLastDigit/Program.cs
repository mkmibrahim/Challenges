//50.Write a C# Sharp program to check if two or more non-negative given
//integers have the same rightmost digit. Go to the editor

//Sample Input:
//11, 21, 31
//11, 22, 31
//11, 22, 33
//Expected Output:
//True
//True
//False

using System;
using System.Linq;
using System.Runtime.CompilerServices;
[assembly:InternalsVisibleTo("67_CheckLastDigit.Tests")]


namespace _67_CheckLastDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Provide string: ");
            var str = Console.ReadLine();
            var result = str.CheckLastDigit();
            Console.WriteLine(result);
        }
    }


    internal static class stringExtensions
    {
        internal static bool CheckLastDigit(this string str)
        {
            var result = true;
            var intArray = str.Split(',').Select(n => Convert.ToInt32(n)).ToArray();
            var lastDigit = intArray[0] % 10;
            for(int i = 0; i < intArray.Length; i++)
            {
                result = result && (intArray[i] % 10 == lastDigit);
            }

            return result;
        }
    }
}
