//An abundant number is a number for which the sum of its proper divisors is greater than that number.
//    the sum of the proper divisors of 12 would be 1 + 2 + 3 + 4 + 6 = 18,
//which means that 12 is an abundant number.

//    Write a program which accepts input integer as limit upto which it will print Abundant numbers.
//    For Ex:

//1) if user inputs 20 then it should print 12,18,20.
//2) if user inputs 40 then it should print 12,18,20,24,30,36,40.

//    Count Total no of Ones

//Write a program which accepts two integers as a minimum and maximum limit and calculates total of how many 1s were their within the limit.

//    For ex:

//1) if user input 1 11 then it should print 4.

//2) if user input 11 111 then it should print 34.

//-----
//Count Total no of Ones

//    Write a program which accepts two integers as a minimum and maximum limit and calculates total of how many 1s were their within the limit.

//    For ex:

//1) if user input 1 11 then it should print 4.

//2) if user input 11 111 then it should print 34.
using System;

namespace _12_AbundantNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter limit:");
            var limit = int.Parse(Console.ReadLine() ?? string.Empty);
            var result = AbundantNumbers.GetUpToLimit(limit);
            Console.WriteLine("Abundant numbers are:");
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

            Console.WriteLine("Enter limits");
            var limitsString = Console.ReadLine();
            var resultOnes = OnesCounter.Get(limitsString);
            Console.WriteLine("Total no of Ones is "+ resultOnes);

        }
    }

    public class AbundantNumbers
    {
        public static int[] GetUpToLimit(int limit)
        {
            // iterate through numbers
            // decide if number is Abundant
            // add to list
            
            //Array is used because Lists are not allowed
            var tempResult = new int[10];
            int nrOfAbundantNumbers = 0;
            for (int i = 0; i < limit+1; i++)
            {
                if (IsNumberAbundant(i))
                {
                    tempResult[nrOfAbundantNumbers] = i;
                    nrOfAbundantNumbers++;
                }
            }

            int[] result = new int[nrOfAbundantNumbers];
            Array.Copy(tempResult, result, nrOfAbundantNumbers);

            return result;
        }

        private static bool IsNumberAbundant(int number)
        {
            bool result;
            var properDevisors = GetProperDevisors(number);
            result = IsSumDivosorsHigherThanNumber(number, properDevisors);
            return result;
        }

        private static int[] GetProperDevisors(int number)
        {
            int[] tempProperDevisors = new int[10];
            int nrOfProperDevisors = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    tempProperDevisors[nrOfProperDevisors]= i;
                    nrOfProperDevisors++;
                }
            }

            int[] properDevisors = new int[nrOfProperDevisors];
            Array.Copy(tempProperDevisors, properDevisors, nrOfProperDevisors);
            return tempProperDevisors;
        }

        private static bool IsSumDivosorsHigherThanNumber(int number, int[] properDevisors)
        {
            bool result = false;
            int properDevisorsSum = 0;
            for (int i = 0; i < properDevisors.Length; i++)
            {
                properDevisorsSum += properDevisors[i];
            }

            if (properDevisorsSum > number)
                result = true;
            return result;
        }

    }

    public class OnesCounter
    {
        public static int Get(string limitsString)
        {
            var result = 0;
            var limitStringSplit = limitsString.Split(" ");
            var lowerLimit = int.Parse(limitStringSplit[0]);
            var higherLimit = int.Parse(limitStringSplit[1]);

            for (int i = lowerLimit; i < higherLimit+1; i++)
            {
                var containsOnes = i.ToString().Contains(1.ToString());
                if (containsOnes)
                {
                    var iString = i.ToString();
                    for (int j = 0; j <iString.Length; j++)
                    {
                        if (iString[j] == '1')
                            result += 1;
                    }
                }
            }

            return result;
        }
    }
}
