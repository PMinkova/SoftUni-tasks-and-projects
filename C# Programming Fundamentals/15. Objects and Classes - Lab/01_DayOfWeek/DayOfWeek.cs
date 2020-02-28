using System;
using System.Globalization;

namespace _01_DayOfWeek
{
    class DayOfWeek
    {
        static void Main()
        {
            DateTime date = DateTime.ParseExact(Console.ReadLine(),"d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
