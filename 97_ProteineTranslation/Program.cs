using System.Linq;

namespace _97_ProteineTranslation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class ProteinTranslation
    {
        public static string[] Proteins(string strand)
        {
            var result = new List<string>();
            if (String.IsNullOrEmpty(strand))
                return result.ToArray();

            var strandSplit = strand.SplitByLength(3);
            var numberOfCommas = strandSplit.Count() > 3 ? 3 : strandSplit.Count();

            foreach(var currentProtein in strandSplit)
            {
                if (checkStop(currentProtein))
                    break;
                else
                    result.Add(getProtein(currentProtein));
            }
            return result.ToArray();
        }

        public static IEnumerable<string> SplitByLength(this string str, int maxLength)
        {
            for (int index = 0; index < str.Length; index += maxLength)
            {
                yield return str.Substring(index, Math.Min(maxLength, str.Length - index));
            }
        }

        private static bool checkStop(string input) => 
            input == "UAA" || input == "UAG" || input == "UGA";

        private static string getProtein(string v) => v switch
            {
                "AUG" => "Methionine",
                "UUU" or "UUC" => "Phenylalanine",
                "UUA" or "UUG" => "Leucine",
                "UCU" or "UCC" or "UCA" or "UCG" => "Serine",
                "UAU" or "UAC" => "Tyrosine",
                "UGU" or "UGC" => "Cysteine",
                "UGG" => "Tryptophan",
                "UAA" or "UAG" or "UGA" => "",
                _ => ""
            };
    }
}
