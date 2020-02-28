using System;

namespace _01_ChristmasSpirit
{
    class ChristmasSpirit
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int ornamentSetPrice = 2;
            int treeSkirt = 5;
            int treeGarlands = 3;
            int treeLights = 15;

            int totalPrice = 0;
            int christmasSpirit = 0;

            for (int i = 1; i <= days; i++)
            {
                if (i % 11 == 0)
                {
                    quantity += 2;
                } 

                if (i % 2 == 0)
                {
                    totalPrice += ornamentSetPrice * quantity;
                    christmasSpirit += 5;
                }

                if (i % 3 == 0)
                {
                    totalPrice += quantity * (treeSkirt + treeGarlands);
                    christmasSpirit += 13;
                }

                if (i % 5 == 0)
                {
                    totalPrice += quantity * treeLights;
                    christmasSpirit += 17;
                }

                if (i % 3 == 0 && i % 5 == 0)
                {
                    christmasSpirit += 30;
                }

                if (i % 10 == 0)
                {
                    christmasSpirit -= 20;
                    totalPrice += treeLights + treeSkirt + treeGarlands; // towa move i da ne vliza
                }

                if (i % 10 == 0 && i == days)
                {
                    christmasSpirit -= 30;
                }

            }

            Console.WriteLine($"Total cost: {totalPrice}");
            Console.WriteLine($"Total spirit: {christmasSpirit}");
        }
    }
}
