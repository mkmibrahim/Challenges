//Write a program which accepts two integers as a minimum and maximum limit and calculates total of how many 1s were their within the limit.

//For ex:

//1) if user input 1 11 then it should print 4.

//2) if user input 11 111 then it should print 34using System;
using System;

namespace _23_CountOnes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter first numer:");
            //int firstNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter second numer:");
            //int secondNumber = int.Parse(Console.ReadLine());

            //var result = Counter.CountOnes(firstNumber, secondNumber);
            //Console.WriteLine(result);

            int max = 0;
            Console.WriteLine("Enter the Maximum value:");
            max = int.Parse(Console.ReadLine());
            Console.WriteLine(max + ":");
            int count = 0;

            //for (int i = 1; i <= (int)max; i++)
            //{
            //    /*
            //           Your logic goes here
            //        */
            //}
            count = Counter.CountOnes(1, max);
            Console.WriteLine("Total sum of count of 1s:");
            Console.WriteLine(count);
        }
    }

    public class Counter
    {
        public static int CountOnes(int firstNumber, int secondNumber)
        {
            int result = 0;
            for(int i = firstNumber; i <= secondNumber; i++)
            {
                var iString = i.ToString();
                for (int j = 0; j < iString.Length; j++)
                {
                    if (iString[j] == '1')
                        result++;
                }
            }

            return result;
        }
    }
}