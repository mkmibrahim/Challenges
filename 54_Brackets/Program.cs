using System.Text;

namespace _54_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class MatchingBrackets
    {
        public static bool IsPaired(string input)
        {
            var charsStack = new Stack<char>();
            bool result = true;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '[' | input[i] == '{' | input[i] == '(' )
                    charsStack.Push(input[i]);
                if (input[i] == ']' | input[i] == '}' | input[i] == ')' )
                {
                    if (charsStack.Count == 0)
                        return false;

                    char previous = charsStack.Peek();
                    if (input[i] == ']' && previous == '['
                        || input[i] == '}' && previous == '{'
                        || input[i] == ')' && previous == '(')
                        charsStack.Pop();
                    else
                        result = false;
                }

            }
            if (charsStack.Count > 0) 
                result = false;
            return result;

            //StringBuilder sb = new StringBuilder();
            //bool result = true;
            //for (int i = 0;i < input.Length; i++)
            //{
            //    if (input[i] == '[' | input[i] == '{' | input[i] == '(' )
            //        sb.Append(input[i]);
            //    if (input[i] == ']')
            //        if (sb.Length > 0 && sb[sb.Length-1] == '[')
            //            sb.Length--;
            //        else
            //            result = false;
            //    if (input[i] == '}')
            //        if (sb.Length > 0 && sb[sb.Length-1] == '{')
            //            sb.Length--;
            //        else
            //            result = false;
            //    if (input[i] == ')')
            //        if (sb.Length > 0 && sb[sb.Length-1] == '(')
            //            sb.Length--;
            //        else
            //            result = false;
            //}
            //if (sb.Length > 0)
            //    result = false;
            //return result;
        }
    }

}