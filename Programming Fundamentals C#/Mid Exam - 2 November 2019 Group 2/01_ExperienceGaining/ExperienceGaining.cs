using System;

namespace _01_ExperienceGaining
{
    class ExperienceGaining
    {
        static void Main(string[] args)
        {
            double experienceNeeded = double.Parse(Console.ReadLine());
            int battlesCount = int.Parse(Console.ReadLine());
            double totalExperience = 0;
            bool hasCollectedExperience = false;

            for (int i = 1; i <= battlesCount; i++)
            {
                double currentExperience = double.Parse(Console.ReadLine());

                totalExperience += currentExperience;

                if (i % 3 == 0)
                {
                    totalExperience += 0.15 * currentExperience;
                }

                if (i % 5 == 0)
                {
                    totalExperience -= 0.1 * currentExperience;
                }

                if (totalExperience >= experienceNeeded)
                {
                    hasCollectedExperience = true;
                    battlesCount = i;
                    break;
                }
            }

            if (hasCollectedExperience)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {battlesCount} battles.");
            }
            else
            {
                double moreExperienceNeeded = experienceNeeded - totalExperience;
                Console.WriteLine($"Player was not able to collect the needed experience, {moreExperienceNeeded:f2} more needed.");
            }
        }
    }
}
