using System;
using System.Linq;

namespace P03_MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            int[,] matrix = new int[rows,cols];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = currentRow[j];
                }
            }

            int maxSum = 0;
            int maxRowIndex = 0;
            int maxColIndex = 0;

            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    int sum = matrix[row, col] +
                              matrix[row, col + 1] +
                              matrix[row, col + 2] +
                              matrix[row + 1, col] +
                              matrix[row + 1, col + 1] +
                              matrix[row + 1, col + 2] +
                              matrix[row + 2, col] +
                              matrix[row + 2, col + 1] +
                              matrix[row + 2, col + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRowIndex = row;
                        maxColIndex = col;
                    }
                }
            }

            Console.WriteLine("Sum = " + maxSum);

            for (int i = maxRowIndex; i < maxRowIndex + 3; i++)
            {
                for (int j = maxColIndex; j < maxColIndex + 3; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
