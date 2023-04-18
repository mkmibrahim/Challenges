//34.Write a C# Sharp program to check whether the sequence of numbers 1,
//2, 3 appears in a given array of integers somewhere. Go to the editor

//Sample Input:
//{ 1,1,2,3,1}
//{ 1,1,2,4,1}
//{ 1,1,2,1,2,3}
//Expected Output:
//True
//False
//True


using System;

using System.Runtime.CompilerServices;
[assembly:InternalsVisibleTo("55_CheckSequence.Tests")]

namespace _55_CheckSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide string: ");
            var str = Console.ReadLine();
            bool result = str.CheckSequence();
        }
    }

    internal static class stringExtensions
    {
        internal static bool CheckSequence(this string str)
        {
            var result = false;
            if(str.Contains("1,2,3"))
                result = true;
            return result;
        }
    }
}
