namespace _36_GigaSecond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class Gigasecond
    {
        public static DateTime Add(DateTime moment) => moment.AddSeconds(1000000000);
    }
}