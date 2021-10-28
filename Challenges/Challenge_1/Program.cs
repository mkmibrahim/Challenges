//Write the program which takes input 10 elements in the array and reverse the elements in the array without using any other array.

//    Example :
//1.If user gives input 1,2,3,4,5,5,4,7,3,6 then output should be in this format:
//6 3 7 4 5 5 4 3 2 1

//2.If user gives input 25,23,,26,12,45,65,58,24,27,13 then output should be in this format:
//13 27 24 58 65 45 12 26 23 25

//Note: Make sure the output format is same as above given example.
using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter the array elements[" + i + "]:");
                arr[i] = int.Parse(Console.ReadLine());
            }

            string val = Console.ReadLine();
            var valReversed = ReverseArrayHelper.ReverseValues(arr);

            for (int i = 0; i < 10; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
