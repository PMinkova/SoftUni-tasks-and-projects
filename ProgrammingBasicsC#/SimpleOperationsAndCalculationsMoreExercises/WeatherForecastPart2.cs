using System;

namespace _09_WeatherForecastPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());

            if (26.00 <= input && input <= 35.00)
            {
                Console.WriteLine("Hot");
            }
            else if (20.1 <= input && input <= 25.9)
            {
                Console.WriteLine("Warm");
            }
            else if (15.00 <= input && input <= 20.00)
            {
                Console.WriteLine("Mild");
            }
            else if (12.00 <= input && input <= 14.9)
            {
                Console.WriteLine("Cool");
            }
            else if (5.00 <= input && input <= 11.9)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
