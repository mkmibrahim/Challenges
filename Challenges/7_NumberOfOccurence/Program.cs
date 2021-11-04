//Complete the following program which takes the input number then taken the
//number to be searched then find outs the number of occurrence of the given input number from that number. to understand bettor scenario is given below:
//Example1:
//Enter the number:
//43423
//Enter number to search:
//4
//Number of occurence of given number is:
//2

//Example2:
//Enter the number:
//43423
//Enter number to search:
//8
//Number of occurence of given number is:
//0
using System;

namespace _7_NumberOfOccurence
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number:");
            int number = int.Parse(Console.ReadLine() ?? String.Empty);

            Console.WriteLine("Enter the number to search:");
            int searchnumber = int.Parse(Console.ReadLine()??String.Empty);

            var occurences = OccurencesFinder.GetNumberOfOccurences(number, searchnumber);

            Console.WriteLine("Number of occurence of given number is:");

            Console.WriteLine(occurences);

        }
    }

    public class OccurencesFinder
    {
        static public int GetNumberOfOccurences(int number, int searchNumber)
        {
            int result = 0;
            string numberString = number.ToString();
            for (int i = 0; i < numberString.Length; i++)
            {
                if (int.Parse(numberString[i].ToString()) == searchNumber)
                    result += 1;
            }
            return result;
        }
    }
}
