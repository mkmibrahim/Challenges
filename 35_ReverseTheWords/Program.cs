// Write a C# program to reverse the words of a sentence.
// Original String: Display the pattern like pyramid using the alphabet.
// Reverse String: alphabet.the using pyramid like pattern the Display


// using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("35_ReverseTheWords.Tests")]

namespace _35_ReverseTheWords
{
    //class Program
    //{
    //    internal class A
    //    {
    //        public string Foo { get; set; } = "Foo";
    //    }

    //    internal class B : A
    //    {
    //        public string Bar { get; set; } = "Bar";
    //    }

    //    public static void Main(string[] args)
    //    {
    //        var a = new B() as A;
    //        Console.WriteLine(JsonConvert.SerializeObject(a));
    //    }
    //}

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide a sentence: ");
            var str = Console.ReadLine();
            var result = ProgramHelper.Reverse(str);
            Console.WriteLine(result);
        }
    }

    internal class ProgramHelper
    {
         internal static string Reverse(string startStr)
        {
            var result = "";
            var strSplit = startStr.Split(' ');
            for (int i = strSplit.Length - 1; i > -1 ; i--)
            {
                result += strSplit[i];
                result += result[result.Length - 1] != '.' ? " " : "";
            }
            return result.Trim();
        }
    }
}
