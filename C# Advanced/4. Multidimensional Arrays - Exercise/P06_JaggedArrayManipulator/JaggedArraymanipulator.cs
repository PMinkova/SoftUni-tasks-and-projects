using System;
using System.ComponentModel.Design;
using System.Linq;

namespace P06_JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] jaggedArr = new double[rows][];

            InitializeJaggedArray(jaggedArr);

            for (int row = 0; row < rows - 1; row++)
            {
                if (jaggedArr[row].Length == jaggedArr[row + 1].Length)
                {
                    jaggedArr[row] = jaggedArr[row].Select(x => x * 2).ToArray();
                    jaggedArr[row + 1] = jaggedArr[row + 1].Select(x => x * 2).ToArray();
                }
                else
                {
                    jaggedArr[row] = jaggedArr[row].Select(x => x / 2).ToArray();
                    jaggedArr[row + 1] = jaggedArr[row + 1].Select(x => x / 2).ToArray();
                }
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] commandArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = commandArgs[0];
                int row = int.Parse(commandArgs[1]);
                int col = int.Parse(commandArgs[2]);
                int value = int.Parse(commandArgs[3]);

                bool isIndexValid = 0 <= row && row < rows && 0 <= col && col < jaggedArr[row].Length;

                if (command == "Add" && isIndexValid)
                {
                    jaggedArr[row][col] += value;
                }
                else if (command == "Subtract" && isIndexValid)
                {
                    jaggedArr[row][col] -= value;
                }

                input = Console.ReadLine();
            }

            foreach (var row in jaggedArr)
            {
                Console.WriteLine(String.Join(" ", row));
            }
        }

        private static void InitializeJaggedArray(double[][] jaggedArr)
        {
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                double[] currentRow = Console.ReadLine()
                    .Split()
                    .Select(double.Parse).ToArray();

                jaggedArr[i] = currentRow;
            }
        }
    }
}