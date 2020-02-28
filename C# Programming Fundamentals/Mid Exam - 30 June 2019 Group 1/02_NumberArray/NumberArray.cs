using System;
using System.Linq;

namespace _02_NumberArray
{
    class NumberArray
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] commandParts = input.Split();
                string command = commandParts[0];
                int index = 0;
                int sum = 0;

                if (command == "Switch")
                {
                    index = int.Parse(commandParts[1]);
                    bool isValidIndex = CheckIsIndexValid(numbers, index);
                    
                    if (isValidIndex)
                    {
                        int number = numbers[index];

                        numbers[index] = -number;
                    }
                }
                else if (command == "Change")
                {
                    index = int.Parse(commandParts[1]);
                    bool isValidIndex = CheckIsIndexValid(numbers, index);
                   
                    if (isValidIndex)
                    {
                        int number = int.Parse(commandParts[2]);
                        numbers[index] = number;
                    }
                }
                else if (command == "Sum" && commandParts[1] == "Negative")
                {
                    sum = numbers.Where(x => x < 0).Sum();
                    Console.WriteLine(sum);
                }
                else if (command == "Sum" && commandParts[1] == "Positive")
                {
                    sum = numbers.Where(x => x > 0).Sum();
                    Console.WriteLine(sum);
                }
                else if (command == "Sum" && commandParts[1] == "All")
                {
                    sum = numbers.Sum();
                    Console.WriteLine(sum);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", numbers.Where(x => x >= 0)));
        }

        static bool CheckIsIndexValid(int[] numbers, int index)
        {
            if (0 <= index && index < numbers.Length)
            {
                return true;
            }
            return false;
        }
    }
}
