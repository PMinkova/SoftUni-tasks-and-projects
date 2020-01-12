using System;
using System.Linq;

namespace _05_TopIntegers
{
    class TopIntegers
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i+1])
                {
                    int currentNumber = numbers[i];
                    bool isTopInteger = true;

                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        int otherNumber = numbers[j];

                        if (currentNumber < otherNumber)
                        {
                            isTopInteger = false;
                            break;
                        }
                    }

                    if (isTopInteger)
                    {
                        Console.Write(currentNumber + " ");
                    }
                }
            }

            Console.WriteLine(numbers[numbers.Length-1]);
        }
    }
}
