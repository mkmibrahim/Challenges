using System.Text;

namespace _96_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class House
    {
        public static string Recite(int verseNumber) => 
            verseNumber switch
            {
                1 => "This is the house that Jack built.",
                2 => "This is the malt that lay in the house that Jack built.",
                3 => "This is the rat that ate the malt that lay in the house that Jack built.",
                4 => "This is the cat that killed the rat that ate the malt that lay in the house that Jack built.",
                5 => "This is the dog that worried the cat that killed the rat that ate the malt that lay in the house that Jack built.",
                6 => "This is the cow with the crumpled horn that tossed the dog that worried the cat that killed the rat that ate the malt that lay in the house that Jack built.",
                7 => "This is the maiden all forlorn that milked the cow with the crumpled horn that tossed the dog that worried the cat that killed the rat that ate the malt that lay in the house that Jack built.",
                8 => "This is the man all tattered and torn that kissed the maiden all forlorn that milked the cow with the crumpled horn that tossed the dog that worried the cat that killed the rat that ate the malt that lay in the house that Jack built.",
                9 => "This is the priest all shaven and shorn that married the man all tattered and torn that kissed the maiden all forlorn that milked the cow with the crumpled horn that tossed the dog that worried the cat that killed the rat that ate the malt that lay in the house that Jack built.",
                10 => "This is the rooster that crowed in the morn that woke the priest all shaven and shorn that married the man all tattered and torn that kissed the maiden all forlorn that milked the cow with the crumpled horn that tossed the dog that worried the cat that killed the rat that ate the malt that lay in the house that Jack built.",
                11 => "This is the farmer sowing his corn that kept the rooster that crowed in the morn that woke the priest all shaven and shorn that married the man all tattered and torn that kissed the maiden all forlorn that milked the cow with the crumpled horn that tossed the dog that worried the cat that killed the rat that ate the malt that lay in the house that Jack built.",
                12 => "This is the horse and the hound and the horn that belonged to the farmer sowing his corn that kept the rooster that crowed in the morn that woke the priest all shaven and shorn that married the man all tattered and torn that kissed the maiden all forlorn that milked the cow with the crumpled horn that tossed the dog that worried the cat that killed the rat that ate the malt that lay in the house that Jack built.",
                _ => ""
            };
        
        public static string Recite(int startVerse, int endVerse)
        {
            var result = new StringBuilder();
            for (int i = startVerse; i <= endVerse; i++)
            {
                result.Append(Recite(i));
                if (i != endVerse)
                    result.Append("\n");
            }
            return result.ToString();
        }
    }
}
