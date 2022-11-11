using System;
using System.Data;

namespace _01_Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            int wonBattlesCount = 0;

            while (input != "End of battle")
            {
                int distance = int.Parse(input);

                if (energy - distance >= 0)
                {
                    energy -= distance;
                    wonBattlesCount++;
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattlesCount} won battles and {energy} energy");
                    break;
                }

                if (wonBattlesCount % 3 == 0)
                {
                    energy += wonBattlesCount;
                }
                
                input = Console.ReadLine();
            }

            if (input == "End of battle")
            {
                Console.WriteLine($"Won battles: {wonBattlesCount}. Energy left: {energy} ");   
            }
        }
    }
}
