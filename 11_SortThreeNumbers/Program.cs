//Write a program which accepts 3 integers and sort them in ascending order.

//    For ex :
//1) if user input 39 26 28 then output will be 26 28 39.
//2) if user input 3934 2426 4628 then output will be 2426 3934 4628.
using System;

namespace _11_SortThreeNumbers
{
    class Program
    {
        static void Main()
        {
            int a, b, c;

            Console.WriteLine("Enter three numbers:");

            a = int.Parse(Console.ReadLine() ?? string.Empty);
            b = int.Parse(Console.ReadLine() ?? string.Empty);
            c = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine(a + " " + b + " " + c + ":");
            /*
                   Your logic goes here
                */
            var result = NumberSorter.Sort(a, b, c);
            Console.WriteLine("Sorted Numbers:");
            Console.WriteLine(result[0] + " " + result[1] + " " + result[2]);

        }
    }

    public class NumberSorter
    {
        public static int[] Sort(int firstNumber, int secondNumber, int thirdNumber)
        {
            int[] result = new int[3];
            result[0] = firstNumber;
            result[1] = secondNumber;
            result[2] = thirdNumber;
            Array.Sort(result);
            return result;

        }
    }
}
