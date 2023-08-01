using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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
            Dictionary<string, string> userDefinedWords = new Dictionary<string, string>();
            var stack = new Stack<int>();
            for(int i = 0; i < instructions.Length; i++)
            {
                string instruction = instructions[i];
                if (instruction.StartsWith(":") && instruction.EndsWith(";"))
                {
                    var instructionSplit = instruction.Split(' ');
                    AddUserDefined(instructionSplit[1], instruction.Substring(instructionSplit[1].Length+3,
                        instruction.Length - (instructionSplit[1].Length+5)), userDefinedWords);
                }
                else
                { 
                    var instructionSplit = instruction.Split(' ');
                
                    for (int j = 0; j <  instructionSplit.Count(); j++)
                    {
                        if (userDefinedWords.ContainsKey(instructionSplit[j].ToLower()))
                        {
                            var userDefinedInstruction = userDefinedWords[instructionSplit[j].ToLower()];
                            var userDefinedInstructionSplit = userDefinedInstruction.Split(' ');
                            for (int k = 0; k < userDefinedInstructionSplit.Count(); k++)
                            {
                                AddToStack(stack, userDefinedInstructionSplit[k]);
                            }
                        }
                        else
                        {
                            AddToStack(stack, instructionSplit[j]);
                        }
                        
                    }
                }
            }
            var stackResult = new StringBuilder();
            while(stack.Count > 0)
            {
                stackResult.Insert(0, stack.Pop() + " ");
            }
            return stackResult.ToString().Trim();
        }

        private static void AddUserDefined(string wordName, string definition, Dictionary<string, string> userDefinedWords)
        {
            if (int.TryParse(wordName, out int result))
                throw new InvalidOperationException("Invalid Definition");
            definition = CheckExistingNamesInDefinition(definition, userDefinedWords);
            if (userDefinedWords.ContainsKey(wordName.ToLower()))
                userDefinedWords[wordName] = definition;
            else
                userDefinedWords.Add(wordName.ToLower(), definition);
        }

        private static string CheckExistingNamesInDefinition(string definition, Dictionary<string, string> userDefinedWords)
        {
            var definitionSplit = definition.Split(' ');
            for (var i = 0; i < definitionSplit.Count(); i++)
            {
                if (userDefinedWords.ContainsKey(definitionSplit[i].ToLower()))
                {
                    definition = definition.Replace(definitionSplit[i], userDefinedWords[definitionSplit[i]]);
                }
            }

            return definition;
        }

        private static void AddToStack(Stack<int> stack, string instruction)
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
            else if (instruction.ToLower() == "dup")
            {
                if (stack.Count < 1)
                {
                    throw new InvalidOperationException();
                }
                var a = stack.Pop();
                stack.Push(a);
                stack.Push(a);
            }
            else if (instruction.ToLower() == "drop")
            {
                if (stack.Count < 1)
                {
                    throw new InvalidOperationException();
                }
                stack.Pop();
            }
            else if (instruction.ToLower() == "swap")
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
            else if (instruction.ToLower() == "over")
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
            else 
            {
                throw new InvalidOperationException();
            }
        }
    }
}