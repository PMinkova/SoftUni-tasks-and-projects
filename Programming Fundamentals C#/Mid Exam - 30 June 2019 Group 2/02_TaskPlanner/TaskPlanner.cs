using System;
using System.Linq;


namespace _02_TaskPlanner
{
    class TaskPlanner
    {
        static void Main(string[] args)
        {
            int[] hours = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] commandParts = input.Split();
                string command = commandParts[0];
                int index = 0;
                int arrayLength = hours.Length;

                if (command == "Complete")
                {
                    index = int.Parse(commandParts[1]);
                    bool isIndexValid = ChechTheValidityOfTheIndex(arrayLength, index);

                    if (isIndexValid)
                    {
                        hours[index] = 0;
                    }
                }
                else if (command == "Change")
                {
                    index = int.Parse(commandParts[1]);
                    int time = int.Parse(commandParts[2]);
                    bool isValidIndex = ChechTheValidityOfTheIndex(arrayLength, index);

                    if (isValidIndex)
                    {
                        hours[index] = time;
                    }
                }
                else if (command == "Drop")
                {
                    index = int.Parse(commandParts[1]);
                    bool isValidIndex = ChechTheValidityOfTheIndex(arrayLength, index);

                    if (isValidIndex)
                    {
                        hours[index] = -1;
                    }
                }
                else if (command == "Count" && commandParts[1] == "Completed")
                {
                    PrintTheCountOfCompletedTasks(hours);
                }
                else if (command == "Count" && commandParts[1] == "Incomplete")
                {
                    PrintTheCountOfIncompletedTasks(hours);
                }
                else if (command == "Count" && commandParts[1] == "Dropped")
                {
                    PrintTheNumberOfDroppedTasks(hours);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", hours.Where(x => x > 0)));
        }

        private static void PrintTheNumberOfDroppedTasks(int[] hours)
        {
            int countOfDroppedTasks = 0;

            for (int i = 0; i < hours.Length; i++)
            {
                if (hours[i] < 0)
                {
                    countOfDroppedTasks++;
                }
            }

            Console.WriteLine(countOfDroppedTasks);
        }

        private static void PrintTheCountOfIncompletedTasks(int[] array)
        {
            int countOfIncommpletedTasks = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    countOfIncommpletedTasks++;
                }
            }

            Console.WriteLine(countOfIncommpletedTasks);
        }

        static void PrintTheCountOfCompletedTasks(int[] array)
        {
            int countOfCompletedTasks = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    countOfCompletedTasks++;
                }
            }

            Console.WriteLine(countOfCompletedTasks);
        }

        static bool ChechTheValidityOfTheIndex(int arrayLength, int index)
        {
            if (0 <= index && index < arrayLength)
            {
                return true;
            }

            return false;
        }
    }
}
