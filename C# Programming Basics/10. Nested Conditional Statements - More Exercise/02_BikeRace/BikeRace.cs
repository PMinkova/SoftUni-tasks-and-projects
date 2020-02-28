using System;

namespace _02_BikeRace
{
    class BikeRace
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string trackType = Console.ReadLine();
            double totalSum = 0;

            if (trackType == "trail")
            {
                totalSum = juniors * 5.5 + seniors * 7;
            }
            else if (trackType == "cross-country")
            {
                totalSum = juniors * 8 + seniors * 9.5;

                if ((juniors + seniors) >= 50)
                {
                    totalSum *= 0.75;
                }
            }
            else if (trackType == "downhill")
            {
                totalSum = juniors * 12.25 + seniors * 13.75;
            }
            else if (trackType == "road")
            {
                totalSum = juniors * 20 + seniors * 21.5;
            }

            double expenses = 0.05 * totalSum;
            totalSum -= expenses;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
