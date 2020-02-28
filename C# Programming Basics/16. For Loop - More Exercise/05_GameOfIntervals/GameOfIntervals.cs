using System;

namespace _05_GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());
            double totalPoints = 0;
            double numbersFromZeroToNine = 0;
            double numbersFromTenToNineteen = 0;
            double numbersFromTwentyToTwentyNine = 0;
            double numbersFromThirtyToThiryNine = 0;
            double numberFromFortyToFifty = 0;
            double invalidNumbers = 0;


            for (int i = 0; i < steps; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (0 <= number && number < 10)
                {
                    totalPoints += 0.2 * number;
                    numbersFromZeroToNine++;
                }
                else if (10 <= number && number < 20)
                {
                    totalPoints += 0.3 * number;
                    numbersFromTenToNineteen++;
                }
                else if (20 <= number && number < 30)
                {
                    totalPoints += 0.4 * number;
                    numbersFromTwentyToTwentyNine++;
                }
                else if (30 <= number && number < 40)
                {
                    totalPoints += 50;
                    numbersFromThirtyToThiryNine++;
                }
                else if (40 <= number && number <= 50)
                {
                    totalPoints += 100;
                    numberFromFortyToFifty++;
                }
                else
                {
                    totalPoints /= 2;
                    invalidNumbers++;
                }
            }

            numbersFromZeroToNine = numbersFromZeroToNine / steps * 100;
            numbersFromTenToNineteen = numbersFromTenToNineteen / steps * 100;
            numbersFromTwentyToTwentyNine = numbersFromTwentyToTwentyNine / steps * 100;
            numbersFromThirtyToThiryNine = numbersFromThirtyToThiryNine / steps * 100;
            numberFromFortyToFifty = numberFromFortyToFifty / steps * 100;
            invalidNumbers = invalidNumbers / steps * 100;

            Console.WriteLine($"{totalPoints:f2}");
            Console.WriteLine($"From 0 to 9: {numbersFromZeroToNine:f2}%");
            Console.WriteLine($"From 10 to 19: {numbersFromTenToNineteen:f2}%");
            Console.WriteLine($"From 20 to 29: {numbersFromTwentyToTwentyNine:f2}%");
            Console.WriteLine($"From 30 to 39: {numbersFromThirtyToThiryNine:f2}%");
            Console.WriteLine($"From 40 to 50: {numberFromFortyToFifty:f2}%");
            Console.WriteLine($"Invalid numbers: {invalidNumbers:f2}%");
        }
    }
}
