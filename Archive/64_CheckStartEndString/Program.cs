//46.Write a C# Sharp program to check whether a given string starts
//with "F" or ends with "B". If the string starts with "F" return "Fizz"
//and return "Buzz" if it ends with "B" If the string starts with "F" and
//ends with "B" return "FizzBuzz". In other cases return the original string.
//Go to the editor

//Sample Input:
//"FizzBuzz"
//"Fizz"
//"Buzz"
//"Founder"
//Expected Output:
//Fizz
//Fizz
//Buzz
//Fizz

using System;
using System.Runtime.CompilerServices;
[assembly:InternalsVisibleTo("64_CheckStartEndString.Tests")]

namespace _64_CheckStartEndString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Provide string: ");
            var str = Console.ReadLine();
            var result = str.CheckStartEndString();

        }
    }

    internal static class stringExtensions
    {
        internal static string CheckStartEndString(this string str)
        {
            var result = "";
            if (str[0] == 'F' && str[str.Length-1] == 'B')
                result = "FizzBuzz";
            else if (str[0] == 'F')
                result = "Fizz";
            else if (str[str.Length -1] == 'B')
                result = "Buzz";
            else
                result = str;
            return result;
        }
    }
}
