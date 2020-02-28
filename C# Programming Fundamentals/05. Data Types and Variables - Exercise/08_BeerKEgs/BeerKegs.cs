using System;

namespace _08_BeerKegs
{
    class BeerKegs
    {
        static void Main(string[] args)
        {
            int kegsCount = int.Parse(Console.ReadLine());
            double maxVolume = 0;
            string biggestKeg = "";

            for (int i = 0; i < kegsCount; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * radius * radius * height;

                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    biggestKeg = model;
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}
