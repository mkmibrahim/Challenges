//Complete the following program which takes input as a number and converts that number in to
//    Indian rupees format as given below in the examples.
//    to understand better the scenario is given below (your program scenario shueld be exactly similar
//like given below):
//Example1:
//Enter the amount:
//3432
//Number in indian rupees format is:
//3Thousand 432

//Example2:
//Enter the amount:
//12533
//Number in indian rupees format is:
//12Thousand 533
using System;

namespace _14_IndianRupeesFormat
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the amount:");
            var amount = Console.ReadLine();

            var returnedString = RupeeFormatter.Convert(amount);
            Console.WriteLine("Number in indian rupees format is:");
            Console.WriteLine(returnedString);
        }
    }

    public class RupeeFormatter
    {
        public static string Convert(string amount)
        {
            string result = amount;
            result = result.Insert(result.Length - 3, "Thousand ");
            return result;
        }
    }
}
