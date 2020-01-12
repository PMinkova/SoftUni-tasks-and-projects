using System;

namespace _03_LongerLine
{
    class LongerLine
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double sumOfFirstTwoPoints = GetSumOfTwoPoints(x1, y1, x2, y2);
            double sumOfSecondTwoPoints = GetSumOfTwoPoints(x3, y3, x4, y4);

            if (sumOfFirstTwoPoints > sumOfSecondTwoPoints)
            {
                PrintFirstClosestToZeroPoint(x1, y1, x2, y2);
            }
            else
            {
                PrintFirstClosestToZeroPoint(x3, y3, x4, y4);
            }
        }
        static void PrintFirstClosestToZeroPoint(double x1, double y1, double x2, double y2)
        {
            double firstPointResult = Math.Abs(x1) + Math.Abs(y1);
            double secondPointResult = Math.Abs(x2) + Math.Abs(y2);

            if (firstPointResult <= secondPointResult)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
        static double GetSumOfTwoPoints(double x1, double y1, double x2, double y2)
        {
            double firstPointResult = Math.Abs(x1) + Math.Abs(y1);
            double secondPointResult = Math.Abs(x2) + Math.Abs(y2);

            double sum = firstPointResult + secondPointResult;
            return sum;
        }      
    }
}
