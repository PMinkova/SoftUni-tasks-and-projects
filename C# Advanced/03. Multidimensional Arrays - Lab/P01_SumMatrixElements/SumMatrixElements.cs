using System;
using System.Linq;

namespace P01_SumMatrixElements
{
    class SumMAtrixElements
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int rows = matrixSize[0];
            int cols = matrixSize[1];

            int[,] matrix = new int[rows,cols];

            for (int i = 0; i < rows; i++)
            {
                int[] line = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int j = 0; j < line.Length; j++)
                {
                    matrix[i, j] = line[j];
                }
            }

            int sum = 0;

            foreach (var element in matrix)
            {
                sum += element;
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}
