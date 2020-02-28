using System;

namespace _07_WaterOverflow
{
    class WaterOverflow
    {
        static void Main(string[] args)
        {
            int fuels = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < fuels; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                sum += liters;

                if (sum > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= liters;                  
                }
            }

            Console.WriteLine(sum);
        }
    }
}
