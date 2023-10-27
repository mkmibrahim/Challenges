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
            var devisorsRemaining = true;
            var currentdevisor = 2;
            while (devisorsRemaining)
            {
                if (currentdevisor > number)
                    devisorsRemaining = false;
                if (number % currentdevisor == 0)
                {
                    result.Add(currentdevisor);
                }
                currentdevisor++;
            }
            
            return result.ToArray();
        }
    }
}