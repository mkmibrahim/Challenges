
namespace _67_Acronym
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class Acronym
    {
        public static string Abbreviate(string phrase)
        {
            var acronym = "";
            var words = phrase.Split(' ', '-', '_').ToList();
            words.ForEach(word => {
                if (word.Length > 0)
                    acronym += word[0].ToString().ToUpper();
                });
            return acronym;
        }
    }

}