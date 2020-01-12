using System;

namespace _03_GamingStore
{
    class GamingStore
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            double startMoney = currentBalance;

            string input = Console.ReadLine();

            bool isValid = input == "OutFall 4" || input == "CS: OG" || input == "Zplinter Zell" ||
                input == "Honored 2" || input == "RoverWatch" || input == "RoverWatch Origins Edition";

            while (input != "Game Time")
            {
                if (input == "OutFall 4" && currentBalance >= 39.99)
                {
                    Console.WriteLine($"Bought {input}");
                    currentBalance -= 39.99;
                }
                else if (input == "CS: OG" && currentBalance >= 15.99)
                {
                    Console.WriteLine($"Bought {input}");
                    currentBalance -= 15.99;
                }
                else if (input == "Zplinter Zell" && currentBalance >= 19.99)
                {
                    Console.WriteLine($"Bought {input}");
                    currentBalance -= 19.99;
                }
                else if (input == "Honored 2" && currentBalance >= 59.99)
                {
                    Console.WriteLine($"Bought {input}");
                    currentBalance -= 59.99;
                }
                else if (input == "RoverWatch" && currentBalance >= 29.99)
                {
                    Console.WriteLine($"Bought {input}");
                    currentBalance -= 29.99;
                }
                else if (input == "RoverWatch Origins Edition" && currentBalance >= 39.99)
                {
                    Console.WriteLine($"Bought {input}");
                    currentBalance -= 39.99;
                }
                else if(!isValid)
                {

                    Console.WriteLine("Not Found");    
                }
                else 
                {
                    Console.WriteLine("Too Expensive");
                }

                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }

                input = Console.ReadLine();
            }

            if (input == "Game Time")
            {
                double spentMoney = startMoney - currentBalance;

                Console.WriteLine($"Total spent: ${spentMoney:f2}. Remaining: ${currentBalance:f2}");
            }
        }
    }
}
