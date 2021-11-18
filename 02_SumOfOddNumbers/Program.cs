//Write a program which calculates the sum of all odd numbers upto a particular limit.
//    The limit will be an input to the program.

//    Examples:

//1.If the limit is 10 then the program should print the sum of odd numbers from 1 to 10
//i.e. 1 + 3 + 5 + 7 + 9 = 25
//So the program should print 25.

//2. If the limit is 15 then the program should print sum of odd numbers from 1 to 15
//i.e. 1 + 3 + 5 + 7 + 9 + 11 + 13 + 15 = 64
//So the program should print 64

using System;
using System.Globalization;

namespace _02_SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class SumOfOddNumbers
    {
        public static int Calculate(int Limit)
        {
            int result = new int { };
            for (var i = 0; i <= Limit; i++)
            {
                if (i % 2 != 0)
                    result += i;
            }
            return result;
        }
    }
}
