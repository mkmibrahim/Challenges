//An ISBN number is legal if it consists of 10 digits and

//d_1 + 2*d_2 + 3*d_3 + ... + 10*d_10 is a multiple of 11.

//The ISBN number 0-201-31452-5 is valid.

//1*5 + 2*2 + 3*5 + 4*4 + 5*1 + 6*3 + 7*1 + 8*0 + 9*2 + 10*0 = 88

//and 88 is a multiple of 11.

//Write a program which validates whether an ISBN number.

//For Ex:

//1) if user inputs 8535902775 then it should print "Valid"

//2) if user inputs 1843369283 then it should print "Not Valid"
using System;

namespace _29_ISBNValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter ISBN Number:");
            var ISBNString = Console.ReadLine();
            Console.WriteLine(ISBNString + ":");
            /*
                   Your logic goes here
                */
            var result = ISBNHelper.Validate(ISBNString);
            
            Console.WriteLine("The ISBN number is:");
            Console.WriteLine(result);

            //Console.WriteLine("Enter ISBN:");
            //if (!Int64.TryParse(Console.ReadLine(), out var ISBNNumber ))
            //    Console.WriteLine("Not Valid");
            //var result = ISBNHelper.Validate(ISBNNumber);
            //Console.WriteLine(result);
        }
    }

    public class ISBNHelper
    {
        public static string Validate(string ISBNString)
        {
            var result = "Not Valid";
            
            if (ISBNString.Length != 10)
                return result;
            int sumDigits = 0;
            for(int i = 0; i < ISBNString.Length; i++)
            {
                sumDigits += (i+1) * int.Parse(ISBNString[i].ToString());
            }
            if (sumDigits % 11 == 0)
                result = "Valid";
            return result;
        }
    }
}
