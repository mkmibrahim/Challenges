//Write a C# Sharp program that takes four numbers as input to calculate and print the average. Go to the editor
//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the third number: 20
//Enter the four number: 30

//Expected Output:
//The average of 10 , 15 , 20 , 30 is: 18

using System;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("31_TrimSpace.Tests")]

namespace _31_TrimSpace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var helper = ProgramHelper.Make();
            
            Console.Write("Enter the First number:");
            var firstNumber = int.Parse(Console.ReadLine());
            helper.SetNumber(0, firstNumber);

            Console.Write("Enter the Second number:");
            var secondNumber = int.Parse(Console.ReadLine());
            helper.SetNumber(1, secondNumber);

            Console.Write("Enter the Third number:");
            var thirdNumber = int.Parse(Console.ReadLine());
            helper.SetNumber(2, thirdNumber);

            Console.Write("Enter the Fourth number:");
            var fourthNumber = int.Parse(Console.ReadLine());
            helper.SetNumber(3, fourthNumber);

            Console.WriteLine("The average of " + firstNumber + " , " + secondNumber + " , "
                            + thirdNumber + " , " + fourthNumber + " is: "+ helper.GetAverage());
        }
    }

    internal class ProgramHelper
    {
        private int[] numbers;
        private ProgramHelper()
        {
            numbers = new int[4];
        }

        internal static ProgramHelper Make()
        {
            return new ProgramHelper();
        }

        internal int GetAverage()
        {
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++)
                sum += numbers[i];
            var result = sum / numbers.Length;
            return result;
        }

        internal void SetNumber(int sequence, int number)
        {
            if (sequence >= 0 && sequence < 4)
                numbers[sequence] = number;
        }
    }
}
