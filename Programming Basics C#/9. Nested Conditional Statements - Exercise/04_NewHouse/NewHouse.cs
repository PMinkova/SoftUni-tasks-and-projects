using System;

namespace _04_NewHouse
{
    class NewHouse
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int flowerNumbers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double amount = 0;
        

            if (flowers == "Roses")
            {
                amount = flowerNumbers * 5;

                if (flowerNumbers > 80)
                {
                    amount *= 0.9;
                }
            }
            else if (flowers == "Dahlias")
            {
                amount = flowerNumbers * 3.80;

                if (flowerNumbers > 90)
                {
                    amount *= 0.85;
                }
            }
            else if (flowers == "Tulips")
            {
                amount = flowerNumbers * 2.80;

                if (flowerNumbers > 80)
                {
                    amount *= 0.85;
                }
            }
            else if (flowers == "Narcissus")
            {
                amount = flowerNumbers * 3;

                if (flowerNumbers < 120)
                {
                    amount *= 1.15;
                }
            }
            else if (flowers == "Gladiolus")
            {
                amount = flowerNumbers * 2.50;

                if (flowerNumbers < 80)
                {
                    amount *= 1.20;
                }
            }

            if (budget - amount >= 0)
            { 
            Console.WriteLine($"Hey, you have a great garden with {flowerNumbers} {flowers} and {Math.Abs(budget - amount):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(budget - amount):F2} leva more.");
            }
        }
    }
}
