using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("Array_03.Tests")]

namespace Array_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arrayInstance = new ArrayClass();
            Console.WriteLine("Array:");
            for(int i = 0;i< 10; i++)
            {
                var input = int.Parse(Console.ReadLine());
                arrayInstance.SetValue(i, input);
            }
            var largestValue = arrayInstance.GetLargestValue();
            Console.WriteLine("The largest value is " + largestValue);
        }
    }

    public class ArrayClass
    {
        private int[] arrayValues = new int[10];

        internal void SetValue(int order, int value)
        {
            arrayValues[order] = value;
        }

        internal int GetValue(int order)
        {
            return arrayValues[order];
        }

        internal object GetLargestValue()
        {
            var result = 0;
            for(int i = 0; i < 10; i++)
            {
                result = arrayValues[i] > result ? arrayValues[i] : result;
            }
            return result;
        }
    }
}
