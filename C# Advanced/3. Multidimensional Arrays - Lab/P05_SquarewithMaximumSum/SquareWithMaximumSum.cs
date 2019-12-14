using System;
using System.Linq;

namespace P05_SquarewithMaximumSum
{
    class SquareWithMaximumSum
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

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = currentRow[j];
                }
            }

            int sum = 0;
            int maxSum = int.MinValue;
            int maxRowIndex = 0;
            int maxColIndex = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    sum = matrix[row, col] + 
                          matrix[row, col + 1] +
                          matrix[row + 1, col] + 
                          matrix[row + 1, col + 1];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRowIndex = row;
                        maxColIndex = col;
                    }
                }
            }

            for (int i = maxRowIndex; i < maxRowIndex + 2; i++)
            {
                for (int j = maxColIndex; j < maxColIndex + 2; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
}
