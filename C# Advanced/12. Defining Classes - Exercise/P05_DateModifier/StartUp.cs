using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var startDate = Console.ReadLine();
            var endDate = Console.ReadLine();

            var totalDaysCount = DateModifier.GetDifferenceInDaysBetweemTwoDates(startDate, endDate);
            Console.WriteLine(Math.Abs(totalDaysCount));
        }
    }
}
