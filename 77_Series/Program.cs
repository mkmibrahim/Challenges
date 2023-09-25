using System.Collections.Generic;

namespace _77_Series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class Series
    {
        public static string[] Slices(string numbers, int sliceLength)
        {
            var result = new List<string>();
            if (sliceLength < 1 ||
                sliceLength > numbers.Length)
            {
                throw new ArgumentException();
            }
            for(int i = 0; i < numbers.Length; i++)
            {
                if (i+sliceLength <= numbers.Length)
                    result.Add(numbers.Substring(i, sliceLength));
            }
            return result.ToArray();
        }
    }
}