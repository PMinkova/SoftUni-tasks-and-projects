using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_FastFood
{
    class FastFood
    {
        static void Main(string[] args)
        {
            int mealsCount = int.Parse(Console.ReadLine());

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> orders = new Queue<int>(numbers);

            Console.WriteLine(orders.Max());

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentOrder = orders.Peek();

                if (mealsCount >= currentOrder)
                {
                    orders.Dequeue();
                    mealsCount -= currentOrder;
                }
            }

            if (orders.Any())
            {
                Console.WriteLine("Orders left: " + String.Join(" ", orders));
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
