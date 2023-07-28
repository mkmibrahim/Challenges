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
            var stack = new Stack<int>();
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

        private static void AddToStack(Stack<int> stack, string instruction)
        {
            if (int.TryParse(instruction, out int intResult))
            {
                stack.Push(intResult);
            }
            if (instruction == "+" || instruction == "-"
                || instruction == "*" || instruction == "/")
            {
                if (stack.Count < 2)
                {
                    throw new InvalidOperationException();
                }
                int a = stack.Pop();
                int b = stack.Pop();
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
            if (instruction == "dup")
            {
                if (stack.Count < 1)
                {
                    throw new InvalidOperationException();
                }
                int a = stack.Pop();
                stack.Push(a);
                stack.Push(a);
            }
            if (instruction == "drop")
            {
                if (stack.Count < 1)
                {
                    throw new InvalidOperationException();
                }
                stack.Pop();
            }
            if (instruction == "swap")
            {
                if (stack.Count < 2)
                {
                    throw new InvalidOperationException();
                }
                int a = stack.Pop();
                int b = stack.Pop();
                stack.Push(a);
                stack.Push(b);
            }
            if (instruction == "over")
            {
                if (stack.Count < 2)
                {
                    throw new InvalidOperationException();
                }
                int a = stack.Pop();
                int b = stack.Pop();
                stack.Push(b);
                stack.Push(a);
                stack.Push(b);
            }
        }
    }
}