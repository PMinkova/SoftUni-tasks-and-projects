using System;
using System.Linq;
using System.Collections.Generic;


namespace _02_ChangeList
{
    class ChangeList
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] commandParts = input.Split();
                string command = commandParts[0];
                int element = int.Parse(commandParts[1]);

                switch (command)
                {
                    case "Delete":
                        RemoveAllElements(numbers, element);
                        break;
                    case "Insert":
                        int position = int.Parse(commandParts[2]);
                        numbers.Insert(position, element);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", numbers));
        }

        static void RemoveAllElements(List<int> numbers, int element)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == element)
                {
                    numbers.RemoveAt(i--);
                }
            }
        }
    }
}
