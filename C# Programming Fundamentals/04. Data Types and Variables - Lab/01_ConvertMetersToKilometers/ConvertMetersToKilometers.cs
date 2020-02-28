using System;

namespace _01_ConvertMetersToKilometers
{
    class ConvertMetersToKilometers
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());

            float kilometers = meters / 1000f;

            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
