using System;

namespace _06_Bills
{
    class Bills
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            
            double totalElectrycity = 0;
            double totalInternet = 0;
            double totalWater = 0;
            double totalOthers = 0;
            double totalTotal = 0;

            for (int i = 0; i < months; i++)
            {
                totalElectrycity += double.Parse(Console.ReadLine());
                totalWater += 20;
                totalInternet += 15;
                totalOthers = totalElectrycity + totalWater + totalInternet;
                totalOthers *= 1.2;
            }


            double avg = (totalElectrycity + totalInternet + totalWater + totalOthers) / months;

            Console.WriteLine($"Electricity: {totalElectrycity:f2} lv");
            Console.WriteLine($"Water: {totalWater:f2} lv");
            Console.WriteLine($"Internet: {totalInternet:f2} lv");
            Console.WriteLine($"Other: {totalOthers:f2} lv");
            Console.WriteLine($"Average: {avg:f2} lv");
        }
    }
}
