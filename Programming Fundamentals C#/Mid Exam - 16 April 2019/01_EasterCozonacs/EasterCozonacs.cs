using System;

namespace _01_EasterCozonacs
{
    class EasterCozonacs
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            double floorPriceForKilogram = double.Parse(Console.ReadLine());
            double eggsOnePackPrice = 0.75 * floorPriceForKilogram;
            double milkPriceForOneLiter = 1.25 * floorPriceForKilogram;
            double milkPriceForOneCozonak = 0.25 * milkPriceForOneLiter;
            double priceForOneCozonac = floorPriceForKilogram + milkPriceForOneCozonak + eggsOnePackPrice;

            int cozonacsCount = 0;
            int coloredEggs = 0;

            while (budget > priceForOneCozonac)
            {
                budget -= priceForOneCozonac;
                coloredEggs += 3;
                cozonacsCount++;

                if (cozonacsCount % 3 == 0)
                {
                    int lostEggsCount = cozonacsCount - 2;
                    coloredEggs -= lostEggsCount;
                }
            }

            Console.WriteLine($"You made {cozonacsCount} cozonacs! Now you have {coloredEggs} eggs and {budget:f2}BGN left.");
        }
    }
}
