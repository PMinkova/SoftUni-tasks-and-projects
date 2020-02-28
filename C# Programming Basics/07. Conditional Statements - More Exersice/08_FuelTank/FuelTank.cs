using System;

namespace _08_FuelTank
{
    class FuelTank
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            int litersAvailable = int.Parse(Console.ReadLine());

            if (fuelType == "Diesel")
            {
                if (litersAvailable < 25)
                {
                    Console.WriteLine("Fill your tank with diesel!");
                }
                else 
                {
                    Console.WriteLine($"You have enough diesel.");
                }
            }
            else if (fuelType == "Gasoline")
            {
                if (litersAvailable < 25)
                {
                    Console.WriteLine("Fill your tank with gasoline!");
                }
                else
                {
                    Console.WriteLine($"You have enough gasoline.");
                }
            }
            else if (fuelType == "Gas")
            {
                if (litersAvailable < 25)
                {
                    Console.WriteLine("Fill your tank with gas!");
                }
                else
                {
                    Console.WriteLine($"You have enough gas.");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
