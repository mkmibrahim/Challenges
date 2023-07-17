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

            int rowStart = 0 , rowEnd = size - 1;
            int colStart = 0, colEnd = size - 1;
            int value = 1;

            while (rowStart <= rowEnd && colStart <= colEnd)
            {
                // Print top row
                for (int col = colStart; col <= colEnd; col++)
                {
                    result[rowStart, col] = value++;
                }
                rowStart++;

                // Print right column
                for (int row = rowStart; row <= rowEnd; row++)
                {
                    result[row, colEnd] = value++;
                }
                colEnd--;

                // Print bottom row
                if (rowStart <= rowEnd)
                {
                    for (int col = colEnd; col >= colStart; col--)
                        result[rowEnd, col] = value++;
                }
                rowEnd--;

                 // Print left column
                if (colStart < colEnd)
                {
                    for (int row = rowEnd; row >= rowStart; row--)
                    {
                        result[row, colStart] = value++;
                    }
                    colStart++;
                }
           
            }

           
            return result;
        }

        
    }

}