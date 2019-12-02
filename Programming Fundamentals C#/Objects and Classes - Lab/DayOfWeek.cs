using System;
using System.Globalization;
using System.Collections.Generic;

namespace _01_DayOfWeek
{
    class Program
    {
        static void Main()
        {
            DateTime date = DateTime.ParseExact(Console.ReadLine(),"d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
