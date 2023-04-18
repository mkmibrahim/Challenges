//Complete the following program which will take the number as input and prints
//The sequence for example if input number is 3 then program should print
//12321 if number is 4 then output should be 1234321

//Example:
//Example 1:
//Enter the number 3
//Sequence is:
//12321
//Example2:
//Enter the number;
//4
//Sequence is:
//1234321
using System;

namespace _26_NumberSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number");
            //int number = int.Parse(Console.ReadLine());

            //var result = NumberSequenceHelper.GetSequence(number);
            //Console.WriteLine("sequence is");
            //Console.WriteLine(result);
            Console.WriteLine("Enter the number:");
            int number = int.Parse(Console.ReadLine());

            number = NumberSequenceHelper.GetSequence(number);

            Console.WriteLine("Mirror image of the number is:");
            Console.WriteLine(number);
        }
    }

    public class NumberSequenceHelper
    {
        static public int GetSequence(int number)
        { 
            int result = 0;
            string resultString = "";
            for(int i = 1; i < number+1; i++)
            {
                resultString += i.ToString();
            }
            for (int i = number-1; i > 0; i--)
            {
                resultString += i.ToString();
            }
            result = int.Parse(resultString);
            return result;
        }
    }
}
