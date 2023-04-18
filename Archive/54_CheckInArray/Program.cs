//33.Write a C# Sharp program to check if one of the first 4 elements
//in an array of integers is equal to a given element.

//Sample Input:
//{ 1,2,9,3}, 3
//{ 1,2,3,4,5,6}, 2
//{ 1,2,2,3}, 9
//Expected Output:
//True
//True
//False

using System;
using System.Linq;
using System.Runtime.CompilerServices;
[assembly:InternalsVisibleTo("54_CheckInArray.Tests")]

namespace _54_CheckInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please provie input:");
            var str = Console.ReadLine();

        }
    }

    internal class Helper1
    {
        internal Helper1()
        {
            
        }

        internal static Helper1 Make()
        {
            return new Helper1();
        }

        internal bool Procees(string str)
        {
            var intArray = getArray(str);
            var valueToCheck = getValueToCheck(str);
            var result = intArray.Contains(valueToCheck);
            return result;
        }

        private int getValueToCheck(string str)
        {
            int result = int.Parse(str[str.Length-1].ToString());
            return result;
        }

        private int[] getArray(string str)
        {
            var arrayEnd = str.IndexOf("}");
            var arrayString = str.Substring(2, arrayEnd-2);
            int[] result = arrayString.Split(',')
                                      .Select(int.Parse)
                                      .ToArray();
            return result;
        }
    }
}
