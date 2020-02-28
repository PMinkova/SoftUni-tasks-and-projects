using System;

namespace _03_CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double degreesCelsium = double.Parse(Console.ReadLine());

            double degreesFarenheit = degreesCelsium * 1.8 + 32;

            Console.WriteLine($"{degreesFarenheit:F2}");
        }
    }
}
