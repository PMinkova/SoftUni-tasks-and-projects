using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_HouseParty
{
    class HouseParty
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            List<string> guestList = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                List<string> commands = Console.ReadLine().Split().ToList();

                bool isGoing = commands[2] == "going!";
                string name = commands[0];

                if (isGoing)
                {
                    if (guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(name);
                    }
                }
                else
                {
                    if (guestList.Contains(name))
                    {
                        guestList.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                } 
            }

            Console.WriteLine(String.Join(Environment.NewLine, guestList));
        }
    }
}
