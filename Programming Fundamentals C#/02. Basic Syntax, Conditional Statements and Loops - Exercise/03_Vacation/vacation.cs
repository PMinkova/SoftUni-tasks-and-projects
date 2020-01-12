using System;

namespace _03_Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double totalPrice = 0;

            if (groupType == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    totalPrice = 8.45 * peopleCount;
                }
                else if (dayOfWeek == "Saturday")
                {
                    totalPrice = 9.80 * peopleCount;
                }
                else if (dayOfWeek == "Sunday")
                {
                    totalPrice = 10.46 * peopleCount;
                }

                if (peopleCount >= 30)
                {
                    totalPrice *= 0.85;
                }
            }
            else if (groupType == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    totalPrice = 10.90 * peopleCount;
                }
                else if (dayOfWeek == "Saturday")
                {
                    totalPrice = 15.60 * peopleCount;
                }
                else if (dayOfWeek == "Sunday")
                {
                    totalPrice = 16 * peopleCount;
                }

                if (peopleCount >= 100)
                {
                    totalPrice /= peopleCount;
                    totalPrice *= (peopleCount - 10);
                }
            }
            else if (groupType == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    totalPrice = 15 * peopleCount;
                }
                else if (dayOfWeek == "Saturday")
                {
                    totalPrice = 20 * peopleCount;
                }
                else if (dayOfWeek == "Sunday")
                {
                    totalPrice = 22.50 * peopleCount;
                }

                if (10 <= peopleCount && peopleCount <= 20)
                {
                    totalPrice *= 0.95;
                }
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
