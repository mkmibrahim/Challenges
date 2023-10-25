using System.Linq;

namespace _82_PascalsTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class PascalsTriangle
    {
        public static IEnumerable<IEnumerable<int>> Calculate(int rows)
        {
            var result = new List<IEnumerable<int>>();
            for (int i = 0; i < rows; i++)
            {
                var row = new int[i + 1];
                row[0] = 1;
                row[i] = 1;
                for (int j = 1; j < i; j++)
                {
                    row[j] = result.ElementAt(i - 1).ElementAt(j - 1) + result.ElementAt(i - 1).ElementAt(j);
                }
                result.Add(row);
            }
            return result;
        }

    }
}