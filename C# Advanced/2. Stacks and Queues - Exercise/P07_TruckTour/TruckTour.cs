using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_TruckTour
{
    class TruckTour
    {
        static void Main(string[] args)
        {
            int pumpsCount = int.Parse(Console.ReadLine());

            Queue<int> difference = new Queue<int>();

            for (int i = 0; i < pumpsCount; i++)
            {
                string[] pumpsInformation = Console.ReadLine().Split();

                int amountOfPetrol = int.Parse(pumpsInformation[0]);
                int distanceBetweenPumps = int.Parse(pumpsInformation[1]);

                int diff = amountOfPetrol - distanceBetweenPumps;

                difference.Enqueue(diff);
            }

            int indexCounter = 0;

            while (true)
            {
                int fuel = -1;
                Queue<int> copyDifference = new Queue<int>(difference);

                while (copyDifference.Any())
                {
                    if (copyDifference.Peek() >= 0 && fuel == -1)
                    {
                        fuel = copyDifference.Dequeue();
                        difference.Enqueue(difference.Dequeue());
                    }
                    else if (copyDifference.Peek() < 0 && fuel == -1)
                    {
                        copyDifference.Enqueue(copyDifference.Dequeue());
                        difference.Enqueue(difference.Dequeue());
                        indexCounter++;
                    }
                    else
                    {
                        fuel += copyDifference.Dequeue();

                        if (fuel < 0)
                        {
                            break;
                        }
                    }
                }

                if (fuel >= 0)
                {
                    Console.WriteLine(indexCounter);
                    return;
                }

                indexCounter++;
            }
        }
    }
}

