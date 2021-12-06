//Write a program which accepts an integer as decimal number and prints its octal form.
//An Octal number can be expressed as combination of 0 to 7 no.

//For Ex :

//1) If user input 81.
//then it should print 121

//2) If user input 10
//then it should print 12.
using System;

namespace _30_DecimalToOctal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number:");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine(num + ":");

            var result = OctalHelper.Convert(num);

            Console.WriteLine("Octal number:");
            Console.WriteLine(result);
        }
    }

    public class OctalHelper
    {
        public static string Convert(int number)
        {
            string result = "";
            result = System.Convert.ToString(number, 8);
            return result;
        }
    }
}
