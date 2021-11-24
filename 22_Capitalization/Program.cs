//Write a program which takes input string and capitalizes the first character of each word in a String, and does not affect the others.

//Examples:
//1.If the string is "jon skeet" then the program should print "Jon Skeet".

//2.If the string is "old mcdonald" then the program should print "Old Mcdonald".

//3.If the string is "miles o'Brien" then the program should print "Miles O'Brien".
using System;

namespace _22_Capitalization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name:");
            string str = Console.ReadLine();
            Console.WriteLine(Capitalize.CapitalizeString(str));
        }
    }

    public class Capitalize
    {
        static public string CapitalizeString(string inputString)
        {
            var result = CapitalFirstLetterOfWordsArray(inputString.Split(' '));
            return result;
        }

        private static string CapitalFirstLetterOfWordsArray(string[] stringArray)
        {
            var result = "";
            for (int i = 0; i < stringArray.Length; i++)
            {
                result += CapitalizeFirstLetter(stringArray[i]) + ' ';
            }
            return result.Trim();
        }

        private static string CapitalizeFirstLetter(string str)
        {
            var result = "";
            if (str == null)
                return null;
            else if (str.Length == 1)
                result = str.ToUpper();
            else if (str.Length > 1)
                result = char.ToUpper(str[0]) + str.Substring(1);
            return result;
        }

    }
}
