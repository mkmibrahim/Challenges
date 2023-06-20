using System.Linq;
namespace _37_ResistorColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class ResistorColor
    {
        private enum colorEnum
        {
            black, 
            brown,
            red,
            orange,
            yellow,
            green,
            blue,
            violet,
            grey,
            white
        }

        public static int ColorCode(string color)
        {
            Enum.TryParse<colorEnum>(color, out var colorCode);
            return (int) colorCode;
        }

        public static string[] Colors()
        {
            var test1 = Enum.GetValues(typeof(colorEnum));
            var test2 = test1.Select(c => c.toString());
            var test3 = test2.Cast<string>();
            var test4 = test3.ToArray();
            return Enum.GetValues(typeof(colorEnum)).Cast<colorEnum>().Cast<string>().ToArray();
        }
    }
}