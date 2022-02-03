using System;
using System.Collections;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("37_NeededInts.Tests")]

namespace _37_NeededInts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = { 1, 3, 4, 7, 9 };
            //var neededResult = array.getNeeded();
            //Console.WriteLine(neededResult);
        }
    }

    internal class helper
    {
        private int[] array;

        private helper()
        {
        }

        private helper(int[] arrayContents)
        {
            array = arrayContents;
        }

        internal static helper Make(int[] array)
        {
            return new helper(array);
        }

        internal int getNeeded()
        {
            var result = 0;
            var min = getMin();
            var max = getMax();
            var difference = max - min;
            result = difference - array.Length;
            return result;
        }

        private int getMax()
        {
            var result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > result)
                    result = array[i];
            }
            return result;
        }

        private int getMin()
        {
            var result = 0;
           for(int i = 0; i < array.Length; i++)
            {
                if(array[i]< result)
                    result = array[i];
            }
           return result;
        }
    }
}
