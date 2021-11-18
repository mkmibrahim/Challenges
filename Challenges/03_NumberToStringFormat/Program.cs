using System;

namespace _03_NumberToStringFormat
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            //string[] ones = { "one", "two", "three", "four", "five", "six", " seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "forteen", "fifteen", "sixteen", "seventeen", "eighteen", "ninteen" };
            //string[] tens = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninty" };

            Console.WriteLine("Enter the Number:");
            //int number = Console.Read();
            int number = Convert.ToInt32(Console.ReadLine());
            string result;


            Console.WriteLine("Entered number is:");

            /*write down your logic here
           */
            result = NumberToStringFormatter.Format(number);
            Console.WriteLine(result);


        }
    }

    public class NumberToStringFormatter
    {


        public static string Format(int number)
        {
            string[] ones = { "one", "two", "three", "four", "five", "six", " seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "forteen", "fifteen", "sixteen", "seventeen", "eighteen", "ninteen" };
            string[] tens = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninty" };

            string result;
            if (number < 20)
                result = ones[number - 1];
            else
            {

                int x = number - 20;
                result = tens[x / 10];
                if (x % 10 > 0 && x % 10 < 10)
                    result += " " + ones[x % 10 - 1];
            }

            return result;
        }
    }
}
