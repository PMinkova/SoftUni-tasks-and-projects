using System;
using System.Linq;

namespace P02_SquaresInMatrix
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

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] chars = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = chars[j];
                }
            }

            int equalSquares = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    char currentChar = matrix[row, col];
                    bool areEqual = currentChar == matrix[row, col + 1] &&
                                    currentChar == matrix[row + 1, col] &&
                                    currentChar == matrix[row + 1, col + 1];

                    if (areEqual)
                    {
                        equalSquares++;
                    }
                }
            }

            Console.WriteLine(equalSquares);
        }
    }
}
