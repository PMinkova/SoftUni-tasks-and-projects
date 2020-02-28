using System;
using System.Linq;
using System.Collections.Generic;

namespace _03_TanksCollector
{
    class TanksCollector
    {
        static void Main(string[] args)
        {
            List<string> tanks = Console.ReadLine().Split(", ").ToList();
            int commandsCount = int.Parse(Console.ReadLine());


            for (int i = 0; i < commandsCount; i++)
            {
                string[] commandParts = Console.ReadLine().Split(", ");
                string tankName = String.Empty;
                int index = 0;

                string command = commandParts[0];

                if (command == "Add")
                {
                    tankName = commandParts[1];

                    if (tanks.Contains(tankName))
                    {
                        Console.WriteLine("Tank is already bought");
                    }
                    else
                    {
                        Console.WriteLine("Tank successfully bought");
                        tanks.Add(tankName);
                    }
                }
                else if (command == "Remove")
                {
                    tankName = commandParts[1];

                    if (tanks.Contains(tankName))
                    {
                        Console.WriteLine("Tank successfully sold");
                        tanks.Remove(tankName);
                    }
                    else
                    {
                        Console.WriteLine("Tank not found");
                    }
                }
                else if (command == "Remove At")
                {
                    index = int.Parse(commandParts[1]);

                    if (0 <= index && index < tanks.Count)
                    {
                        tanks.RemoveAt(index);
                        Console.WriteLine("Tank successfully sold");
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
                else if (command == "Insert")
                {
                    index = int.Parse(commandParts[1]);
                    tankName = commandParts[2];
                    bool isIndexValid = 0 <= index && index <= tanks.Count;

                    if (isIndexValid && tanks.Contains(tankName))
                    {
                        Console.WriteLine("Tank is already bought");
                    }
                    else if (isIndexValid && !tanks.Contains(tankName))
                    {
                        Console.WriteLine("Tank successfully bought");
                        tanks.Insert(index, tankName);
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
            }

            Console.WriteLine(String.Join(", ", tanks));
        }
    }
}
