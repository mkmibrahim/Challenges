namespace _65_Pangram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class Pangram
    {
        public static bool IsPangram(string input)
        {
            string letters = "abcdefghijklmnopqrstuvwxyz";
            //var result = true;
            //for (var i = 0; i < letters.Length; i++)
            //{
            //    if (!input.ToLower().Contains(letters[i]))
            //    {
            //        result = false;
            //        break;
            //    }
            //}
            var result = letters.All(input.ToLower().Contains);
            return result;
        }
    }
}