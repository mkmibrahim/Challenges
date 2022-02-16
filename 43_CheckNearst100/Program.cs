//19.Write a C# Sharp program to check which number nearest to the
//value 100 among two given integers. Return 0 if the two numbers
//are equal. 

//Sample Input:
//78, 95
//95, 95
//99, 70
//Expected Output:
//95
//0
//99

using System;
using System.Linq;
using System.Runtime.CompilerServices;
[assembly:InternalsVisibleTo("43_CheckNearst100.Tests")]

namespace _43_CheckNearst100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    internal static class ArrayExtension
    {
        
        internal static int FindNearest100(this int[] inputArray)
        {
            var result = 0;
            int[] differencesTo100 = new int[inputArray.Length];
            for (int i = 0; i < differencesTo100.Length; i++)
            {
                differencesTo100[i] = 100 - inputArray[i];
                differencesTo100[i] = Math.Abs(differencesTo100[i]);
            }
            if (differencesTo100[0] == differencesTo100[1])
                result = 0;
            else
            {
                var resultIndex = Array.IndexOf(differencesTo100, differencesTo100.Min());
                result = inputArray[resultIndex];
            }
            return result;
        }
    }
}
