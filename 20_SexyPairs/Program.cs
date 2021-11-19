//Sexy Pairs are nothing but those pairs which contains prime numbers with difference of 6.

//Consider 5 is a prime no. and adding 6 into 5 makes 11 which is also a prime no.
//So (5,11) is a sexy pair.

//Write a program which calculates the Sexy pairs upto the limit given as input.

//For Ex:

//1) If user input 20 then it should print (5 11) (7 13) (11 17) (13 19) as
//Sexy pairs.

//2) If user input 30 then it should print (5 11) (7 13) (11 17) (13 19)
//(17 23) (23 29).
using System;

namespace _20_SexyPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number:");
            //var limit = int .Parse(Console.ReadLine());
            //Console.WriteLine("Sexy pairs up to " + limit + " are:");
            //Console.WriteLine(Pairs.GetStringSexyPairsToLimit(limit));

            int max = 0;

            Console.WriteLine("Enter Maximum No.:");

            max = int.Parse(Console.ReadLine());
            Console.WriteLine(max + ":");


            /*
                   Your logic goes here
                */
            Console.WriteLine("Sexy Pairs:");
            var result = Pairs.GetSexyPairsToLimit(max);
            for(int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(Pairs.ConvertSinglePairToString(result[i]));
            }

        }
    }

    public class Pairs
    {
        public struct Pair{
            public int firstnumber;
            public int secondnumber;
            }

        static public string GetStringSexyPairsToLimit(int limit)
        {
            var result = "";
            var pairs = GetSexyPairsToLimit(limit);
            for (int i = 0; i < pairs.Length; i++)
            {
                result += ConvertSinglePairToString(pairs[i]) + " ";
            }
            result = result.Trim();
            return result;
        }

        public static string ConvertSinglePairToString(Pair pair)
        {
            var result = "";
            result = "(" + pair.firstnumber + " " + pair.secondnumber + ")";
            return result;
        }

        static public Pair[] GetSexyPairsToLimit(int limit)
        {
            var resultTempArray = new Pair[limit];
            var numberofPairsFound = 0;
            for(int i = 0; i < limit; i++)
            {
                if (IsSexyPairWithinLimit(limit, i))
                {
                    numberofPairsFound = addNewSexyPair(resultTempArray, numberofPairsFound, i);
                }
            }

            var result = new Pair[numberofPairsFound];
            Array.Copy(resultTempArray, result, numberofPairsFound);

            return result;
        }

        private static bool IsSexyPairWithinLimit(int limit, int i)
        {
            return isPrime(i) && (i + 6 < limit) && isPrime(i + 6);
        }

        private static int addNewSexyPair(Pair[] resultTempArray, int numberofPairsFound, int i)
        {
            resultTempArray[numberofPairsFound++] = new Pair
            {
                firstnumber = i,
                secondnumber = i + 6
            };
            return numberofPairsFound;
        }

        private static bool isPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i<=boundary; i+= 2)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
