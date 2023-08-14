namespace _69_PerfectNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public enum Classification
    {
        Perfect,
        Abundant,
        Deficient
    }

    public static class PerfectNumbers
    {
        public static Classification Classify(int number)
        {
            if (number < 1)
                throw new ArgumentOutOfRangeException();
            var devisors = new List<int>();
            for (var i = 1; i <= number/2; i++)
            {
                if (number % i == 0)
                    devisors.Add(i);
            }
            var sum = devisors.Sum();
            if (sum == number)
                return Classification.Perfect;
            if (sum > number)
                return Classification.Abundant;
            return Classification.Deficient;

        }
    }
}