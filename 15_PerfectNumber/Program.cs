//Complete the following program to find whether given number is perfect or not
//    Help(Perfect number is a positive number which sum of all positive divisors
//    excluding that number is equal to that number. For example 6 is perfect number
//    since divisor of 6 are 1, 2 and 3. Sum of its divisor is1 + 2+ 3 =6
//    Note: 6 is the smallest perfect number.
//    Next perfect number is 28

//    Example1:
//    Enter a number:
//    6
//    the result is:
//    given number is a perfect number

//    Example2:
//    Enter a number:
//    5
//    the result is:
//    given number is not a perfect number
using System;

namespace _15_PerfectNumber
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number:");
            //int number = Console.Read();
            //number++; number--;
            var number = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("the result is:");
            Console.WriteLine(PerfectNumber.Check(number));
            //Console.WriteLine("given number is a perfect number");
            //Console.WriteLine("given number is not a perfect number");
        }
    }

    public class PerfectNumber
    {
        public static string Check(int number)
        {
            string result;
            if (IsPerfect(number))
                result = "given number is a perfect number";
            else
                result = "given number is not a perfect number";
            return result;
        }

        private static bool IsPerfect(int number)
        {
            var result = false;
            int nrOfDevisors = 0;
            int[] devisorsTempArray = new int[100];
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    devisorsTempArray[nrOfDevisors] = i;
                    nrOfDevisors++;
                }
            }

            int[] devisors = new int[nrOfDevisors];
            Array.Copy(devisorsTempArray, devisors, nrOfDevisors);

            int sumOfDevisors = 0;
            for (int i = 0; i < nrOfDevisors; i++)
            {
                sumOfDevisors += devisors[i];
            }

            if (sumOfDevisors == number)
                result = true;
            return result;
        }
    }
}
