using System;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("Array_06.Tests")]

namespace Array_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arrayInstance = ArrayClass.Make();
            arrayInstance.ShowContents();
        }
    }

    internal class ArrayClass
    {
        private int[] arrayContents = new int[0];

        internal static ArrayClass Make()
        {
            var arrayInstance = new ArrayClass();
            return arrayInstance;
        }

        private ArrayClass()
        {
            fillArrayElements();
        }

        private void fillArrayElements()
        {
            arrayContents = new int[10];
            for (int i = 0; i < arrayContents.Length; i++)
                arrayContents[i] = -113;
        }

        internal void ShowContents()
        {
            for (int i = 0; i < arrayContents.Length; i++)
                Console.WriteLine("Slot "+ i + " of array has value "+ arrayContents[i]);
        }
    }
}
