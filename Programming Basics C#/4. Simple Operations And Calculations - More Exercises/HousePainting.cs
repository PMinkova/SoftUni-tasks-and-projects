using System;

namespace _07_HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double doorArea = 2 * 1.2;
            double windowArea = 1.5 * 1.5;

            double frontWallArea = x * x - doorArea;
            double backWallArea = x * x;
            double rightWallArea = x * y - windowArea;
            double leftWallArea = rightWallArea;

            double roofRightSideArea = x * y;
            double roofLeftSideArea = roofRightSideArea;
            double roofFrontSideArea = x * h / 2;
            double roofBackSideArea = roofFrontSideArea;

            double greenPaintArea = frontWallArea + backWallArea + rightWallArea + leftWallArea;
            double redPaintArea = roofBackSideArea + roofFrontSideArea + roofLeftSideArea + roofRightSideArea;

            double greenPaint = greenPaintArea / 3.4;
            double redPaint = redPaintArea / 4.3;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");


        }
    }
}
