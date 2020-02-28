using System;

namespace _10_PokeMon
{
    class Pokemon
    {
        static void Main(string[] args)
        {
            int powerN = int.Parse(Console.ReadLine());
            int distanceBetweenTargetsM = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());
            int targetsPoked = 0;
            double halfOfN = 0.5 * powerN;

            while (powerN >= distanceBetweenTargetsM)
            {
                powerN -= distanceBetweenTargetsM;
                targetsPoked++;

                if (powerN == halfOfN && exhaustionFactorY != 0)
                {
                    powerN /= exhaustionFactorY;
                }
            }

            Console.WriteLine(powerN);
            Console.WriteLine(targetsPoked);
        }
    }
}
