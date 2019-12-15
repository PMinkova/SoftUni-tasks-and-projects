using System;
using System.Linq;

namespace P04_MatrixShuffling
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

            string[,] matrix = new string[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] currentRow = Console.ReadLine().Split();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = currentRow[j];
                }
            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] commandArgs = input.Split();

                if (commandArgs.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    input = Console.ReadLine();
                    continue;
                }

                string command = commandArgs[0];
                int row1 = int.Parse(commandArgs[1]);
                int col1 = int.Parse(commandArgs[2]);
                int row2 = int.Parse(commandArgs[3]);
                int col2 = int.Parse(commandArgs[4]);

                bool isCommandValid = command == "swap" &&
                                      0 <= row1 && row1 < rows &&
                                      0 <= row2 && row2 < rows &&
                                      0 <= col1 && col1 < cols &&
                                      0 <= col2 && col2 < cols;

                if (isCommandValid)
                {
                    string temp = matrix[row1, col1];
                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = temp;

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }

                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                input = Console.ReadLine();
            }
        }
    }
}
