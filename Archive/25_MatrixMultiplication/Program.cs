//Write a program to takes input two matrix(3*3) array and calculate the multiplication of both matrix.

//Example :
//1.If two matrix are :
//Matrix 1st:
//1 2 3
//4 5 6
//7 8 1

//Matrix 2nd:
//1 2 3
//3 2 1
//4 5 2

//then the multiplication of both matrix will be :
//19 21 11
//43 48 29
//35 35 31

//2.If two matrix are :
//Matrix 1st:
//4 4 4
//2 2 2
//3 3 3

//Matrix 2nd:
//1 4 3
//3 2 4
//1 2 4

//then the multiplication of both matrix will be :
//20 32 44
//10 16 22
//15 24 33
using System;

namespace _25_MatrixMultiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            int[,] arr1 = new int[3, 3];
            int[,] arr2 = new int[3, 3];


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Matrix 1st [" + i + "][" + j + "]:");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Matrix 2nd [" + i + "][" + j + "]:");
                    arr1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //write your logic here 
            arr2 = MatrixHelper.Multiply(arr, arr1);
            //end


            Console.WriteLine("Multiply of both matrix:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }


        }
    }

    public class MatrixHelper
    {

        public static int[,] Multiply (int[,] firstMatrix, int[,] secondMatrix)
        {
            int[,] result = new int[3, 3];
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result[i, j] = 0;
                    for(int k = 0; k < 3; k++)
                    {
                        result[i,j] += firstMatrix[i,k] * secondMatrix[k,j];
                    }
                }
            }
            return result;
        }
    }

}
