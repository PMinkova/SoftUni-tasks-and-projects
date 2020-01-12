using System;

namespace _02_CenterPoint
{
    class CenterPoint
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintClosestToZeroPoint(x1, y1, x2, y2);
        }

        static void PrintClosestToZeroPoint(double x1, double y1, double x2, double y2)
        {
            double firstPointResult = Math.Abs(x1) + Math.Abs(y1);
            double secondPointResult = Math.Abs(x2) + Math.Abs(y2);

            if (firstPointResult <= secondPointResult)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
