using System;

namespace _02_ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int goal = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            int counter = 1;
            int cardTransactinCount = 0;
            int cashTransactionCount = 0;

            double moneyFromCash = 0;
            double moneyFromCards = 0;
            double totalMoney = 0;            

            while (input != "End")
            {
                int transaction = int.Parse(input);

                if (counter % 2 == 0 && transaction > 10)
                {
                    moneyFromCards += transaction;
                    totalMoney += transaction;
                    cardTransactinCount++;
                    Console.WriteLine("Product sold!");
                }
                else if (counter % 2 != 0 && transaction <= 100)
                {
                    moneyFromCash += transaction;
                    totalMoney += transaction;
                    cashTransactionCount++;
                    Console.WriteLine("Product sold!");
                }
                else
                {
                    Console.WriteLine("Error in transaction!");                   
                }
               
                if (totalMoney >= goal)
                {
                    break;
                }
                
                counter++;
                input = Console.ReadLine();
            }
               
            double avgCs = moneyFromCash / cashTransactionCount;
            double avgCc = moneyFromCards / cardTransactinCount;

            if (input == "End")
            {
                Console.WriteLine($"Failed to collect required money for charity.");
            }
            else
            {
                Console.WriteLine($"Average CS: {avgCs:f2}");
                Console.WriteLine($"Average CC: {avgCc:f2}");
            }
        }
    }
}
