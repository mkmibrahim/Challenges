using System.Linq;

namespace _55_SpiralMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class SpiralMatrix
    {
        public static int[,] GetMatrix(int size)
        {
            var result = new int[size,size];
            

            int currentNumber = 1;
            for (int i = 0;i < size; i++)
            {
                for (int j = 0;j< size; j++)
                {
                    while (ArrayContainsZeros(result))
                    {

                    }
                }
            }
            return result;
        }

        private static bool ArrayContainsZeros(int[,] inputMatrix)
        {
            foreach(var numberInResult in inputMatrix)
                if(numberInResult == 0)
                    return false;
            return true;
        }
    }

}