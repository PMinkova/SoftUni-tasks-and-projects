using System;

namespace _01_BlackFlag
{
    class BlackFlag
    {
        static void Main(string[] args)
        {
            int totalDays = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunderInTheEnd = double.Parse(Console.ReadLine());

            double totalPlunder = 0;

            for (int i = 1; i <= totalDays; i++)
            {
                totalPlunder += dailyPlunder;

                if (i % 3 == 0)
                {
                    totalPlunder += 0.5 * dailyPlunder;
                }
                if (i % 5 == 0)
                {
                    totalPlunder -= 0.3 * totalPlunder;
                }
            }

            if (totalPlunder >= expectedPlunderInTheEnd)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else
            {
                double percent = totalPlunder * 100 / expectedPlunderInTheEnd;

                Console.WriteLine($"Collected only {percent:f2}% of the plunder.");
            }
        }
    }
}
