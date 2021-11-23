//complete the following program:
//two string arrays are given one is for names and other is for equivalent surnames of the celebrities. program will just take the name as a input then find out the corresponding last name and the then print the whole name.
//Scenario:
//Enter the name:
//harry
//Full name of the celebraty is:
//harry potter
using System;

namespace _21_NameSearch
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");
        //}
        public static string[] names = { "harry", "michael", "will", "tom", "jackie" };
        public static string[] surnames = { "potter", "jackson", "smith", "cruise", "chan" };
        static void Main(string[] args)
        {


            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();

            /*write down your logic here
           */
            name = NameSearcher.GetFullName(name, names, surnames);


            Console.WriteLine("full name of the celebrity is:");
            Console.WriteLine(name);
        }

    }

    public class NameSearcher
    {
        public static string GetFullName(string name, string[] firstNames, string[] surNames)
        {
            var result = "";
            var namePosition = GetNamePosition(name, firstNames);
            result = name + " " + surNames[namePosition];
            return result;
        }

        private static int GetNamePosition(string name, string[] firstNames)
        {
            var result = Array.IndexOf(firstNames, name);
            return result;
        }
    }
}
