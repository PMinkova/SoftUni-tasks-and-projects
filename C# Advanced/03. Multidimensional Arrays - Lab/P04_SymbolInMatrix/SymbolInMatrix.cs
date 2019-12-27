using System;
using System.Linq;

namespace P04_SymbolInMatrix
{
    class SymbolInMatrix
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            char[,] matrix = new char[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                string currentRow = Console.ReadLine();

                for (int j = 0; j < matrixSize; j++)
                {
                    matrix[i, j] = currentRow[j];
                }
            }

            char symbol = char.Parse(Console.ReadLine());
            bool isFound = false;

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    if (matrix[i,j] == symbol)
                    {
                        Console.WriteLine($"({i}, {j})");
                        isFound = true;
                        break;
                    }
                }

                if (isFound)
                {
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
