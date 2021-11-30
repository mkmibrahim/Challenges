using Xunit;

namespace _25_MatrixMultiplication.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[,] firstMatrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 1 } };

            int[,] secondMatrix =  { { 1, 2, 3 },
                                        { 3, 2, 1 },
                                        { 4, 5, 2 } };

            var result = MatrixHelper.Multiply(firstMatrix, secondMatrix);
            
            int[,] expectedResultMatrix = new[,] { { 19, 21, 11 },
                                             {43, 48, 29 },
                                             {35, 35, 31 }};

            CheckMatrixesAreEqual(expectedResultMatrix, result);
        }

        [Fact]
        public void Test2()
        {
            int[,] firstMatrix = { { 4, 4, 4 }, { 2,2,2 }, { 3,3,3 } };

            int[,] secondMatrix =  { { 1, 4, 3 },
                                        { 3, 2, 4 },
                                        { 1,2,4 } };

            var result = MatrixHelper.Multiply(firstMatrix, secondMatrix);


            int[,] expectedResultMatrix = new[,] { { 20, 32, 44 },
                                             {10, 16, 22 },
                                             {15, 24, 33 }};

            CheckMatrixesAreEqual(expectedResultMatrix, result);
        }

        private void CheckMatrixesAreEqual(int[,] expectedResultMatrix, int[,] resultMatrix)
        {
            for(int i = 0;i<3;i++)
            {
                for(var j = 0;j<3;j++)
                {
                    Assert.Equal(expectedResultMatrix[i, j], resultMatrix[i, j]);
                }
            }
        }
    }
}
