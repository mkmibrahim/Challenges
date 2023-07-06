using System.Text;

namespace _48_RotationalCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class RotationalCipher
    {
        static string _letters = "abcdefghijklmnopqrstuvwxyz";

        public static string Rotate(string text, int shiftKey)
        {
            //StringBuilder result = new StringBuilder();
            //for(int i  = 0; i < text.Length; i++)
            //{
            //    var isUpper = char.IsUpper(text[i]);
                
            //    if (_letters.Contains(char.ToLower(text[i])))
            //    { 
            //        var currentLocation = _letters.IndexOf(char.ToLower(text[i]));
            //        var targetLocation = (currentLocation + shiftKey) % 26;
            //        var newLetter = isUpper ? char.ToUpper(_letters[targetLocation]) : _letters[targetLocation];
            //        result.Append(newLetter);
            //    }
            //    else
            //        result.Append(text[i]);
            //}
            //return result.ToString();

            char Rotate(char c)
            {
                if (!char.IsLetter(c)) 
                    return c;
                int b = char.IsLower(c) ? 'a' : 'A';
                return (char)(b + ((c-b + shiftKey) % 26));
            }
            return new string (text.Select(Rotate).ToArray());
        }
    }
}