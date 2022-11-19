using System.Collections.Generic;
using System.Linq;

namespace PlayCatch
{
    using System;

    public class Program
    {
        static void Main()
        {
            var elements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var exceptionsCounter = 0;

            while (exceptionsCounter < 3)
            {

                var commandArguments = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var command = commandArguments[0];

                try
                {
                    if (command == "Replace")
                    {
                        var index = int.Parse(commandArguments[1]);
                        var elementToReplace = int.Parse(commandArguments[2]);

                        ReplaceElement(index, elementToReplace, elements);
                    }
                    else if (command == "Show")
                    {
                        var index = int.Parse(commandArguments[1]);
                        Console.WriteLine(elements[index]);
                    }
                    else if (command == "Print")
                    {
                        var startIndex = int.Parse(commandArguments[1]);
                        var endIndex = int.Parse(commandArguments[2]);

                        PrintElements(startIndex, endIndex, elements);
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("The index does not exist!");
                    exceptionsCounter++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    exceptionsCounter++;
                }
            }

            Console.WriteLine(String.Join(", ", elements));
        }

        private static void ReplaceElement(int index, int elementToReplace, int[] elements)
        {
            elements[index] = elementToReplace;
        }

        private static void PrintElements(int startIndex, int endIndex, int[] elements)
        {
            var elementsToPrint = new List<int>();

            for (int i = startIndex; i <= endIndex; i++)
            {
                elementsToPrint.Add(elements[i]);
            }

            Console.WriteLine(String.Join(", ", elementsToPrint));
        }
    }
}
