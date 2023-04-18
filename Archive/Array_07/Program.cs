using System;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("Array_07.Tests")]


namespace Array_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EXCHANGE POKEMON:");
            var arrayInstance = ArrayClass.Make();
            var continueProgram = true;
            while (continueProgram)
            {
                arrayInstance.ShowContents();
                var choice = arrayInstance.AskChoice();
                continueProgram = arrayInstance.ProcessChoice(choice);
                
            }

        }
    }
    internal class ArrayClass
    {
        string[] arrayElements;

        internal string[] ArrayElements
        {
            get { return arrayElements; }
        }

        internal static ArrayClass Make()
        {
            var array = new ArrayClass();
            return array;
        }

        internal void ShowContents()
        {
            for(int i = 0; i < arrayElements.Length; i++)
            {
                Console.WriteLine(i+":"+arrayElements[i]);
            }
        }

        internal int AskChoice()
        {
            var result = 0;
            Console.Write("Choose a Pokemon to exchange with " + arrayElements[0]+":");
            var input = Console.ReadLine();
            result = int.Parse(input);
            return result;
        }

        internal bool ProcessChoice(int choice)
        {
            if (choice == 0)
                return false;
            else
            {
                exchange(choice);
                return true;
            }
        }

        private void exchange(int choice)
        {
            var temp = arrayElements[0];
            arrayElements[0] = arrayElements[choice];
            arrayElements[choice] = temp;
        }

        private ArrayClass()
        {
            arrayElements = new string[6] {"PIKACHU",
            "CHARMELEON",
            "GEODUDE",
            "GYARADOS",
            "BUTTERFREE",
            "MANKEY"};
        }

        
    }
}
