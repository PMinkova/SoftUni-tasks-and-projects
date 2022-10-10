using System;
using System.Linq;

namespace _02_TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int waitingPeople = int.Parse(Console.ReadLine());

            int[] currentStateOfTheLift = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int cabinsCount = currentStateOfTheLift.Length;
            int capacity = 4;
            bool hasMoreEmptySpots = false;

            for (int i = 0; i < cabinsCount; i++)
            {
                int currentCount = currentStateOfTheLift[i];

                if (currentCount <= capacity)
                {
                    int emptySpots = capacity - currentCount;

                    if (emptySpots > waitingPeople)
                    {
                        currentStateOfTheLift[i] += waitingPeople;
                        waitingPeople = 0;
                        hasMoreEmptySpots = true;
                        break;
                    }
                    else
                    {
                        currentStateOfTheLift[i] += emptySpots;
                        waitingPeople -= emptySpots;
                    }
                }
            }

            if (hasMoreEmptySpots)
            {
                Console.WriteLine("The lift has empty spots!");
            }

            if (waitingPeople > 0)
            {
                Console.WriteLine($"There isn't enough space! {waitingPeople} people in a queue!");
            }

            Console.WriteLine(String.Join(" ", currentStateOfTheLift));
        }
    }
}
