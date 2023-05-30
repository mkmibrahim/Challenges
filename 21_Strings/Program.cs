using System.Runtime.CompilerServices;

[assembly:InternalsVisibleTo("21_Strings.Tests")]

namespace _21_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    internal class HighSchoolSweethearts
    {
        internal static string DisplaySingleLine(string v1, string v2)
        {
            char c1 = '\u9825';
            var result = string.Format("{0, 39}", $"{v1}  {c1} {v2}").PadLeft(10);

            return result;
        }
    }
}