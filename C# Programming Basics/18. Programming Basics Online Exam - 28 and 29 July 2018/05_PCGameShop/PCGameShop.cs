using System;

namespace _05_PCGameShop
{
    class PCGameShop
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double hearthStoneCounter = 0;
            double forniteCounter = 0;
            double overwatchCounter = 0;
            double othersCounter = 0;
            
            for (int i = 0; i < n; i++)
            {
                string gameName = Console.ReadLine();

                if (gameName == "Hearthstone")
                {
                    hearthStoneCounter++;
                }
                else if (gameName == "Fornite")
                {
                    forniteCounter++;
                }
                else if (gameName == "Overwatch")
                {
                    overwatchCounter++;
                }
                else
                {
                    othersCounter++;
                }
            }

            double heartStonPercent = hearthStoneCounter / n * 100;
            double fornitePercent = forniteCounter / n * 100;
            double overwatchPercent = overwatchCounter / n * 100;
            double othersPercent = othersCounter / n * 100;

            Console.WriteLine($"Hearthstone - {heartStonPercent:f2}%");
            Console.WriteLine($"Fornite - {fornitePercent:f2}%");
            Console.WriteLine($"Overwatch - {overwatchPercent:f2}%");
            Console.WriteLine($"Others - {othersPercent:f2}%");
        }
    }
}
