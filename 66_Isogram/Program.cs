namespace _66_Isogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class Isogram
    {
        public static bool IsIsogram(string word)
        {
            //var letters = new List<char>();
            //foreach (var letter in word.ToLower())
            //{
            //    if (letters.Contains(letter) && Char.IsLetter(letter))
            //    {
            //        return false;
            //    }
            //    letters.Add(letter);
            //}
            //return true;
            var letters = word.ToLower().Where(Char.IsLetter).ToList();
            var result = letters.Distinct().Count() == letters.Count();
            return result;
        }
    }

}