using System;

namespace _04_TransportPrice
{
    class TransportPrice
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string tariff = Console.ReadLine();

            double priceWithTaxy = 0.7;
            double minimalPrice = 128712717;
            double priceWithTrain = 0.06 * n;
            double priceWithBus = 0.09 * n;

            if (tariff == "night")
            {
                priceWithTaxy += 0.90 * n;
            }
            else
            {
                priceWithTaxy += 0.79 * n;
            }

            if (priceWithTaxy < minimalPrice)
            {
                minimalPrice = priceWithTaxy;
            }

            if (n >= 20 && priceWithBus < minimalPrice)
            {
                    minimalPrice = priceWithBus;
            }

            if (n >= 100 && priceWithTrain < minimalPrice)
            {
                    minimalPrice = priceWithTrain;
            }

            Console.WriteLine($"{minimalPrice:f2}");
        }
    }
}
