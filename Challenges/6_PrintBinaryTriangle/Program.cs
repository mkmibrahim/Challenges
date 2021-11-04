//Write a program which takes input as integer and display the binary triangle on the basis of input integer.

//    Example:
//1.If user gives input 5 then the binary triangle should be like this :
//1
//01
//010
//1010
//10101

//2.If user gives input 6 then the binary triangle should be like this :
//1
//01
//010
//1010
//10101
//010101
using System;

namespace _6_PrintBinaryTriangle
{
    class Program
    {
        static void Main()
        {
            int size;
            Console.WriteLine("Enter the size:");
            size = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Triangle Size " + size + " is:");
            for (int i = 0; i < size +1; i++)
            {
                Console.WriteLine(BinaryConverter.BinaryString(i));
            }
        }
    }

    public class BinaryConverter
    {
        public static string BinaryString(int number)
        {
            var startWith0 = GetStartingDigit(number);

            var result = BuildBinaryString(number, startWith0);
            return result;
        }

        private static string BuildBinaryString(int number, bool startWith0)
        {
            string result ="";
            string nextDigit = startWith0 ? "0" : "1";
            for (int i = 0; i < number; i++)
            {
                result += nextDigit;
                nextDigit = nextDigit == "0" ? "1" : "0";
            }
            return result;
        }

        private static bool GetStartingDigit(int number)
        {
            bool startWith0 = false;
            for (int i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                    startWith0 = !startWith0;
            }
            return startWith0;
        }
    }
}
