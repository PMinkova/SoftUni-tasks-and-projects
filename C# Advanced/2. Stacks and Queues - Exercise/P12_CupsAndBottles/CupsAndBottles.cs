using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace P12_CupsAndBottles
{
    class CupsAndBottles
    {
        static void Main(string[] args)
        {
            int[] cupscapacity = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Reverse()
                .ToArray();

            int[] filledBottles = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> cups = new Stack<int>(cupscapacity); //       4   2 10 5
            Stack<int> bottles = new Stack<int>(filledBottles); //         3 15 15 11   6

            int wastedLitersOfWater = 0;

            while (true)
            {
                if (!cups.Any())
                {
                    Console.WriteLine($"Bottles: {String.Join(" ", bottles)}");
                    break;
                }
                else if (!bottles.Any())
                {
                    Console.WriteLine($"Cups: {String.Join(" ", cups)}");
                    break;
                }

                int currentBottle = bottles.Pop();
                int currentCupCapacity = cups.Pop();

                if (currentBottle >= currentCupCapacity)
                {
                    wastedLitersOfWater += currentBottle - currentCupCapacity;
                }
                else
                {
                    currentCupCapacity -= currentBottle;
                    cups.Push(currentCupCapacity);
                }
            }

            Console.WriteLine($"Wasted litters of water: {wastedLitersOfWater}");
        }
    }
}
