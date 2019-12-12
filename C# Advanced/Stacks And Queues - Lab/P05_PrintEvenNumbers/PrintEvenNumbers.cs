using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_PrintEvenNumbers
{
    class PrintEvenNumbers
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> nums = new Queue<int>(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = nums.Dequeue();

                if (currentNum % 2 == 0)
                {
                    nums.Enqueue(currentNum);
                }
            }

            List<int> evenNumbers = nums.ToList();
            Console.WriteLine(String.Join(", ", evenNumbers));
        }
    }
}
