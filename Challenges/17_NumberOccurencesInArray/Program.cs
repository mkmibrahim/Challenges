//Write a program to take input integer array and a single integer number and findout the occurrence of this number in the array.

//Example :
//1.If user gives input array 12 15 15 16 14 45 23 15 and a integer 15 then the output will be :
//Occurrence of 15 :3

//2.If user gives input array 45 45 15 18 24 45 23 45 and a integer 45 then the output will be :
//Occurrence of 45 :4
using System;

namespace _17_NumberOccurencesInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter an array:");
            //var arrayString = Console.ReadLine();

            //Console.WriteLine("Enter an integer");
            //var number = int.Parse(Console.ReadLine() ?? string.Empty);

            //var result = OccurencesCounter.Get(arrayString, number);
            //Console.WriteLine("Occurence of "+ number + " : "+ result);
            //Console.ReadLine();
            int[] arr = new int[8];
            int countOccurrence = 0;
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Enter Number [" + i + "]:");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter a number which exist in the array:");
            int number = int.Parse(Console.ReadLine());
            //write your logic here

            countOccurrence = OccurencesCounter.Get(arr, number);

            //end 
            Console.WriteLine("Occurrence of " + number + " :");
            Console.WriteLine(countOccurrence);

        }
    }

    public class OccurencesCounter
    {
        public static int Get(string arrayString, int number)
        {
            var result = 0;
            int[] arrayInt = ConvertArrayToInts(arrayString);
            result = GetOccurence(arrayInt, number);
            return result;
        }

        public static int Get(int[] arrayInt, int number)
        {
            int result = GetOccurence(arrayInt, number);
            return result;
        }

        private static int[] ConvertArrayToInts(string arrayString)
        {
            var arraySplitted = arrayString.Split(' ');
            var arrayInt = new int[arraySplitted.Length];
            for (int i = 0; i < arraySplitted.Length; i++)
            {
                arrayInt[i] = int.Parse(arraySplitted[i]);
            }
            return arrayInt;
        }

        private static int GetOccurence(int[] arrayInt, int number)
        {
            int result= 0;
            for (int i = 0; i < arrayInt.Length; i++)
            {
                if (arrayInt[i] == number)
                    result++;
            }
            return result;
        }
    }
}
