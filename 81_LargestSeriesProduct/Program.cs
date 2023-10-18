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
            if (string.IsNullOrEmpty(digits) ||
                span <= 0 ||
                digits.Any(x => !int.TryParse(x.ToString(), out int test)) ||
                span > digits.Length)
                throw new ArgumentException();
            var result = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                var currentProduct = 1;
                var numberDigitsUsedInCurrentProduct = 0;
                for (int j = 0; j < span; j++)
                {
                    if (i+j >= digits.Length)
                        continue;
                    currentProduct *= Int16.Parse(digits[i+j].ToString());
                    numberDigitsUsedInCurrentProduct++;
                }
                if (numberDigitsUsedInCurrentProduct == span)
                    result = result > currentProduct ? result : currentProduct;
            }
            return result;
        }
    }
}