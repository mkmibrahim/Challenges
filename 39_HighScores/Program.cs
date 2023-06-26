using System;
using System.Collections.Generic;
using System.Linq;

namespace _39_HighScores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class HighScores
    {
        List<int> _scores = new List<int>();

        public HighScores(List<int> list) => _scores = list;

        public List<int> Scores() => _scores;

        public int Latest() => _scores.Last();

        public int PersonalBest() => _scores.Max();

        public List<int> PersonalTopThree() =>_scores.OrderByDescending(x => x).Take(3).ToList();
    }

}