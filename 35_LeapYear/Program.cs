namespace _35_LeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class Leap
    {
        public static bool IsLeapYear(int year) => (year % 4 == 0) & ((year % 100 != 0) | (year % 400 == 0));
    }
}