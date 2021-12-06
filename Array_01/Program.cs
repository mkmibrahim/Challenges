//Create an array that can hold ten integers,
//and fill each slot with a different random value
//from 1-50. Display those values on the screen, and
//then prompt the user for an integer. Search through
//the array, and if the item is present, say so.
//If the value was not found, display nothing.
//If the item is in the array multiple times,
//print the message more than once.
using System;

namespace Array_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 7, 9, 14 };
            Console.Write("Array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine("");
            Console.Write("Value to find:");
            int tofind = int.Parse(Console.ReadLine());
            var array = new ArrayInstance(arr);
            var result = array.CheckOccurences(tofind);
            for(int i = 0; i< result; i++)
            {
                Console.WriteLine(tofind + " is in the array");
            }
            
        }
    }

    public class ArrayInstance
    {
        private int[] arrayContents;

        public int[] ArrayContents { 
            get => arrayContents; 
             }

        public ArrayInstance(int Size, int higherLimit)
        {
            arrayContents = new int[Size];
            var rnd = new Random();
            for (int i = 0; i < Size; i++)
                arrayContents[i] = rnd.Next(higherLimit);
        }

        public ArrayInstance(int[] fixedArrayContents)
        {
            this.arrayContents = fixedArrayContents;
        }

        public int CheckOccurences(int number)
        {
            var result = 0;
            foreach(var item in arrayContents)
            {
                if (item == number)
                    result++;
            }
            return result;
        }

      
    }
}
