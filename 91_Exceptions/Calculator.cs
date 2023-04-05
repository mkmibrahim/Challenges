using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _91_Exceptions
{
    internal class Calculator
    {
    }
}


public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string operation)
    {
        if (operation is null)
            throw new ArgumentNullException("operation was null");
        if (operation == string.Empty)
            throw new ArgumentException("No operation was provided");
        if (operation == "+")
            return operand1.ToString() + " + " + operand2.ToString() + " = " + (operand1 + operand2);
        if (operation == "*")
            return operand1.ToString() + " * " + operand2.ToString() + " = " + (operand1 * operand2);
        if (operation == "/")
        {
            if (operand2 == 0)
                return "Division by zero is not allowed.";
            return operand1.ToString() + " / " + operand2.ToString() + " = " + (operand1 / operand2);

        }
        else
            throw new ArgumentOutOfRangeException("operation "+ operation + " is not supported.");
    }
}