using System;

namespace _04_Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSteps = 0;

            while (totalSteps < 10000)
            {
                string input = Console.ReadLine();

                if (input == "Going home")
                {
                    totalSteps += int.Parse(Console.ReadLine());
                    break;
                }
                totalSteps += int.Parse(input);
                
            }

            if (totalSteps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else
            {
                int moreStepsNeeded = 10000 - totalSteps;
                Console.WriteLine($"{moreStepsNeeded} more steps to reach goal.");
            }
        }
    }
}
