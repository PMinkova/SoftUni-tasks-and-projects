using System;
using System.Linq;

namespace P05_SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            char[,] matrix = new char[rows, cols];
            string snake = Console.ReadLine();
            string fullSnakePath = String.Empty;

            int matrixSize = matrix.Length;
            int iterations = matrixSize / snake.Length;
            int rest = matrixSize % snake.Length;
            string substring = snake.Substring(0, rest);

            for (int i = 0; i < iterations; i++)
            {
                fullSnakePath += snake;
            }

            fullSnakePath += substring;

            InitializeMatrix(rows, cols, matrix, fullSnakePath);

            PrintMatrix(rows, cols, matrix);
        }

        private static void InitializeMatrix(int rows, int cols, char[,] matrix, string fullSnakePath)
        {
            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = fullSnakePath[col];
                    }
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        matrix[row, col] = fullSnakePath[cols - col - 1];
                    }
                }

                fullSnakePath = fullSnakePath.Remove(0, cols);
            }
        }

        private static void PrintMatrix(int rows, int cols, char[,] matrix)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
