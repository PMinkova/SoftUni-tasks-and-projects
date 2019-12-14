using System;
using System.Linq;

namespace P02_SumMatrixColumns
{
    class SumMatrixColumns
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int rows = matrixSize[0];
            int cols = matrixSize[1];

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] elements = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < elements.Length; j++)
                {
                    matrix[i, j] = elements[j];
                }
            }


            for (int i = 0; i < cols; i++)
            {
                int sum = 0;

                for (int j = 0; j < rows; j++)
                {
                    sum += matrix[j, i];
                }

                Console.WriteLine(sum);
            }
        }
    }
}
