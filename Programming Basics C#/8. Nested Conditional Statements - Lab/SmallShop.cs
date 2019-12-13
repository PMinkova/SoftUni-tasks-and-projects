using System;

namespace _02_SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (product == "coffee")
            {
                if (town == "Sofia")
                {
                    Console.WriteLine(quantity * 0.50);
                }
                else if (town == "Plovdiv")
                {
                    Console.WriteLine(quantity * 0.40);
                }
                else
                {
                    Console.WriteLine(quantity * 0.45);
                }

            }
            else if (product == "water")
            {
                if (town == "Sofia")
                {
                    Console.WriteLine(quantity * 0.80);
                }
                else if (town == "Plovdiv")
                {
                    Console.WriteLine(quantity * 0.70);
                }
                else
                {
                    Console.WriteLine(quantity * 0.70);
                }

            }
            else if (product == "beer")
            {
                if (town == "Sofia")
                {
                    Console.WriteLine(quantity * 1.20);
                }
                else if (town == "Plovdiv")
                {
                    Console.WriteLine(quantity * 1.15);
                }
                else
                {
                    Console.WriteLine(quantity * 1.10);
                }

            }
            else if (product == "sweets")
            {
                if (town == "Sofia")
                {
                    Console.WriteLine(quantity * 1.45);
                }
                else if (town == "Plovdiv")
                {
                    Console.WriteLine(quantity * 1.30);
                }
                else
                {
                    Console.WriteLine(quantity * 1.35);
                }

            }
            else 
            {
                if (town == "Sofia")
                {
                    Console.WriteLine(quantity * 1.60);
                }
                else if (town == "Plovdiv")
                {
                    Console.WriteLine(quantity * 1.50);
                }
                else
                {
                    Console.WriteLine(quantity * 1.55);
                }

            }
        }
    }
}
