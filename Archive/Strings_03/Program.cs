//Write a program which takes a string as input from user.
//Check the string for the occurrence of a '*' and remove it
//along with it's immediate left and right characters respectively.

using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

[assembly: InternalsVisibleTo("Strings_03.Tests")]

namespace Strings_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string:");
            var inputString = Console.ReadLine();
            var result = inputString.StarOut();
            Console.WriteLine(result);
        }
    }

    public static class StringExtension
    {
        public static string StarOut(this string str)
        {
            var newStarsFound = true;
            while (newStarsFound)
            {
                var StarFoundWithinLoop = false;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == '*')
                    {
                        if (str.Length <= i + 1)
                            str = str.Remove(i - 1, 2);
                        else
                        {
                            int numberConsecutiveStars = GetConsecutiveStars(str, i);
                            str = str.Remove(i - 1, numberConsecutiveStars + 2);
                        }
                        StarFoundWithinLoop = true;
                        break;
                    }
                }
                if (!StarFoundWithinLoop)
                    newStarsFound = false;
            }
            return str;
        }

        private static int GetConsecutiveStars(string str, int i)
        {
            var result = 0;
            var nextCharacterIsStar = true;
            while (nextCharacterIsStar)
            {
                for(int j = i; j < str.Length; j++)
                {
                    if (str[j] == '*')
                        result++;
                    else
                    {
                        nextCharacterIsStar = false;
                        break;
                    }
                }
            }
            return result;
        }
    }
}

