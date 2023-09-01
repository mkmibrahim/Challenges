namespace _72_ScrabbleScore
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class ScrabbleScore
    {
        public static int Score(string input)
        {
            var score = 0;
            var inputString =input.ToUpper();   
            for (int i = 0; i < inputString.Length; i++)
            {
                score += inputString[i] switch
                {
                    'A' or 'E' or 'I' or 'O' or 'U' or 'L' or 'N' or 'R' or 'S' or 'T' => 1,
                    'D' or 'G' => 2,
                    'B' or 'C' or 'M' or 'P' => 3,
                    'F' or 'H' or 'V' or 'W' or 'Y' => 4,
                    'K' => 5,
                    'J' or 'X' => 8,
                    'Q' or 'Z' => 10,
                    _ => 0,
                };
            }
            return score;
        }
    }
}