//complete the program which takes date in number format and then makes its addition of the digits until the last digit remains single and the print the number as lucky number . eg if input is 777
//then 7+7+7 =21 = 2+1 =3 so the answer is 3.
//scenario:
//Enter the date(ddmmyy):
//131083
//Your lucky number is:
//7
using System;

namespace _24_SumOfTheDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the birthdate(ddmmyy):");
            int date = int.Parse(Console.ReadLine());
            var luckynumber = SumCalculator.Calculate(date);
            Console.WriteLine("Your lucky number is:");
            Console.WriteLine(luckynumber);
        }
    }

    public class SumCalculator
    {
        public static int Calculate(int date)
        {
            int result = 0;
            int day = GetNumberWithinNumber(date, 0, 2);
            int month = GetNumberWithinNumber(date, 2, 2);
            int year;
            if (date.ToString().Length == 6)
                year = GetNumberWithinNumber(date, 4, 2);
            else
                year = GetNumberWithinNumber(date, 4, 4);
            result = day + month + year;
            result = ReduceToOneDigit(result);
            return result;
        }

        private static int ReduceToOneDigit(int result)
        {
            while (result > 9)
            {
                var sumDigits = result.ToString().Length;
                var sumTemp = result;
                result = 0;
                for (int i = 0; i < sumDigits; i++)
                {
                    result += int.Parse(sumTemp.ToString()[i].ToString());
                }
            }
            return result;
        }

        private static int GetNumberWithinNumber(int number, int startIndex, int length )
        {
            return int.Parse(number.ToString().Substring(startIndex, length));
        }
    }
}
