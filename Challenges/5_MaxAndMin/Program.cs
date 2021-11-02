//Write a program that takes input array daily temperatures, as floats. and findout the maximum and minimum values.

//    Example:

//1.If array element are: 10.0 11.3 4.5 - 2.0 3.6 - 3.3 0.0 then the output will be :
//Maximum: 11.3
//Minimum: -3.3

//2.If array element are: 5.0 11.0 12.5 - 2.0 3.6 - 4.3 9.0 then the output will be :
//Maximum: 12.5
//Minimum: -4.3

using System;
using System.Linq;

namespace _5_MaxAndMin
{
    class Program
    {
        static void Main(string[] args)
        {
            double MaxTemp = 0.0, MinTemp = 0.0;

            //write your logic here
            double[] doubleArray = new double[] { 10.0, 11.3, 4.5, - 2.0, 3.6, - 3.3, 0.0 };
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Please provide next value in array:");
                doubleArray[i] = Convert.ToDouble(Console.ReadLine());
            }
            MaxTemp = doubleArray.Max();
            MinTemp = doubleArray.Min();
            for (int i = 0; i < doubleArray.Length; i++)
            {
                double thisNum = doubleArray[i];
                if (thisNum > MaxTemp)
                {
                    MaxTemp = thisNum;
                }

                if (thisNum < MinTemp)
                    MinTemp = thisNum;
            }


            //end 

            Console.WriteLine("Maximum:");
            Console.WriteLine(MaxTemp);
            Console.WriteLine("Minimum:");
            Console.WriteLine(MinTemp);
        }
    }
}
