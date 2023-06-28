namespace _41_Nucleotide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class NucleotideCount
    {
        public static IDictionary<char, int> Count(string sequence)
        {
            var result = new Dictionary<char, int>
            {
                ['A'] = 0,
                ['C'] = 0,
                ['G'] = 0,
                ['T'] = 0
            };
            for(int i = 0; i < sequence.Length; i++)
            {
                if (result.ContainsKey(sequence[i]))
                    result[sequence[i]]++;
                else
                    throw new ArgumentException();
            }
            return result;
        }
    }
}