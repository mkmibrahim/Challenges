//38.Write a C# Sharp program to count the number of two 5's are next
//to each other in an array of integers. Also count the situation
//where the second 5 is actually a 6. Go to the editor

//Sample Input:
//{ 5, 5, 2 }
//{ 5, 5, 2, 5, 5 }
//{ 5, 6, 2, 9}
//Expected Output:
//1
//2
//1

using System;
using System.Linq;
using System.Runtime.CompilerServices;
[assembly:InternalsVisibleTo("58_CountTwoFives.Tests")]

namespace _58_CountTwoFives
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Provide string: ");
            var str = Console.ReadLine();

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
        internal static int CountFives(this int[] array)
        {
            var result = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == 5 &&
                    i + 1 < array.Length &&
                    (array[i + 1] == 5 || array[i + 1] == 6))
                    result++;
            }
            return result;
        }
    }
}
