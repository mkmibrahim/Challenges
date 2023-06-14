using System.Linq.Expressions;

namespace _33_TweFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class TwoFer
    {
        public static string Speak(string? name = "you") => 
                $"One for {name}, one for me.";
    }
}