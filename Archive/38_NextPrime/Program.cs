//92.Write a C# Sharp program to find the next prime number of a given number. If the given number is a prime number, return the number. Go to the editor
//Sample Output:
//Original number: 120
//Next prime number/Current prime number: 127
//Original number: 321
//Next prime number/Current prime number: 331
//Original number: 43
//Next prime number/Current prime number: 43
//Original number: 4433
//Next prime number/Current prime number: 4441

using System;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("38_NextPrime.Tests")]

namespace _38_NextPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, let's determine the next prime!");
            Console.Write("Please provide a number: ");
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine("Next prime number: " + number.getNextPrime());

        }

    }

    internal static class intExtension
    {
        internal static int getNextPrime(this int number)
        {
            bool resultFound = false;
            var result = number;
            while (!resultFound)
            {
                if (isPrime(number))
                {
                    resultFound = true;
                    result = number;
                }
                else
                    number++;
            }
            return result;
        }

        private static bool isPrime(int number)
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
