//Write a program which accepts an integer and print its factors but the factors must be prime.

//For ex :

//1) if user inputs integer 369.
//it should print 3 3 41 as prime factors.

//2) if user inputs integer 287.
//it should print 7 41 as prime factors.
using System;
using System.Collections.Generic;

namespace _16_PrimeFactors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            var number = int.Parse(Console.ReadLine() ?? string.Empty);

            var result = PerfectNumber.Generate(number);

            Console.WriteLine(result);
        }
    }

    public class PerfectNumber
    {
        public static string Generate(int number)
        {
            var primes = new List<int>();

            for (int div = 2; div <= number; div++)
            {
                while (number % div == 0)
                {
                    primes.Add(div);
                    number /= div;
                }
            }
            string result = string.Join(" ", primes);
            return result;



            //int[] primesTempArray = new int[number];
            //var nrOfPrimes = 0;
            //for (int div = 2; div <= number; div++)
            //{
            //    while (number % div == 0)
            //    {
            //        primesTempArray[nrOfPrimes++] = div;
            //        number /= div;
            //    }
            //}

            //string[] primesArray = new string[nrOfPrimes];
            ////Array.Copy(primesTempArray, primesArray, nrOfPrimes);
            //for (int i = 0; i < nrOfPrimes; i++)
            //{
            //    primesArray[i] = primesTempArray[i].ToString();
            //}

            //string result = string.Join(" ", primesArray);
            //return result;
        }
    }
}
