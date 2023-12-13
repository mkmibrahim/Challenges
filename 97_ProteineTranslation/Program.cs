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

            var strandSplit = strand.Split(',');
            var numberOfCommas = strandSplit.Length > 3 ? 3 : strandSplit.Length;

            for (int i = 0; i < numberOfCommas; i++)
            {
                result.Add(GetProtein(strandSplit[i]));
            }
            
            
            return result.ToArray();
        }

        private static string GetProtein(string v) 
        {
            return v switch
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
}
