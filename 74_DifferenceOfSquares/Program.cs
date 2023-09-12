namespace _74_DifferenceOfSquares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class DifferenceOfSquares
    {
        public static int CalculateSquareOfSum(int max)
        {
            var list = Enumerable.Range(1, max);
            var sum = list.Sum();
            var result = (int)Math.Pow(sum, 2);
            return result;
        }

        public static int CalculateSumOfSquares(int max)
        {
            var result = Enumerable.Range(1, max).Sum(i => (int)Math.Pow(i, 2));
            return result;
            //List<int> list = new List<int>();
            //for (int i = 0; i <= max; i++) 
            //{
            //    list.Add((int)Math.Pow(i, 2));
            //}
            //return list.Sum();
        }

        public static int CalculateDifferenceOfSquares(int max) => 
            Math.Abs(CalculateSumOfSquares(max) - CalculateSquareOfSum(max));
    }
}