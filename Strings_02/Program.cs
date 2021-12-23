using System;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("Strings_02.Tests")]


namespace Strings_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string:");
            var inputString = Console.ReadLine();
            var result = StringHelper.MaxBlock(inputString);
            Console.WriteLine("Largest block: "+ result);
        }
    }

    internal class StringHelper
    {
        internal static int MaxBlock(string inputString)
        {
            var result = 0;
            var currentblock = 1;
            for(int i = 1; i < inputString.Length; i++)
            {
                if (SameAsPreviousCharacter(inputString, i))
                {
                    currentblock++;
                }
                else
                {
                    currentblock = 1;
                }
                result = currentblock > result ? currentblock : result;
            }
            return result;
        }

        private static bool SameAsPreviousCharacter(string inputString, int i)
        {
            return inputString[i] == inputString[i - 1];
        }
    }
}
