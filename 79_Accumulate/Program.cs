namespace _79_Accumulate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class AccumulateExtensions
    {

        public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
        {
            foreach (T element in collection)
            {
                yield return func(element);
            }
        }
    }
}