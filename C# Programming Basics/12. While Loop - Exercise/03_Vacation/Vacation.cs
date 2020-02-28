using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyVecation = double.Parse(Console.ReadLine());
            double haveMoney = double.Parse(Console.ReadLine());

            int spend = 0;
            int days = 0;

            while (haveMoney < moneyVecation)
            {
                string doing = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());

                if (doing == "spend")
                {
                    haveMoney = Math.Max((haveMoney - money), 0.00);
                    spend++;
                    days++;

                }
                else
                {
                    haveMoney += money;
                    spend = 0;
                    days++;
                }
                if (spend == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(days);
                    return;
                }
            }
            Console.WriteLine($"You saved the money for {days} days.");
        }
    }
}