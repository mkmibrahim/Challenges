//39.Write a C# Sharp program to check if a triple is presents in
//an array of integers or not. If a value appears three times in
//a row in an array it is called a triple. Go to the editor

//Sample Input:
//{ 1, 1, 2, 2, 1 }
//{ 1, 1, 2, 1, 2, 3 }
//{ 1, 1, 1, 2, 2, 2, 1 }
//Expected Output:
//False
//False
//True


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
[assembly:InternalsVisibleTo("59_CheckTriple.Tests")]

namespace _59_CheckTriple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Provide string:");
            var str = Console.ReadLine();
            var array = str.ToArray();
            var result = array.CheckTriple();
        }
    }

    internal static class stringExtension
    {
        internal static int[] ToArray(this string str)
        {
            var newString = str.Remove(0, 2);

            var str2 = newString.Remove(newString.IndexOf('}'), 1).Trim();

            int[] array = str2.Split(',').Select(int.Parse).ToArray();

            return array;
        }
    }

    internal static class arrayExtension
    {
        internal static bool CheckTriple(this int[] array)
        {
            var result = false;
                for (int i = 0; i < array.Length; i++)
                {
                    result = i+1 < array.Length && array[i+1] == array[i]
                            && i+2 < array.Length && array[i+2] == array[i];
                    if (result)
                        break;
                }
            return result;
        }
    }

}
