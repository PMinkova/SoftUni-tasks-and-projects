using System;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().
                 Split()
                 .Select(int.Parse)
                 .ToArray();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandParts = command.Split();

                if (commandParts[0] == "exchange")
                {
                    GetExchangedArray(array, commandParts);
                }
                else if (commandParts[0] == "max")
                {
                    switch (commandParts[1])
                    {
                        case "even":
                            PrintMaxEven(array);
                            break;
                        case "odd":
                            PrintMaxOdd(array);
                            break;
                    }
                }
                else if (commandParts[0] == "min")
                {
                    switch (commandParts[1])
                    {
                        case "even":
                            PrintMinEven(array);
                            break;
                        case "odd":
                            PrintMinOdd(array);
                            break;
                    }
                }



                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(", ", array));
        }

        static void GetExchangedArray(int[] arr, string[] array)
        {
            int rotations = int.Parse(array[1]);

            if (rotations >= arr.Length || rotations < 0)
            {
                Console.WriteLine("Invalid index");
                return;
            }

            for (int i = 0; i < rotations; i++)
            {
                int first = arr[0];

                for (int j = 0; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }

                arr[arr.Length - 1] = first;
            }
        }

        static void PrintMaxEven(int[] arr)
        {
            int maxElement = int.MinValue;
            int maxIndex = arr.Length;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && arr[i] >= maxElement)
                {
                    maxElement = arr[i];
                    maxIndex = i;
                }
            }

            if (maxIndex == arr.Length)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxIndex);
            }
        }
        static void PrintMaxOdd(int[] arr)
        {
            int maxElement = int.MinValue;
            int maxIndex = arr.Length;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0 && arr[i] >= maxElement)
                {
                    maxElement = arr[i];
                    maxIndex = i;
                }
            }

            if (maxIndex == arr.Length)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxIndex);
            }
        }

        static void PrintMinEven(int[] arr)
        {
            int minElement = int.MaxValue;
            int minIndex = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && arr[i] <= minElement)
                {
                    minElement = arr[i];
                    minIndex = i;
                }
            }
            if (minIndex == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(minIndex);
            }
        }

        static void PrintMinOdd(int[] arr)
        {
            int minElement = int.MaxValue;
            int minIndex = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0 && arr[i] <= minElement)
                {
                    minElement = arr[i];
                    minIndex = i;
                }
            }
            if (minIndex == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(minIndex);
            }
        }
    }
}
