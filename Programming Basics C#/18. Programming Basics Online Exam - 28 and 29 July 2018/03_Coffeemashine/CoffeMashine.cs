using System;

namespace _3
{
    class CoffeMashine
    {
        static void Main(string[] args)
        {
            string beverageType = Console.ReadLine();
            string sugar = Console.ReadLine();
            int beverageCount = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            if (beverageType == "Espresso")
            {
                if (sugar == "Without")
                {
                    totalPrice = beverageCount * 0.90 * 0.65;
                }
                else if (sugar == "Normal")
                {
                    totalPrice = beverageCount * 1;
                }
                else if (sugar == "Extra")
                {
                    totalPrice = beverageCount * 1.20;
                }
                if (beverageCount >= 5)
                {
                    totalPrice *= 0.75;
                }
            }
            else if (beverageType == "Cappuccino")
            {
                if (sugar == "Without")
                {
                    totalPrice = beverageCount * 1 * 0.65;
                }
                else if (sugar == "Normal")
                {
                    totalPrice = beverageCount * 1.20;
                }
                else if (sugar == "Extra")
                {
                    totalPrice = beverageCount * 1.60;
                }          
            }
            else if (beverageType == "Tea")
            {
                if (sugar == "Without")
                {
                    totalPrice = beverageCount * 0.50 * 0.65;
                }
                else if (sugar == "Normal")
                {
                    totalPrice = beverageCount * 0.60;
                }
                else if (sugar == "Extra")
                {
                    totalPrice = beverageCount * 0.70;
                }
            }

            if (totalPrice > 15)
            {
                totalPrice *= 0.80;
            }

            Console.WriteLine($"You bought {beverageCount} cups of {beverageType} for {totalPrice:f2} lv.");
        }
    }
}
