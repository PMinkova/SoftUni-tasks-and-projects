using System;

namespace _09_SpiceMustFlow
{
    class SpiceMustFlow
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int days = 0;
            int totalSpice = 0;
            int workersConsumation = 26;

            while (startingYield >= 100)
            {
                totalSpice += startingYield;
                totalSpice -= workersConsumation;
                days++;
                startingYield -= 10;
            }

            if (totalSpice > workersConsumation)
            {
                totalSpice -= workersConsumation;
            }

            Console.WriteLine(days);
            Console.WriteLine(totalSpice);
        }
    }
}
