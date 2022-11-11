using System;
using System.Linq;

namespace _02_ShootForTheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();
            int shotTargetsCount = 0;

            while (input != "End")
            {
                int index = int.Parse(input);

                if (IsIndexValid(index, numbers))
                {
                    int currentTarget = numbers[index];
                    numbers[index] = -1;
                    shotTargetsCount++;

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        int currentNumber = numbers[i];

                        if (currentNumber != -1)
                        {
                            if (currentNumber > currentTarget)
                            {
                                numbers[i] -= currentTarget;
                            }
                            else
                            {
                                numbers[i] += currentTarget;
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {shotTargetsCount} -> {String.Join(" ", numbers)}");
        }

        public static bool IsIndexValid(int index, int[] numbers)
        {
            if (0 <= index && index < numbers.Length)
            {
                return true;
            }

            return false;
        }
    }
}
