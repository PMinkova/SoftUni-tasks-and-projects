using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_OnTheWayToAnnapurna
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> stores = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] commandArgs = input.Split("->");
                string command = commandArgs[0];
                string store = commandArgs[1];

                switch (command)
                {
                    case "Add":
                        AddStore(stores, store, commandArgs);
                        break;
                    case "Remove":
                        RemoveStore(stores, store);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Stores list:");

            foreach (var store in stores.OrderByDescending(x => x.Value.Count).ThenByDescending(x => x.Key))
            {
                List<string> items = store.Value;
                Console.WriteLine(store.Key);
                items.ForEach(x => Console.WriteLine($"<<{x}>>"));
            }
        }

        private static void RemoveStore(Dictionary<string, List<string>> stores, string store)
        {
            if (stores.ContainsKey(store))
            {
                stores.Remove(store);
            }
        }

        private static void AddStore(Dictionary<string, List<string>> stores, string store, string[] commandArgs)
        {
            string[] items = commandArgs[2].Split(",");

            if (!stores.ContainsKey(store))
            {
                stores.Add(store, new List<string>());
            }

            for (int i = 0; i < items.Length; i++)
            {
                string currentItem = items[i];
                stores[store].Add(currentItem);
            }
        }
    }
}
