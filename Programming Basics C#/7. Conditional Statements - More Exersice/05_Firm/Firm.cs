using System;

namespace _05_Firm
{
    class Firm
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int employeesCount = int.Parse(Console.ReadLine());

            double daysAvailable = 0.9 * days;

            double workinHours = Math.Floor(daysAvailable * 8 + (employeesCount * 2 * days));
            double diff = Math.Abs(workinHours - hoursNeeded);

            if (workinHours >= hoursNeeded)
            {
                Console.WriteLine($"Yes!{diff} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{diff} hours needed.");
            }
        }
    }
}
