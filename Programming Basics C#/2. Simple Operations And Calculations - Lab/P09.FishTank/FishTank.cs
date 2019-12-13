using System;

namespace P09.FishTank
{
    class FishTank
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentFill = double.Parse(Console.ReadLine());

            double volumeAquariumLiters = 0.001 * lenght * width * height;
            double freeVolume = volumeAquariumLiters - percentFill * 0.01 * volumeAquariumLiters;

            Console.WriteLine("{0:F3}",freeVolume);
        }
    }
}
