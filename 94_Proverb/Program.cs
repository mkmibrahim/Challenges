namespace _94_Proverb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class Proverb
    {
        public static string[] Recite(string[] subjects)
        {
            var result = new List<string>();
            if (subjects.Length == 0)
            {
                return result.ToArray();
            }
            foreach (var subject in subjects)
            {
                var index = Array.IndexOf(subjects, subject);
                if (index == subjects.Length - 1)
                {
                    result.Add($"And all for the want of a {subjects[0]}.");
                }
                else
                {
                    result.Add($"For want of a {subject} the {subjects[index + 1]} was lost.");
                }
            }
            return result.ToArray();
        }
    }
}
