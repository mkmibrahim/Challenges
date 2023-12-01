using System.Text;

namespace _93_Song
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class juiceSong
    {
        public static string Recite(int startBottles, int takeDown)
        {
            var result = new StringBuilder();
            if (takeDown > 1)
            {
                result.Append(Recite(startBottles, takeDown - 1) + "\n\n");
                startBottles -= takeDown - 1;
            }
            switch (startBottles)
            {
                case 0:
                    result.Append("No more bottles of juice on the wall, no more bottles of juice.\n");
                    result.Append("Go to the store and buy some more, 99 bottles of juice on the wall.");
                    break;
                case 1:
                    result.Append($"{startBottles} bottle of juice on the wall, ");
                    result.Append($"{startBottles} bottle of juice.\n");
                    result.Append("Take it down and pass it around, no more bottles of juice on the wall.");
                    startBottles--;
                    break;
                default:
                    result.Append($"{startBottles} bottles of juice on the wall, ");
                    result.Append($"{startBottles} bottles of juice.\nTake one down and pass it around, ");
                    result.Append(startBottles - 1);
                    result.Append(startBottles - 1 == 1 ? " bottle of juice on the wall."
                        : " bottles of juice on the wall.");
                    startBottles--;
                    break;
            }
            return result.ToString();
        }
    }
}
