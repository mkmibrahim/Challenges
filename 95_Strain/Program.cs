namespace _95_Strain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class Strain
    {
        public static IEnumerable<T> Keep<T>(this IEnumerable<T> collection, Func<T, bool> predicate)=>
            collection.Where(predicate);
        
        public static IEnumerable<T> Discard<T>(this IEnumerable<T> collection, Func<T, bool> predicate) =>
            collection.Where(x => !predicate(x));
    }
}
