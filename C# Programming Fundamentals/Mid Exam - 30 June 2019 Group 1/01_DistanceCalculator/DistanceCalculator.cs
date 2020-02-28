using System;

namespace _01_Distancecalculator
{
    class DistanceCalculator
    {
        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());
            double lengthOfOneStepInCentimeters = double.Parse(Console.ReadLine());

            int goalInMeters = int.Parse(Console.ReadLine());
            int goalInCentimeters = goalInMeters * 100;
            double travelledDistance = 0;

            for (int i = 1; i <= steps; i++)
            {
                if (i % 5 == 0)
                {
                    travelledDistance += 0.7 * lengthOfOneStepInCentimeters;
                }
                else
                {
                    travelledDistance += lengthOfOneStepInCentimeters;
                }
            }

            double percent = travelledDistance * 100 / goalInCentimeters;

            Console.WriteLine($"You travelled {percent:f2}% of the distance!");
        }
    }
}
