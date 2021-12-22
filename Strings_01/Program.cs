//Write a program that receives a string, the program then counts
//the number of words ending in 'y' or 'z'.

using System;


namespace Strings_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string");
            var inputString = Console.ReadLine();
            var result = StringHelper.CountEZ(inputString);
            Console.Write("Total words ending in y or z:"+ result);
        }
    }

    public class StringHelper
    {
        
        public static int CountEZ(string input)
        {
            var result = 0;
            var stringArray = input.Split(' ');
            for(int i = 0; i < stringArray.Length; i++)
            {
                if(stringArray[i][stringArray[i].Length - 1] == 'y' ||
                    stringArray[i][stringArray[i].Length - 1] == 'z')
                    result++;
            }

            return result;
        }
    }
}
