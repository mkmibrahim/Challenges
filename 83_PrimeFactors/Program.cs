namespace _83_PrimeFactors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class PrimeFactors
    {
        public static long[] Factors(long number)
        {
            var result = new List<long>();
            long remaining = number;
            int currentDivisor = 2;
            while (currentDivisor <= remaining )
            {
                if (remaining % currentDivisor == 0)
                {
                    result.Add(currentDivisor);
                    remaining = remaining / currentDivisor;
                }
                else
                    currentDivisor++;
            }
            return result.ToArray();
        }
    }
}