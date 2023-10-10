namespace _80_AllYourBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class AllYourBase
    {
        public static int[] Rebase(int inputBase, int[] inputDigits, int outputBase)
        {
            if (inputBase <= 1 || outputBase <= 1 
                               || inputDigits.Any(digit => digit < 0 || digit >= inputBase))
            {
                throw new ArgumentException();
            }

            int valueDecimal = 0;
            for (int i = 0; i < inputDigits.Length; i++)
            {
                valueDecimal = valueDecimal * inputBase + inputDigits[i];
            }

            if (valueDecimal == 0)
            {
                return new int[] { 0 };
            }

            List<int> resultDigits = new List<int>();
            while (valueDecimal > 0)
            {
                int remainder = valueDecimal % outputBase;
                resultDigits.Insert(0, remainder);
                valueDecimal = valueDecimal /outputBase;
            }

            return resultDigits.ToArray();
        }

       
    }
}