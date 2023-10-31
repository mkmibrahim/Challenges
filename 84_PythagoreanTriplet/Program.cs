namespace _84_PythagoreanTriplet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class PythagoreanTriplet
    {
        public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
        {
            var result = new List<(int, int, int)>();
            for (var i = 1; i < sum/2; i++)
            {
                for (var j = i; j < sum; j++)
                {
                    for (var k = j; k < sum; k++)
                    {
                        if (i + j + k == sum &&
                            i < j && j < k &&
                            Math.Pow(i, 2) + Math.Pow(j, 2) == Math.Pow(k, 2) 
                             
                            )
                        {
                            result.Add((i, j, k));
                        }
                    }
                }
            }

            return result;
        }
    }
}
