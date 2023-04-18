//Create an array that can hold ten integers,
//and fill each slot with a different random value from 1-50.
//Display those values on the screen, and then prompt the user
//for an integer. Search through the array, and count
//the number of times the item is found.

//Array: 1 2 3 4 5 6 7 7 9 14
//Value to find:12
//12 was found 0 times

//Array: 1 2 3 4 5 6 7 7 9 14
//Value to find:7
//7 was found 2 times
using System;
using System.Runtime.CompilerServices;
[assembly:InternalsVisibleTo("Array_05.Tests")]

namespace Array_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arrayInstance = ArrayHelper.Make();
            arrayInstance.ShowArray();
            var value = arrayInstance.GetValueToFind();
            arrayInstance.Find(value);


        }
    }

    public class ArrayHelper
    {
        int[] arrayElements = new int[10];
        private int[] testArrayElements;

        private ArrayHelper()
        {
        }

        internal void ShowArray()
        {
            Console.Write("Array:");
            for(int i = 0; i < 10; i++)
            {
                Console.Write(" "+arrayElements[i]);
            }
            Console.WriteLine();
        }

        private ArrayHelper(int[] testArrayElements)
        {
            arrayElements = testArrayElements;
        }

        internal static ArrayHelper Make()
        {
            var newInstance = new ArrayHelper();
            newInstance.fillArray(); 
            return newInstance; 
        }

        private void fillArray()
        {
            var random = new Random();
            for (int i = 0; i < arrayElements.Length; i++)
                arrayElements[i] = random.Next(0, 50);
        }


        internal static ArrayHelper Make(int[] testArrayElements)
        {
            var newInstance = new ArrayHelper(testArrayElements);
            return newInstance;
        }

        internal int GetElement(int index)
        {
            return arrayElements[index];
        }

        internal int GetValueToFind()
        {
            Console.Write("Value to find:");
            var input = Console.ReadLine();
            var intInput = int.Parse(input);
            return intInput;
        }

        internal void Find(int numberToFind)
        {
            var timesFound = 0;
            for (int i = 0; i < arrayElements.Length; i++)
                timesFound = numberToFind == arrayElements[i] ? timesFound + 1 : timesFound;
            Console.WriteLine(numberToFind + " was found " + timesFound + " times");
        }
        
    }
}
