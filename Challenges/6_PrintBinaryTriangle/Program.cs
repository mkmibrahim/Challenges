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
using System.Reflection;

namespace _6_PrintBinaryTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter the size:");
            size = int.Parse(Console.ReadLine());

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
            string result = "";
            // determine starting digit
            bool startWith0 = false;
            for (int i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                {
                    startWith0 = !startWith0;
                }
            }

            string nextDigit = startWith0 ? "0" : "1";
            for (int i = 0; i < number; i++)
            {
                result = result + nextDigit;
                nextDigit = nextDigit == "0" ? "1" : "0";
            }
            return result;
        }
    }
}
