using System.Globalization;

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
            if (span > digits.Length || span < 0 || digits.Any(x => !int.TryParse(x.ToString(), out int test)))
                throw new ArgumentException();
            var ints = digits.Select(c => c - '0');
            //Solution 1:
            var result = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                result = getCurrentProduct(digits, span, result, i);
            }

            return result;
        }

        private static int getCurrentProduct(string digits, int span, int result, int i)
        {
            var currentProduct = 1;
            var numberDigitsUsedInCurrentProduct = 0;
            for (int j = 0; j < span; j++)
            {
                if (i + j >= digits.Length)
                    continue;
                currentProduct *= Int16.Parse(digits[i + j].ToString());
                numberDigitsUsedInCurrentProduct++;
            }

            if (numberDigitsUsedInCurrentProduct == span)
                result = result > currentProduct ? result : currentProduct;
            return result;
        }
        // Solution 2: 
        //return Enumerable.Range(0, digits.Length - span + 1)
        //    .Select(i => ints.Skip(i).Take(span))
        //    .Max(s => s.Aggregate(1, (i, p) => i * p));

        // Solution 3:
        //    return digits.Digits().Windowed(span).Max(Product);
        //}

        //private static int[] Digits(this string str) =>
        //    str.Select(CharUnicodeInfo.GetDecimalDigitValue).ToArray();

        //private static IEnumerable<IEnumerable<T>> Windowed<T>(this T[] enumerable, int size)
        //{
        //   for (var i = 0; i < enumerable.Length - size + 1; i++)
        //        yield return enumerable.Skip(i).Take(size);
        //}
        //private static int Product(this IEnumerable<int> numbers) =>
        //        numbers.Aggregate(1, (x, product) => x * product);
        //}
    }
}