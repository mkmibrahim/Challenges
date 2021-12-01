//Write a program which takes input as string and also takes input one character and find out the occurrence of this character in string.

//Example:
//1.If the string is 'This is Programr.com' and character is 'r' then the output should be in this formate:
//'This is Programr.com' contains 3 'r's

//2.If the string is 'This is count occurrence program' and character is 'c' then the output should be in this formate:
//'This is count occurrence program' contains 4 'c's
using System;

namespace _27_CountOccurrenceOfCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string textString = Console.ReadLine();

            Console.WriteLine("Enter the character to search:");
            char character = Console.ReadKey().KeyChar;

            var result = OccurenceHelper.Count(textString, character);

            Console.WriteLine("");
            Console.WriteLine(result);

            //string m;
            //char c;
            //int a_count = 0;
            //Console.WriteLine("Enter the string :");
            //m = Console.ReadLine();

            //Console.WriteLine("Enter the character :");
            //c = Console.ReadKey().KeyChar;


            //a_count = OccurenceHelper.Count(m,c);


            //Console.WriteLine("");
            //Console.WriteLine(a_count);
        }
    }

    public class OccurenceHelper
    {
        static public int Count(string textString, char character)
        {
            var result = 0;
            for(int i = 0; i < textString.Length; i++)
            {
                if (character == textString[i])
                    result++;
            }
            return result;
        }
    }
}
