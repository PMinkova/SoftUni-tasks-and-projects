using System;
using System.Linq;

namespace P03_PrimaryDiagonal
{
    class PrimaryDiagonal
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < currentRow.Length; j++)
                {
                    matrix[i, j] = currentRow[j];
                }
            }

            int diagonalSum = 0;

            for (int i = 0; i < matrixSize; i++)
            {
                diagonalSum += matrix[i, i];
            }

            Console.WriteLine(diagonalSum);
        }
    }
}
