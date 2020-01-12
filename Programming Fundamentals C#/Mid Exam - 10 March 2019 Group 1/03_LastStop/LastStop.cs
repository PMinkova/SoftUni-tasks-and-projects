using System;
using System.Linq;
using System.Collections.Generic;

namespace MidExam_10._03._19Group2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> paintingNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] commandParts = input.Split();

                string command = commandParts[0];

                if (command == "Change")
                {
                    int firstNumber = int.Parse(commandParts[1]);
                    int secondNumber = int.Parse(commandParts[2]);

                    if (paintingNumbers.Contains(firstNumber))
                    {
                        int indexOfFirstNumber = paintingNumbers.IndexOf(firstNumber);
                        paintingNumbers.Insert(indexOfFirstNumber, secondNumber);
                        paintingNumbers.Remove(firstNumber);
                    }

                }
                else if (command == "Hide")
                {
                    int paintingNumberToRemove = int.Parse(commandParts[1]);

                    if (paintingNumbers.Contains(paintingNumberToRemove))
                    {
                        paintingNumbers.Remove(paintingNumberToRemove);
                    }
                }
                else if (command == "Switch")
                {
                    int firstPaint = int.Parse(commandParts[1]);
                    int secondPaint = int.Parse(commandParts[2]);

                    if (paintingNumbers.Contains(firstPaint) && paintingNumbers.Contains(secondPaint))
                    {
                        int firstIndex = paintingNumbers.IndexOf(firstPaint);
                        int secondIndex = paintingNumbers.IndexOf(secondPaint);

                        paintingNumbers.Remove(firstPaint);
                        paintingNumbers.Insert(secondIndex, firstPaint);
                        paintingNumbers.Remove(secondPaint);
                        paintingNumbers.Insert(firstIndex, secondPaint);
                    }
                }
                else if (command == "Insert")
                {
                    int indexToInsertAt = int.Parse(commandParts[1]) + 1;
                    int paintingNumberToInsert = int.Parse(commandParts[2]);

                    if (0 <= indexToInsertAt && indexToInsertAt <= paintingNumbers.Count)
                    {
                        paintingNumbers.Insert(indexToInsertAt, paintingNumberToInsert);
                    }
                }
                else if (command == "Reverse")
                {
                    paintingNumbers.Reverse();
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", paintingNumbers));
        }
    }
}
