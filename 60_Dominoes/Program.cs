namespace _60_Dominoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class Dominoes
    {
        public static bool CanChain(IEnumerable<(int, int)> dominoes)
        {
            var result = false;
            if (dominoes.Count() == 0)
                return true;
            if (dominoes.Count() == 1)
                return dominoes.ElementAt(0).Item1 == dominoes.ElementAt(0).Item2;

            for (int i = 0; i < dominoes.Count() ; i++)
            {
                int start, end;
                if (i == 0)
                    start = dominoes.ElementAt(i).Item1;
                if (i ==  dominoes.Count() - 1)
                    end = dominoes.ElementAt(i).Item2;


                
            }
            return result;
        }
    }
}