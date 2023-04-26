using System;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

[assembly:InternalsVisibleTo("08_Numbers.Tests")]

namespace _08_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        internal static class AssemblyLine
        {
            public static double SuccessRate(int speed)
            {
                if (speed <= 0)
                    return 0;
                if (speed <= 4)
                    return 1;
                if (speed <= 8)
                    return 0.90;
                if (speed == 9)
                    return 0.80;
                if (speed == 10)
                    return 0.77;
                else throw new ArgumentException();
            }


            public static double ProductionRatePerHour(int speed) => speed * 221 * SuccessRate(speed);

            public static int WorkingItemsPerMinute(int speed) => (int)(ProductionRatePerHour(speed) / 60);

        }

    }
}
