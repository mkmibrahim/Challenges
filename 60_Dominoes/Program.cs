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
            var availableDominoes = dominoes;
            var result = false;
            if (dominoes.Count() == 0)
                return true;
            if (dominoes.Count() == 1)
                return dominoes.ElementAt(0).Item1 == dominoes.ElementAt(0).Item2;
            if (dominoes.Count() == 2)
                return dominoes.ElementAt(0).Item2 == dominoes.ElementAt(1).Item1 |
                        dominoes.ElementAt(0).Item2 == dominoes.ElementAt(1).Item2;


            //for (int i = 0; i < dominoes.Count() ; i++)
            //{
            //    // check if there is next domino that is compatible
            //    for(int j= i+1; j < dominoes.Count(); j++)
            //    {
            //        if (dominoes.ElementAt(i).Item2 == dominoes.ElementAt(j).Item1 |
            //            dominoes.ElementAt(i).Item2 == dominoes.ElementAt(j).Item2
            //            )
            //        {
            //            var remainingDominos = dominoes.ToList();
            //                // remove first element
            //                remainingDominos.Remove(remainingDominos.First(d => d.Equals(dominoes.ElementAt(0))));
            //                // move currentDomino j to front
            //                var currentDomino = dominoes.ElementAt(j);
            //            if (dominoes.ElementAt(i).Item2 == dominoes.ElementAt(j).Item2)
            //                {
            //                // reverse currentDomino
            //                currentDomino = (dominoes.ElementAt(j).Item2, dominoes.ElementAt(j).Item1);
            //                }
            //                remainingDominos.Remove(dominoes.ElementAt(j));
            //                remainingDominos.Insert(0, currentDomino);
            //                return Dominoes.CanChain(remainingDominos);
            //        }
            //    }
            //}

            for (int i = 1; i < dominoes.Count() ; i++)
            {
                // check if there is next domino that is compatible
                    if (dominoes.ElementAt(0).Item2 == dominoes.ElementAt(i).Item1 |
                        dominoes.ElementAt(0).Item2 == dominoes.ElementAt(i).Item2
                        )
                    {
                        var remainingDominos = dominoes.ToList();
                            // remove first element
                            remainingDominos.Remove(remainingDominos.First(d => d.Equals(dominoes.ElementAt(0))));
                            // move currentDomino j to front
                            var currentDomino = dominoes.ElementAt(i);
                        if (dominoes.ElementAt(0).Item2 == dominoes.ElementAt(i).Item2)
                            {
                            // reverse currentDomino
                            currentDomino = (dominoes.ElementAt(i).Item2, dominoes.ElementAt(i).Item1);
                            }
                            remainingDominos.Remove(dominoes.ElementAt(i));
                            remainingDominos.Insert(0, currentDomino);
                            return Dominoes.CanChain(remainingDominos);
                    }
            }

            return false;
        }
    }
}