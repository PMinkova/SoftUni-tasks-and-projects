using System;

namespace _05_Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingHours = int.Parse(Console.ReadLine());
            int startingMinutes = int.Parse(Console.ReadLine());

            int totalMinutes = startingHours * 60 + startingMinutes;
            int totalMinutesPlus15 = totalMinutes + 15;

            int currentHours = totalMinutesPlus15 / 60;
            int currentMinutes = totalMinutesPlus15 % 60;

            if (currentHours == 24)
            {
                currentHours -= 24;
            }

            if (currentMinutes < 10)
            {
                Console.WriteLine($"{currentHours}0{currentMinutes}");
            }
            else
            {
                Console.WriteLine($"{currentHours}:{currentMinutes}");
            }
        }
    }
}
