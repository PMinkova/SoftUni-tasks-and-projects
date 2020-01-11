using System;

namespace ForLoopMoreExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            double heritage = double.Parse(Console.ReadLine());
            int lastYear = int.Parse(Console.ReadLine());

            double spendMoney = 0;
            int age = 18;

            for (int i = 1800; i <= lastYear; i++)
            {
                
                if (i % 2 == 0)
                {
                    spendMoney += 12000;
                }
                else
                {
                    spendMoney = spendMoney + 12000 + (50 * age);
                }

                age++;
            }
            double diff = Math.Abs(heritage - spendMoney);

            if (spendMoney > heritage)
            {
                Console.WriteLine($"He will need {diff:f2} dollars to survive.");
            }
            else
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {diff:f2} dollars left.");
            }
        }
    }
}
