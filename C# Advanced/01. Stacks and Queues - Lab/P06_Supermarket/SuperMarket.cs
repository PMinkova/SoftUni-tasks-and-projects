using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_SuperMarket
{
    class Supermarket
    {
        static void Main(string[] args)
        {
            Queue<string> customers = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    Console.Write($"{customers.Count} people remaining.");
                    break;
                }
                else if (input == "Paid")
                {
                    while (customers.Any())
                    {
                        Console.WriteLine(customers.Dequeue());
                    }
                }
                else
                {
                    customers.Enqueue(input);
                }
            }

        }
    }
}
