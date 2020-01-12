using System;

namespace GiftboxCoverage
{
    class GiftboxCoverage
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            int sheetsCoun = int.Parse(Console.ReadLine());
            double coveringArea = double.Parse(Console.ReadLine());
            double totalCoveredArea = 0;
            double giftboxArea = side * side;

            for (int i = 1; i <= sheetsCoun; i++)
            {
                if (i % 3 == 0)
                {
                    totalCoveredArea += 0.25* coveringArea;
                }
                else
                {
                    totalCoveredArea += coveringArea;
                }
            }

            double totalAreaOfTheGiftbox = giftboxArea * 6;

            double percent = 100 * totalCoveredArea / totalAreaOfTheGiftbox;

            Console.WriteLine($"You can cover {percent:f2}% of the box.");
        }
    }
}
