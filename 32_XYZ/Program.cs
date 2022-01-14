//Write a C# Sharp program to that takes three numbers(x,y,z)
//as input and print the output of (x+y).z and x.y + y.z.
//Enter first number - 5
//Enter second number - 6
//Enter third number - 7

//Expected Output:
//Result of specified numbers 5, 6 and 7, (x + y).z is 77
//and x.y + y.z is 72

using System;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("32_XYZ.Tests")]

namespace _32_XYZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            var firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            var secondNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            var thirdNumber = int.Parse(Console.ReadLine());

            var helper = ProgramHelper.Make();
        }
    }

    internal class ProgramHelper
    {
        private int[] numbersArray;
        private ProgramHelper()
        {
            numbersArray = new int[3];
        }

        internal static ProgramHelper Make()
        {
            return new ProgramHelper();
        }

        internal int GetFirstResult()
        {
            return (numbersArray[0] + numbersArray[1]) * numbersArray[2];
        }

        internal object GetSecondResult()
        {
            return numbersArray[0] * numbersArray[1] + numbersArray[1] * numbersArray[2];
        }

        internal void Set(int sequence, int number)
        {
            if(sequence > -1 && sequence < 3)
                numbersArray[sequence] = number;
        }
    }
}
