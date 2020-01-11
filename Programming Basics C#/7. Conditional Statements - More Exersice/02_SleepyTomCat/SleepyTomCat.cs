using System;

namespace _02_SleepyTomCat
{
    class SleepyTomCat
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());
            int norm = 30000;

            int minPlayingInWorkindays = (365 - daysOff) * 63;
            int minutesPlayingInDaysOff = daysOff * 127;
            int minTotalPlay = minPlayingInWorkindays + minutesPlayingInDaysOff;

            int diff = Math.Abs(minTotalPlay - norm);
            int hours = diff / 60;
            int minRest = diff % 60;

            if (minTotalPlay > norm)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minRest} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minRest} minutes less for play");
            }
        }
    }
}
