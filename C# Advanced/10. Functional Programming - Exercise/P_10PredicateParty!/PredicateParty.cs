using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace P10_PredicateParty_
{
    class PredicateParty
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine()
                .Split()
                .ToList();

            Func<string, int, bool> lengthFunc = (name, length) => name.Length == length;
            Func<string, string, bool> startsWithFunc = (name, param) => name.StartsWith(param);
            Func<string, string, bool> endsWithFunc = (names, param) => names.EndsWith(param);

            string input = Console.ReadLine();

            while (input != "Party!")
            {
                string[] commandArgs = input.Split();
                string command = commandArgs[0];
                string condition = commandArgs[1];
                string param = commandArgs[2];

                if (command == "Double")
                {
                    if (condition == "StartsWith")
                    {
                        var temp = names.Where(name => startsWithFunc(name, param)).ToList();
                        AddNames(temp, names);
                    }
                    else if (condition == "EndsWith")
                    {
                        var temp = names.Where(name => endsWithFunc(name, param)).ToList();
                        AddNames(temp, names);
                    }
                    else if (condition == "Length")
                    {
                        var length = int.Parse(param);
                        var temp = names.Where(name => lengthFunc(name, length)).ToList();
                        AddNames(temp, names);
                    }
                }
                else if (command == "Remove")
                {
                    if (condition == "StartsWith")
                    {
                        names = names.Where(name => !startsWithFunc(name, param)).ToList();
                        
                    }
                    else if (condition == "EndsWith")
                    {
                        names = names.Where(name => !endsWithFunc(name, param)).ToList();
                        
                    }
                    else if (condition == "Length")
                    {
                        var length = int.Parse(param);
                        names = names.Where(name => !lengthFunc(name, length)).ToList();
                    }
                }

                input = Console.ReadLine();
            }

            if (names.Count > 0)
            {
                Console.WriteLine($"{String.Join(", ", names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static void AddNames(List<string> temp, List<string> names)
        {
            foreach (var name in temp)
            {
                int index = names.IndexOf(name);
                names.Insert(index, name);
            }
        }
    }
}
