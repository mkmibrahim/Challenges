// Write a C# program to compute the sum of
// the first 500 prime numbers.

using System;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("34_SumOfPrime.Tests")]

namespace _34_SumOfPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            var higherLimit = int.Parse(Console.ReadLine());
            var helper = PrimeHelper.Make();
            var result = helper.GetSumPrimeNumberToNumber(higherLimit);
            Console.WriteLine("Sum of prime numbers is :" + result);
        }
    }

    internal class PrimeHelper
    {
        private PrimeHelper()
        {

        }

        internal static PrimeHelper Make()
        {
            return new PrimeHelper();
        }

        internal int GetSumPrimeNumberToNumber(int higherLimit)
        {
            var result = 0;
            for (int i = 0; i <= higherLimit; i++)
            {
                if (IsPrime(i))
                    result += i;
            }


            return result;
        }

        private bool IsPrime(int number)
        {
            if (number <= 0) return false;
            if (number == 1) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
