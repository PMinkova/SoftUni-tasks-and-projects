using System;

namespace _03_Harvest
{
    class Harvest
    {
        static void Main(string[] args)
        {
            int vineYardArea = int.Parse(Console.ReadLine());
            double grapeForOneSquareMeter = double.Parse(Console.ReadLine());
            int litersWineNeeded = int.Parse(Console.ReadLine());
            int workorsCount = int.Parse(Console.ReadLine());

            double areaForWineProduction = 0.4 * vineYardArea;
            double grapekg = grapeForOneSquareMeter * areaForWineProduction;
            double litersWineProduced = grapekg / 2.5;

            double diff = Math.Abs(litersWineNeeded - litersWineProduced);
            double wineForWorkers = diff / workorsCount;

            if (litersWineProduced < litersWineNeeded)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(diff)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(litersWineProduced)} liters.");
                Console.WriteLine($"{Math.Ceiling(diff)} liters left -> {Math.Ceiling(wineForWorkers)} liters per person.");
            }
        }
    }
}
