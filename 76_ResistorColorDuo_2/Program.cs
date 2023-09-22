namespace _76_ResistorColorDuo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class ResistorColorTrio
    {
        public static string Label(string[] colors)
        {
            var result = "";
            for (int i = 0; i < 2; i++)
            {
                result += GetColorNumber(colors[i]);
            }

            result += getPostfix(colors[2]);
            return result;
        }

        private static string getPostfix(string color) =>
            color.ToLower() switch
            {
                "black" => " ohms",
                "brown" => "0 ohms",
                "red" => " kiloohms",
                "orange" => " kiloohms",
                "yellow" => "0 kiloohms",
                _ => ""
            };

        private static string GetColorNumber(string color) =>
            color.ToLower() switch
            {

                "black" => "",
                "brown" => "1",
                "red" => "2",
                "orange" => "3",
                "yellow" => "4",
                "green" => "5",
                "blue" => "6",
                "violet" => "7",
                "grey" => "8",
                "white" => "9",
                _ => ""
            };
    }

}