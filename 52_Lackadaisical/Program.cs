namespace _52_Lackadaisical
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class Bob
    {
        public static string Response(string statement)
        {
            statement = statement.Trim();
            if (String.IsNullOrWhiteSpace(statement))
                return "Fine. Be that way!";
            bool isquestion = statement.EndsWith('?');
            bool isYelling = statement.Any(Char.IsLetter) && statement.ToUpperInvariant() == statement;
            
            if (isquestion & isYelling) 
                return "Calm down, I know what I'm doing!";
            if (isquestion) 
                return "Sure.";
            if (isYelling)
                return "Whoa, chill out!";
            return "Whatever.";
        }
    }
}