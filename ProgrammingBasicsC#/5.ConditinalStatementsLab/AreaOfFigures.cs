using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area = 0;

            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = side * side;        
            }
            else if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());

                area = sideA * sideB;
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = radius * radius * Math.PI;
            }
            else if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = side * height / 2;
            }

            Console.WriteLine("{0:F3}", area);
        }
    }
}
