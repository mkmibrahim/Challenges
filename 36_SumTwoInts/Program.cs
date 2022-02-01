//Write a C# Sharp program to compute the sum of the
//two given integer values. If the two values are
//the same, then return triple their sum. Go to the editor
//https://www.w3resource.com/csharp-exercises/basic-algo/index.php

//Sample Input:
//1, 2
//3, 2
//2, 2
//Expected Output:
//3
//5
//12

using System;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("36_SumTwoInts.Tests")]

namespace _36_SumTwoInts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    internal class ProgramHelper
    {
        private ProgramHelper()
        {

        }

        internal static ProgramHelper Make()
        {
            return new ProgramHelper();
        }

        internal int Add(int input1, int input2)
        {
            var result = 0;
            if (input1 == input2)
                result = 3 * (input1 + input2);
            else
                result = input1 + input2;

            return result;

        }
    }
}
