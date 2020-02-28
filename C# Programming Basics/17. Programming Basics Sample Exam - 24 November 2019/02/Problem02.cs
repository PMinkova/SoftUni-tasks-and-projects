using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double shipWidth = double.Parse(Console.ReadLine());
            double shipLength = double.Parse(Console.ReadLine());
            double shipHeight = double.Parse(Console.ReadLine());
            double astronautsAvgHeight = double.Parse(Console.ReadLine());

            double spaceShipVolume = shipHeight * shipLength * shipWidth;
            double spaceForOneAstronaut = 2 * 2 * (astronautsAvgHeight + 0.4);

            double astronautsCount = Math.Floor(spaceShipVolume / spaceForOneAstronaut);

            if (astronautsCount < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (astronautsCount > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
            else
            {
                Console.WriteLine($"The spacecraft holds {astronautsCount} astronauts.");
            }
        }
    }
}
