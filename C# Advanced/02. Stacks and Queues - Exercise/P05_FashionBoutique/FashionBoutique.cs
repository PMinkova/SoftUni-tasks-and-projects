using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_FashionBoutique
{
    class FashionBoutique
    {
        static void Main(string[] args)
        {
            int[] clothesCount = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rackCapacity = int.Parse(Console.ReadLine());
            int emptyRackCapacity = rackCapacity;

            Stack<int> clothes = new Stack<int>(clothesCount);
            int racksCount = 1;

            while (clothes.Any())
            {
                int currentClothesCount = clothes.Peek();

                if (rackCapacity >= currentClothesCount)
                {
                    clothes.Pop();
                    rackCapacity -= currentClothesCount;
                }
                else
                {
                    rackCapacity = emptyRackCapacity;
                    racksCount++;
                }
            }

            Console.WriteLine(racksCount);
        }
    }
}
