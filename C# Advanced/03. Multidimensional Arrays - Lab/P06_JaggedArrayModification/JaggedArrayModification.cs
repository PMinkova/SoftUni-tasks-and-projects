using System;
using System.Linq;

namespace P06_JaggedArrayModification
{
    class JaggedArrayModification
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jagged = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                int[] elements = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                jagged[i] = elements;
            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] commandArgs = input.Split();

                string command = commandArgs[0];
                int row = int.Parse(commandArgs[1]);
                int col = int.Parse(commandArgs[2]);
                int value = int.Parse(commandArgs[3]);

                if (row < 0 || row >= jagged.Length || col < 0 || col >= jagged[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    input = Console.ReadLine();
                    continue;
                }

                if (command == "Add")
                {
                    jagged[row][col] += value;
                }
                else if (command == "Subtract")
                {
                    jagged[row][col] -= value;
                }

                input = Console.ReadLine();
            }


            foreach (var row in jagged)
            {
                Console.WriteLine(String.Join(" ", row));
            }
        }
    }
}
