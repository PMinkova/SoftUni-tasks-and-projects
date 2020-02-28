using System;

namespace _04_BackInThirtyMinutes
{
    class BackInThirtyMinutes
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int minutesTotal = hours * 60 + minutes + 30;
            int arrivalHour = minutesTotal / 60;
            int minutesArr = minutesTotal % 60;

            if (arrivalHour == 24)
            {
                arrivalHour = 0;
            }
            
            Console.WriteLine($"{arrivalHour}:{minutesArr}");
        }
    }
}
