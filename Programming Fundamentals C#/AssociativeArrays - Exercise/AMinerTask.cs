using System;
using System.Collections.Generic;

namespace _02_AMinerTask
{
    class AMinerTask
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var resources = new Dictionary<string, int>();

            while (input != "stop")
            {
                string resource = input;
                int quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resource))
                {
                    resources[resource] = 0;
                }

                resources[resource] += quantity;

                input = Console.ReadLine();
            }

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
