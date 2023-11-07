namespace _87_ArmstrongNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class ArmstrongNumbers
    {
        public static bool IsArmstrongNumber(int number)
        {
            double currentSum = 0;
            for (int i = 0; i < number.ToString().Length; i++)
            {
                char digitChar = number.ToString()[i];
                var digit = int.Parse(digitChar.ToString());
                currentSum += Math.Pow(digit, number.ToString().Length);
            }
            return currentSum == number;
        }

    }
}