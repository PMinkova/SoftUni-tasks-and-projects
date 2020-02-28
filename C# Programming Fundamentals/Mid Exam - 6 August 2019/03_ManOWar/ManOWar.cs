using System;
using System.Linq;
using System.Collections.Generic;

namespace _03_ManOWar
{
    class ManOWar
    {
        static void Main(string[] args)
        {
            List<int> piratShip = Console.ReadLine()
                .Split(">")
                .Select(int.Parse)
                .ToList();
            List<int> warShip = Console.ReadLine()
                .Split(">")
                .Select(int.Parse)
                .ToList();

            int healthCapacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            bool enemyWasSinken = false;
            bool piratShipWasSinken = false;

            while (input != "Retire")
            {
                string[] commandParts = input.Split();

                string command = commandParts[0];

                if (command == "Fire")
                {
                    int index = int.Parse(commandParts[1]);
                    int damage = int.Parse(commandParts[2]);

                    if (0 <= index && index < warShip.Count)
                    {
                        warShip[index] -= damage;

                        if (warShip[index] <= 0)
                        {
                            enemyWasSinken = true;
                            break;
                        }
                    }
                }
                else if (command == "Defend")
                {
                    int startIndex = int.Parse(commandParts[1]);
                    int endIndex = int.Parse(commandParts[2]);
                    int damage = int.Parse(commandParts[3]);

                    if (0 <= startIndex && startIndex < piratShip.Count && startIndex < endIndex && endIndex < piratShip.Count)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            piratShip[i] -= damage;

                            if (piratShip[i] <= 0)
                            {
                                piratShipWasSinken = true;
                                break;
                            }
                        }
                    }
                }
                else if (command == "Repair")
                {
                    int index = int.Parse(commandParts[1]);
                    int health = int.Parse(commandParts[2]);

                    if (0 <= index && index < piratShip.Count)
                    {
                        piratShip[index] += health;

                        if (piratShip[index] > healthCapacity)
                        {
                            piratShip[index] = healthCapacity;
                        }
                    }
                }
                else if (command == "Status")
                {
                    int secktionForRepairValue = (int)(0.2 * healthCapacity);
                    int counter = 0;

                    for (int i = 0; i < piratShip.Count; i++)
                    {

                        if (piratShip[i] < secktionForRepairValue)
                        {
                            counter++;
                        }
                    }

                    Console.WriteLine($"{counter} sections need repair.");
                }

                input = Console.ReadLine();
            }
            if (enemyWasSinken)
            {
                Console.WriteLine("You won! The enemy ship has sunken.");
            }
            else if (piratShipWasSinken)
            {
                Console.WriteLine("You lost! The pirate ship has sunken.");
            }
            else
            {
                Console.WriteLine($"Pirate ship status: {piratShip.Sum()}");
                Console.WriteLine($"Warship status: {warShip.Sum()}");
            }
        }
    }
}
