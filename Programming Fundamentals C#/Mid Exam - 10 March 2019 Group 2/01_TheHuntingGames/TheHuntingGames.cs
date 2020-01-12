using System;

namespace _01_TheHuntingGames
{
    class TheHuntingGames
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int playersCount = int.Parse(Console.ReadLine());
            double groupsEnergy = double.Parse(Console.ReadLine());
            double dailyWaterForOnePerson = double.Parse(Console.ReadLine());
            double dailyFoodForOnePerson = double.Parse(Console.ReadLine());
            double totalWater = playersCount * dailyWaterForOnePerson * days;
            double totalFood = playersCount * dailyFoodForOnePerson * days;
            bool hasEnoughEnergy = true;

            for (int i = 1; i <= days; i++)
            {
                double dailyEnergyLoss = double.Parse(Console.ReadLine());

                groupsEnergy -= dailyEnergyLoss;

                if (groupsEnergy <= 0)
                {
                    hasEnoughEnergy = false;
                    break;
                }

                if (i % 2 == 0)
                {
                    totalWater *= 0.7;
                    groupsEnergy *= 1.05;
                }

                if (i % 3 == 0)
                {
                    double foodReduce = totalFood / playersCount;
                    totalFood -= foodReduce;
                    groupsEnergy *= 1.1;
                }
            }

            if (hasEnoughEnergy)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupsEnergy:f2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
            }

        }
    }
}
