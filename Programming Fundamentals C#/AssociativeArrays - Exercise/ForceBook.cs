using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var forceBook = new Dictionary<string, List<string>>();

            while (input != "Lumpawaroo")
            {
                string side = "";
                string user = ""; 

                if (input.Contains('|'))
                {
                    string[] data = input.Split(" | ");
                    side = data[0];
                    user = data[1];

                    if (!forceBook.ContainsKey(side))
                    {
                        forceBook.Add(side, new List<string>());
                    }

                    bool memberExists = false;

                    foreach (var kvp in forceBook)
                    {
                        if (kvp.Value.Contains(user))
                        {
                            memberExists = true;
                        }
                    }

                    if (!forceBook[side].Contains(user) && !memberExists)
                    {
                        forceBook[side].Add(user);
                    }
                }
                else
                {
                    string[] data = input.Split(" -> ");

                    side = data[1];
                    user = data[0];

                    foreach (var s in forceBook)
                    {
                        if (s.Value.Contains(user))
                        {
                            s.Value.Remove(user);
                            break;
                        }
                    }

                    if (!forceBook.ContainsKey(side))
                    {
                        forceBook.Add(side, new List<string>());
                    }

                    forceBook[side].Add(user);

                    Console.WriteLine($"{user} joins the {side} side!");
                }
                    input = Console.ReadLine();
            }

            var orderedForceBook = forceBook
                .OrderByDescending(s => s.Value.Count)
                .ThenBy(s => s.Key)
                .ToDictionary(s => s.Key, s => s.Value);

            foreach (var s in orderedForceBook.Where(s => s.Value.Count > 0))
            {
                Console.WriteLine($"Side: {s.Key}, Members: {s.Value.Count}");
                s.Value.Sort();
                s.Value.ForEach(u => Console.WriteLine($"! {u}"));
            }
        }
    }
}
