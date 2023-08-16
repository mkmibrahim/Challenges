using System.ComponentModel;

namespace _70_CollatzConjecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class CollatzConjecture
    {
        public static int Steps(int number)
        {
            if (number <= 0)
                throw new ArgumentOutOfRangeException();
            var result = 0;
            while(number > 1)
            {
                number = SingleConverter(number);
                result++;
            }
            return result;
        }

        private static int SingleConverter(int number)
        {
            return number % 2 == 0 ? number /= 2 : number * 3 + 1;
        }
    }
}