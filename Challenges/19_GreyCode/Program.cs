//Gray Code is a modified binary code in which sequential numbers are represented by expressions that differ only in one bit, to minimize errors.

//Write a program to calculate Gray code for given input number.

//For Ex:

//1) Gray code for 2 is
//00
//01
//11
//10

//2) Gray code for 3 is
//000
//001
//011
//010
//110
//111
//101
//100

using System;

namespace _19_GreyCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Number\tBinary\tGray\tDecoded");
            //for (ulong i = 0; i < 32; i++)
            //{
            //    Console.WriteLine(string.Format("{0}\t{1}\t{2}\t{3}", i, Convert.ToString((long)i, 2), Convert.ToString((long)Gray.grayEncode(i), 2), Gray.grayDecode(Gray.grayEncode(i))));
            //}

            Console.WriteLine("Enter a number:");
            var number = int.Parse(Console.ReadLine());
            var grayArray = Gray.grayToNumber(number);
            for(int i = 0; i < grayArray.Length; i++)
                Console.WriteLine(grayArray[i]);

            Console.ReadLine();
        }
    }
}

public class Gray
{
    public static ulong grayEncode(ulong n)
    {
        return n ^ (n >> 1);
    }

    public static ulong grayDecode(ulong n)
    {
        ulong i = 1 << 8 * 64 - 2; //long is 64-bit
        ulong p, b = p = n & i;

        while ((i >>= 1) > 0)
            b |= p = n & i ^ p >> 1;
        return b;
    }

    public static string[] grayToNumber(int number)
    {
        string[] result = getGrayArray(number);
        FormatArray(number, result);
        return result;
    }

    private static void FormatArray(int number, string[] result)
    {
        for (int j = 0; j < result.Length; j++)
        {
            if (result[j].Length < number)
            {
                var requiredZeros = number - result[j].Length;
                for (int k = 0; k < requiredZeros; k++)
                {
                    result[j] = "0" + result[j];
                }
            }

        }
    }

    private static string[] getGrayArray(int number)
    {
        string[] resultTempStringArray = new string[1000];
        var grayCodedigits = 0;
        ulong i = 0;
        while (grayCodedigits < number + 1)
        {
            resultTempStringArray[i] = Convert.ToString((long)Gray.grayEncode(i), 2);
            i++;
            grayCodedigits = Convert.ToString((long)Gray.grayEncode(i), 2).Length;
        }
        string[] result = new string[i];
        Array.Copy(resultTempStringArray, result, (int)i);
        return result;
    }
}
