using System.Text;

namespace _42_RobotName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class RobotName
    {
        const int robotsCount = 10_000;
        public static List<string> names = new List<string>(robotsCount);

        const string Letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string Numbers = "0123456789";
        static Random randomCharacter = new Random();
        static readonly Stack<string> RandomNames = Names().Shuffle().ToStack();

        public static string Generate() => RandomNames.Pop();

        private static IEnumerable<string> Names() =>
            from letter1 in Letters
            from letter2 in Letters
            from number1 in Numbers
            from number2 in Numbers
            from number3 in Numbers
            select $"{letter1}{letter2}{number1}{number2}{number3}";

            private static T[] Shuffle<T>(this IEnumerable<T> enumerable)
            {
                var arr = enumerable.ToArray();
                var n = arr.Length;  
                while (n > 1)
                {  
                    n--;  
                    var k = randomCharacter.Next(n + 1);  
                    var value = arr[k];  
                    arr[k] = arr[n];  
                    arr[n] = value;  
                }
            return arr;
            }

        private static Stack<T> ToStack<T>(this IEnumerable<T> enumerable) => new(enumerable);
    }

    public class Robot
    {
        string _name;
        
        public string Name
        {
            get
            {
                if (_name == null)
                {
                    Reset();
                    while (RobotName.names.Contains(_name))
                        Reset() ;
                    RobotName.names.Add(_name);
                }
                return _name;
            }
        }

        public void Reset()
        {
            _name = RobotName.Generate();
        }
    }
}