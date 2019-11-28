using System;

namespace _08_FuelTankPart2
{
    class FuelTankPart2
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuelQuantity = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();

            double totalPrice = 0;

            if (fuelType == "Gasoline")
            {     
                if (clubCard == "Yes")
                {
                    totalPrice = fuelQuantity * (2.22 - 0.18);
                }
                else
                {
                    totalPrice = fuelQuantity * 2.22;
                }
            }
            else if (fuelType == "Diesel")
            {
                if (clubCard == "Yes")
                {
                    totalPrice = fuelQuantity * (2.33 - 0.12);
                }
                else
                {
                    totalPrice = fuelQuantity * 2.33;
                }    
            }
            else
            {
                if (clubCard == "Yes")
                {
                    totalPrice = fuelQuantity * (0.93 - 0.08);
                }
                else
                {
                    totalPrice = fuelQuantity * 0.93;
                }
            }

            if (20 <= fuelQuantity && fuelQuantity <= 25)
            {
                totalPrice *= 0.92;
            }
            else if (fuelQuantity > 25)
            {
                totalPrice *= 0.9;
            }

            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
