// 7.Write a C# Sharp program to exchange the first and last characters
// in a given string and return the new string.
//Sample Input:
//"abcd"
//"a"
//"xy"
//Expected Output:

//dbca
//a
//yx

using System;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("39_Switchcharacters.Tests")]


namespace _39_Switchcharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }



    internal static class stringExtension
    {
        internal static string getSwitch(this string str)
        {
            if (str.Length == 1)
                return str;
            var temp = str[str.Length - 1];
            str = str.Remove(str.Length - 1, 1) + str[0];
            str = temp + str.Remove(0, 1);
            return str;
        }
    }
}
