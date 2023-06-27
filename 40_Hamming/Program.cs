using System.Linq;

namespace _40_Hamming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class Hamming
    {
        public static int Distance(string firstStrand, string secondStrand)
        {
            if (firstStrand.Length != secondStrand.Length)
                throw new ArgumentException();
            int distance = 0;
            //for (int i = 0; i < firstStrand.Length; i++)
            //    if (firstStrand[i] != secondStrand[i])
            //        distance++;
            distance = firstStrand.Zip(secondStrand).Count(pair => pair.First != pair.Second);
            return distance;
        }
    }
}