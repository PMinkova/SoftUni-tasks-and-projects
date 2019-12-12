using System;
using System.Collections;
using System.Collections.Generic;

namespace P07_HotPotato
{
    class HotPotato
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int number = int.Parse(Console.ReadLine());
            int counter = 1;

            Queue<string> childrensNames = new Queue<string>(input);

            while (childrensNames.Count > 1)
            {
                string currentChild = childrensNames.Dequeue();

                if (counter % number != 0)
                {
                    childrensNames.Enqueue(currentChild);
                }
                else
                {
                    Console.WriteLine($"Removed {currentChild}");
                }

                counter++;
            }

            Console.WriteLine($"Last is {childrensNames.Peek()}");
        }
    }
}