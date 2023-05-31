using System.Globalization;
using System.Runtime.CompilerServices;

[assembly:InternalsVisibleTo("21_Strings.Tests")]

namespace _21_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HighSchoolSweethearts.DisplaySingleLine("Hello", "World"));
        }
    }

    public static class HighSchoolSweethearts
    {
        public static string DisplaySingleLine(string studentA, string studentB)
        {
            var result = ($"{studentA} ♡ {studentB}").PadLeft(41).PadRight(61);

            return result;
        }

        public static string DisplayBanner(string studentA, string studentB)
        {
            var result = @$" ******       ******
   **      **   **      **
 **         ** **         **
**            *            **
**                         **
**     {studentA}  +  {studentB}     **
 **                       **
   **                   **
     **               **
       **           **
         **       **
           **   **
             ***
              *";

            return result;
        }

        public static string DisplayGermanExchangeStudents(string studentA
            , string studentB, DateTime start, float hours)
        {
            var result = String.Format(new System.Globalization.CultureInfo("en-DE"),
                $"{studentA} and {studentB} have been dating since " +
                $"{start.ToString("dd.MM.yyyy", new System.Globalization.CultureInfo("en-DE"))}" +
                $" - that's {hours.ToString("N2", new System.Globalization.CultureInfo("en-DE"))} hours");
            return result;
        }
    }
}