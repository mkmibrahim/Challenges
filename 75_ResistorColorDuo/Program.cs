namespace _75_ResistorColorDuo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class ResistorColorDuo
    {
        public static int Value(string[] colors)
        {
            var result = "";
            foreach (var color in colors)
            {
                if (result.Length >= 2)
                    break;
                result += GetValue(color);
            }
            var intResult = int.Parse(result);
            return intResult;
        }

        private static int GetValue(string color) => (color.ToLower()) switch
        {
            "black" => 0,
            "brown" => 1,
            "red" => 2,
            "orange" => 3,
            "yellow" => 4,
            "green" => 5,
            "blue" => 6,
            "violet" => 7,
            "grey" => 8,
            "white" => 9,
            _ => -1
        };
    }
}