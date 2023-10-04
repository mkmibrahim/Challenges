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
            var result = new int[inputDigits.Length];
            for (int i = 0; i< inputDigits.Length; i++)
            {
                var numberofDigits = Math.Floor(Math.Log10(inputDigits[i]) + 1);
                //var test = Math.Pow(inputDigits[i], inputBase);
                
                //var temp = raiseToPower(inputBase, numberofDigits);
                var tempNum = int.Parse(inputDigits[i].ToString()) * raiseToPower(inputBase, numberofDigits);
                    
                    
                result[i] = tempNum;
            }
            return result;
        }

        private static int raiseToPower(int inputBase, double inputNumber)
        {
            var result = inputNumber;
            for(var i = 0; i < inputNumber; i++)
            {
                result *= inputNumber;
            }
            return (int)result;
        }
    }
}