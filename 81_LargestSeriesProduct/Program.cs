namespace _81_LargestSeriesProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class LargestSeriesProduct
    {
        public static long GetLargestProduct(string digits, int span)
        {
            var result = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                if (Int16.Parse(digits[i].ToString()) < span)
                    continue;
                var currentProduct = 1;
                for (int j = 0; j < span; j++)
                {
                    currentProduct *= Int16.Parse(digits[j].ToString());
                }

                result = result > currentProduct ? result : currentProduct;
            }
            return result;
        }
    }
}