using System;

namespace DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double wardrobeSide = double.Parse(Console.ReadLine());

            double hallSpaceArea = lenght * width;
            double wardrobeArea = wardrobeSide * wardrobeSide;
            double deskArea = hallSpaceArea / 10.0;
            double freeHallSpace = hallSpaceArea - wardrobeArea - deskArea;

            double oneDancerSpace = (40.0 + 7000.0) / 10000;

            Console.WriteLine(Math.Floor(freeHallSpace/oneDancerSpace));    
        }
    }
}
