using System;
using System.Linq;

namespace _9_StatementReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Statement:");
            String st = Console.ReadLine();

            st = StatementReverser.Reverse(st);

            Console.WriteLine("Reverse is:");
            Console.WriteLine(st);
        }
    }

    public class StatementReverser
    {
        public static string Reverse(string statement)
        {
            string result;
            string[] statementSplitted = statement.Split(" ");
            var statementSplittedReversed = statementSplitted.Reverse();
            var enumerable = statementSplittedReversed as string[] ?? statementSplittedReversed.ToArray();
            result = string.Join(" ", enumerable);
            return result;
        }
    }
}