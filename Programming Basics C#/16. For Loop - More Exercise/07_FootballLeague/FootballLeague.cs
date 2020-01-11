using System;

namespace _07_FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            double fansCount = double.Parse(Console.ReadLine());
            double sectorA = 0;
            double sectorB = 0;
            double sectorV = 0;
            double sectorG = 0;

            for (int i = 0; i < fansCount; i++)
            {
                string sector = Console.ReadLine();

                switch (sector)
                {
                    case "A":
                        sectorA++;
                        break;
                    case "B":
                        sectorB++;
                        break;
                    case "V":
                        sectorV++;
                        break;
                    case "G":
                        sectorG++;
                        break;
                }
            }

            sectorA = sectorA / fansCount * 100;
            sectorB = sectorB / fansCount * 100;
            sectorV = sectorV / fansCount * 100;
            sectorG = sectorG / fansCount * 100;

            double fansCountPercent  = fansCount / capacity * 100;

            Console.WriteLine($"{sectorA:f2}%");
            Console.WriteLine($"{sectorB:f2}%");
            Console.WriteLine($"{sectorV:f2}%");
            Console.WriteLine($"{sectorG:f2}%");
            Console.WriteLine($"{fansCountPercent:f2}%");
        }
    }
}
