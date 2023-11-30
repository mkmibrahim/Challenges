using System.Text;

namespace _92_Raindrops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class Raindrops
    {
        public static string Convert(int number)
        {
            var result = new StringBuilder();
            if (number % 3 == 0)
            {
                result.Append("Pling");
            }
            if (number % 5 == 0)
            {
                result.Append("Plang");
            }
            if (number % 7 == 0)
            {
                result.Append("Plong");
            }
            if (result.Length == 0)
            {
                result.Append(number.ToString());
            }
            return result.ToString();
        }
    }
}
