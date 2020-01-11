using System;

namespace _03_Logodtic
{
    class Program
    {
        private static object tonesWithTrain;

        static void Main(string[] args)
        {
            int goodsCount = int.Parse(Console.ReadLine());

            double totalPrice = 0;
            double totalTones = 0;
            double tonesWithBus = 0;
            double tonesWithTruck = 0;
            double tonesWithTrain = 0;

            for (int i = 0; i < goodsCount; i++)
            {
                int tones = int.Parse(Console.ReadLine());

                if (tones < 4)
                {
                    totalPrice += 200 * tones;
                    tonesWithBus += tones;
                }
                else if (4 <= tones && tones < 12)
                {
                    totalPrice += 175 * tones;
                    tonesWithTruck += tones;
                }
                else if (tones >= 12)
                {
                    totalPrice += 120 * tones;
                    tonesWithTrain += tones;
                }

                totalTones += tones;
            }
           
            double avgPriceForTone = totalPrice / totalTones;

            tonesWithBus = tonesWithBus / totalTones * 100;
            tonesWithTruck = tonesWithTruck / totalTones * 100;
            tonesWithTrain = tonesWithTrain / totalTones * 100;

            Console.WriteLine($"{avgPriceForTone:f2}");
            Console.WriteLine($"{tonesWithBus:f2}%");
            Console.WriteLine($"{tonesWithTruck:f2}%");
            Console.WriteLine($"{tonesWithTrain:f2}%");
        }
    }
}
