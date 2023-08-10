using System.Linq;

namespace _68_Grains
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class Grains
    {
        public static ulong Square(int n)
        {
            if (n < 1 || n > 64)
                throw new ArgumentOutOfRangeException();
            else
            if (n == 1)
                return 1;
            else
                return Square(n - 1) * 2;
          
        }

        public static ulong Total()
        {
            //return (Square(64) - 1)* 2 + 1;
            //var result = Enumerable.Range(1, 64).Sum(Square); // Square must return double
            var result = Enumerable.Range(1, 64).Aggregate(0UL, (a, b) => a + Square(b));
            return (ulong)result;
        }
    }
}