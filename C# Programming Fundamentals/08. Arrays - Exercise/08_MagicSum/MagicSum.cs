using System;
using System.Linq;

namespace _08_MagicSum
{
    class MagicSum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int magicSum = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (currentNum + numbers[j] == magicSum)
                    {
                        Console.WriteLine(currentNum + " " + numbers[j]);
                    }
                }
            }
        }
    }
}
