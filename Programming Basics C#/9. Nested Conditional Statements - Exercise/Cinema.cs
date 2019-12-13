using System;

namespace _02_Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int rowNumbers = int.Parse(Console.ReadLine());
            int columnNumbers = int.Parse(Console.ReadLine());

            double income = 0;

            if (projectionType == "Premiere")
            {
                income = 12 * rowNumbers * columnNumbers;
            }
            else if (projectionType == "Normal")
            {
                income = 7.50 * rowNumbers * columnNumbers;
            }
            else
            {
                income = 5 * rowNumbers * columnNumbers;
            }

            Console.WriteLine("{0:F2} leva", income);
        }
    }
}
