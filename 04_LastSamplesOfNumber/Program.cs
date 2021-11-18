//Write a program which takes two integers N and M and produces last samples of N of the integers from N-1 to N-M.

//for Ex:
//1) if user inputs N = 10 M = 4 output will be 9 8 7 6
//means it produces last 4 samples from 0 to 10.

//2) if user inputs N = 5 M = 2 output will be 4 3
using System;

namespace _04_LastSamplesOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Last Samples!");
            Console.WriteLine("Please enter first input");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second input");
            int sample = Convert.ToInt32(Console.ReadLine());
            var result = LastSamplesOfNumber.Give(num, sample);
            var resultString = string.Join(" ", result);
            Console.WriteLine(resultString);

        }
    }

    public class LastSamplesOfNumber
    {
        public static string[] Give(int num, int sample)
        {
            string[] result = new string[sample];
            for (int i = 0; i < sample; i++)
            {
                result[i] = (num - i - 1).ToString();
            }
            return result;
        }
    }


}
