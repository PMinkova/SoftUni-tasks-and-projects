using System;

namespace _05_TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double widthFilled = width * 100 - 100;
            double rowsCount = Math.Floor(widthFilled / 70);
            double columnsCount = Math.Floor(length * 100 / 120);

            double workingPlaces = rowsCount * columnsCount;
            double totalWorkingPlaces = workingPlaces - 3;
            Console.WriteLine(totalWorkingPlaces);
        }
    }
}
