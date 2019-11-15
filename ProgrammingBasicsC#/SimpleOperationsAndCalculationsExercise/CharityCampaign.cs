using System;

namespace _06.CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());
            int confectionersCount = int.Parse(Console.ReadLine());
            int cakesCount = int.Parse(Console.ReadLine());
            int wafersCount = int.Parse(Console.ReadLine());
            int pancakesCount = int.Parse(Console.ReadLine());
          
            double totalSum = daysCount*confectionersCount*((cakesCount*45)+(wafersCount*5.80)+(pancakesCount*3.20));
            double charitySum = totalSum - (totalSum / 8);

            Console.WriteLine("{0:F2}", charitySum);
        }
    }
}
