using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace P02_StackSum
{
    class StackSum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> nums = new Stack<int>();

            foreach (var num in numbers)
            {
                nums.Push(num);
            }

            string input = Console.ReadLine().ToLower();

            while (input != "end")
            {
                string[] commandArgs = input.Split();
                string command = commandArgs[0];

                if (command == "add")
                {
                    int firstNumber = int.Parse(commandArgs[1]);
                    int secondNumber = int.Parse(commandArgs[2]);
                    AddNumbers(nums, firstNumber, secondNumber);
                }
                else if (command == "remove")
                {
                    int numbersToRemoveCount = int.Parse(commandArgs[1]);
                    RemoveNumbers(numbersToRemoveCount, nums);
                }

                input = Console.ReadLine().ToLower();
            }

            int sum = nums.Sum();
            Console.WriteLine("Sum: " + sum);
        }

        private static void RemoveNumbers(int numbersToRemoveCount, Stack<int> nums)
        {
            if (numbersToRemoveCount <= nums.Count)
            {
                for (int i = 0; i < numbersToRemoveCount; i++)
                {
                    nums.Pop();
                }
            }
        }

        private static void AddNumbers(Stack<int> nums, int firstNumber, int secondNumber)
        {
            nums.Push(firstNumber);
            nums.Push(secondNumber);
        }
    }
}
