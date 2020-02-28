using System;
using System.Numerics;

namespace _11_SnowBalls
{
    class SnowBalls
    {
        static void Main(string[] args)
        {
            int snowballs = int.Parse(Console.ReadLine());

            BigInteger maxSnowballvalue = 0;
            int bestSnowballSnow = 0;
            int bestSnowballTime = 0;
            int bestSnowballQuality = 0;

            for (int i = 1; i <= snowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue > (BigInteger)maxSnowballvalue)
                {
                    maxSnowballvalue = snowballValue;
                    bestSnowballSnow = snowballSnow;
                    bestSnowballTime = snowballTime;
                    bestSnowballQuality = snowballQuality;
                }
            }

            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {maxSnowballvalue} ({bestSnowballQuality})");
        }
    }
}
