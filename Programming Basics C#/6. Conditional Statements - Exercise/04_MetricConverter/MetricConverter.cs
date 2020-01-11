using System;

namespace _04_MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());
            string unitInput = Console.ReadLine();
            string unitOutput = Console.ReadLine();

            if (unitInput == "cm")
            {
                value /= 100;
            }
            else if (unitInput == "mm")
            {
                value /= 1000;
            }

            if (unitOutput == "cm")
            {
                value *= 100;
            }
            else if (unitOutput == "mm")
            {
                value *= 1000;
            }
            Console.WriteLine($"{value:f3}");
        }
    }
}
