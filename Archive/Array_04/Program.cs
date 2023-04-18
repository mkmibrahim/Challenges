//Create an array that can hold ten integers, and fill each slot
//with a value from 1-50. Prompt the user for an integer.
//Search through the array, and if the item is present,
//give the slot number where it is located. If the value
//is not in the array, display a single message saying so.
//If the value is present more than once, you may display the message
//as many times as necessary.

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("Array_04.Tests")]

namespace Array_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array:");
            var arrayInstance = ArrayClass.Make();
            arrayInstance.PopulateArrayFromConsole();
            arrayInstance.FindValue();

        }
    }

    public class ArrayClass
    {
        private int[] arrayElements = new int[10];

        public static ArrayClass Make()
        {
            return new ArrayClass();
        }

        public void SetValue(int elementOrder, int value)
        {
            arrayElements[elementOrder] = value;
        }

        public int GetValue(int elementOrder)
        {
            return arrayElements[elementOrder];
        }

        internal void PopulateArrayFromConsole()
        {
            for (var i = 0; i < 10; i++)
            {
                var input = Console.ReadLine();
                var intInput = int.Parse(input);
                arrayElements[i] = intInput;
            }
        }

        internal void FindValue()
        {
            int intInput = GetValueToFind();
            DisplayFindResult(intInput);
        }

        internal int GetValueToFind()
        {
            Console.Write("Value to find: ");
            var input = Console.ReadLine();
            int intInput = int.Parse(input);
            return intInput;
        }

        internal void DisplayFindResult(int intInput)
        {
            var found = false;
            for (int i = 0; i < 10; i++)
            {
                if (arrayElements[i] == intInput)
                {
                    found = true;
                    Console.WriteLine(intInput + " is in slot " + i + ".");
                }
            }
            if (found == false)
                Console.WriteLine(intInput + " is not in the array.");
        }
    }
}
