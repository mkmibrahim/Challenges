using System.Text;

namespace _63_Forth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class Forth
    {
        public static string Evaluate(string[] instructions)
        {
            var stack = new Stack<object>();
            for(int i = 0; i < instructions.Length; i++)
            {
                string instruction = instructions[i];
                var instructionSplit = instruction.Split(' ');
                if (instructionSplit.Length > 1)
                {
                    foreach (var item in instructionSplit)
                    {
                        AddToStack(stack, item);
                    }
                    //continue;
                }
                AddToStack(stack, instruction);
            }
            var stackResult = new StringBuilder();
            while(stack.Count > 0)
            {
                stackResult.Insert(0, stack.Pop() + " ");
            }
            return stackResult.ToString().Trim();
        }

        private static void AddToStack(Stack<object> stack, string instruction)
        {
            if (int.TryParse(instruction, out int intResult))
            {
                stack.Push(intResult);
            }
            else if (instruction == "+" || instruction == "-"
                || instruction == "*" || instruction == "/")
            {
                if (stack.Count < 2)
                {
                    throw new InvalidOperationException();
                }
                int a = (int)stack.Pop();
                int b = (int)stack.Pop();
                if (instruction == "+")
                {
                    stack.Push(a + b);
                }
                if (instruction == "-")
                {
                    stack.Push(b - a);
                }
                if (instruction == "*")
                {
                    stack.Push(a * b);
                }
                if (instruction == "/")
                {
                    stack.Push(b / a);
                }
            }
            else if (instruction == "dup")
            {
                if (stack.Count < 1)
                {
                    throw new InvalidOperationException();
                }
                var a = stack.Pop();
                stack.Push(a);
                stack.Push(a);
            }
            else if (instruction == "drop")
            {
                if (stack.Count < 1)
                {
                    throw new InvalidOperationException();
                }
                stack.Pop();
            }
            else if (instruction == "swap")
            {
                if (stack.Count < 2)
                {
                    throw new InvalidOperationException();
                }
                int a = (int)stack.Pop();
                int b = (int)stack.Pop();
                stack.Push(a);
                stack.Push(b);
            }
            else if (instruction == "over")
            {
                if (stack.Count < 2)
                {
                    throw new InvalidOperationException();
                }
                int a = (int)stack.Pop();
                int b = (int)stack.Pop();
                stack.Push(b);
                stack.Push(a);
                stack.Push(b);
            }
            if (!string.IsNullOrWhiteSpace(instruction))
            {
                stack.Push(instruction);
            }
        }
    }
}