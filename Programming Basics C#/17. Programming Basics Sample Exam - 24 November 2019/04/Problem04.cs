using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int budgetForMusician = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int guestsCount = 0;
            int prizeForGroup = 0;
            int totalSum = 0;

            while (command != "The restaurant is full")
            {
                int peopleInOneGroup = int.Parse(command);
                
                if (peopleInOneGroup < 5)
                {
                    prizeForGroup = peopleInOneGroup * 100;
                }
                else
                {
                    prizeForGroup = peopleInOneGroup * 70;
                }

                totalSum += prizeForGroup;
                
                guestsCount += peopleInOneGroup;
                command = Console.ReadLine();
            }
            int moneyLeft = totalSum - budgetForMusician;

            if (moneyLeft < 0)
            {
                Console.WriteLine($"You have {guestsCount} guests and {totalSum} leva income, but no singer.");
            }
            else
            {
                Console.WriteLine($"You have {guestsCount} guests and {moneyLeft} leva left.");
            }

        }
    }
}
