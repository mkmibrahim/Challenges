using System;
using System.Net.Http.Headers;

namespace _12_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class CentralBank
    {
        public static string DisplayDenomination(long @base, long multiplier)
        {
            try
            {
                return checked (@base * multiplier).ToString();
            }
            catch
            {
                return "*** Too Big ***";
            }
            
        }

        public static string DisplayGDP(float @base, float multiplier)
        {
            var result = checked (@base * multiplier);
            if (result == float.PositiveInfinity)
                return "*** Too Big ***";
            else
                return result.ToString();
        }

        public static string DisplayChiefEconomistSalary(decimal salaryBase, decimal multiplier)
        {
            try{
                var result = checked(salaryBase * multiplier);
                return result.ToString();
            }
            catch
            {
                return "*** Much Too Big ***";
            }

        }
    }

}