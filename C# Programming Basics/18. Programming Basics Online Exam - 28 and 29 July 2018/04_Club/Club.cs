using System;

namespace _04_Club
{
    class Club
    {
        static void Main(string[] args)
        {
            double goal = double.Parse(Console.ReadLine());
            string cocktailName = "";
            int cocktailCount = 0;
            int cocktailPrice = 0;
            double income = 0;
            double moneyFromCocktail;
            
            while (true)
            {
                cocktailName = Console.ReadLine();
                
                if (cocktailName == "Party!")
                {
                    Console.WriteLine($"We need {goal - income:f2} leva more.");
                    break;
                }

                cocktailCount = int.Parse(Console.ReadLine());
                cocktailPrice = (int)cocktailName.Length;
                moneyFromCocktail = cocktailCount * cocktailPrice;

                if (moneyFromCocktail % 2 != 0)
                {
                    moneyFromCocktail *= 0.75;
                }

                income += moneyFromCocktail;

                if (income >= goal)
                {
                    Console.WriteLine("Target acquired.");
                    break;
                }
            }

            Console.WriteLine($"Club income - {income:f2} leva.");
        }
    }
}
