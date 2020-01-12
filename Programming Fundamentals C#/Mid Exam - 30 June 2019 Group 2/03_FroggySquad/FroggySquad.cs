using System;
using System.Linq;
using System.Collections.Generic;

namespace _03_FroggySquad
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> frogs = Console.ReadLine().Split().ToList();

            string input = Console.ReadLine();
            string name = String.Empty;
            int index = 0;

            while (true)
            {
                string[] commandParts = input.Split();
                string command = commandParts[0];

                if (command == "Join")
                {
                    name = commandParts[1];
                    frogs.Add(name);
                }
                else if (command == "Jump")
                {
                    name = commandParts[1];
                    index = int.Parse(commandParts[2]);

                    if (0 <= index && index <= frogs.Count)
                    {
                        frogs.Insert(index, name);
                    }
                }
                else if (command == "Dive")
                {
                    index = int.Parse(commandParts[1]);

                    if (0 <= index && index < frogs.Count)
                    {
                        frogs.RemoveAt(index);
                    }
                }
                else if (command == "First")
                {
                    int count = int.Parse(commandParts[1]);

                    if (count > frogs.Count)
                    {
                        count = frogs.Count;
                    }

                    Console.WriteLine(String.Join(" ", frogs.Take(count)));
                }
                else if (command == "Last")
                {
                    int count = int.Parse(commandParts[1]);

                    if (count > frogs.Count)
                    {
                        count = frogs.Count;
                    }
                    int skipCount = frogs.Count - count;

                    Console.WriteLine(String.Join(" ", frogs.Skip(skipCount)));
                }
                else if (command == "Print" && commandParts[1] == "Normal")
                {
                    break;
                }
                else if (command == "Print" && commandParts[1] == "Reversed")
                {
                    frogs.Reverse();
                    break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Frogs: {String.Join(" ", frogs)}");
        }
    }
}
