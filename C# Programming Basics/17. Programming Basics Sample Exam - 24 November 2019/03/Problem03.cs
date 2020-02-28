using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string sushiType = Console.ReadLine();
            string restaurantName = Console.ReadLine();
            int portionsCount = int.Parse(Console.ReadLine());
            char delivery = char.Parse(Console.ReadLine());
            double prize = 0;
            bool isValid = true;

            if (sushiType == "sashimi")
            {
                if (restaurantName == "Sushi Zone")
                {
                    prize = 4.99;
                }
                else if (restaurantName == "Sushi Time")
                {
                    prize += 5.49;
                }
                else if (restaurantName == "Sushi Bar")
                {
                    prize += 5.25; 
                }
                else if (restaurantName == "Asian Pub")
                {
                    prize = 4.50;
                }
                else
                {
                    isValid = false;
                    Console.WriteLine($"{restaurantName} is invalid restaurant!");
                }
            }
            else if (sushiType == "maki")
            {
                if (restaurantName == "Sushi Zone")
                {
                    prize = 5.29;
                }
                else if (restaurantName == "Sushi Time")
                {
                    prize = 4.69;
                }
                else if (restaurantName == "Sushi Bar")
                {
                    prize = 5.55;
                }
                else if (restaurantName == "Asian Pub")
                {
                    prize = 4.80;
                }
                else
                {
                    isValid = false;
                    Console.WriteLine($"{restaurantName} is invalid restaurant!");
                }
            }
            else if (sushiType == "uramaki")
            {
                if (restaurantName == "Sushi Zone")
                {
                    prize = 5.99;
                }
                else if (restaurantName == "Sushi Time")
                {
                    prize = 4.49;
                }
                else if (restaurantName == "Sushi Bar")
                {
                    prize = 6.25;
                }
                else if (restaurantName == "Asian Pub")
                {
                    prize = 5.50;
                }
                else
                {
                    isValid = false;
                    Console.WriteLine($"{restaurantName} is invalid restaurant!");
                }
            }
            else if (sushiType == "temaki")
            {
                if (restaurantName == "Sushi Zone")
                {
                    prize = 4.29;
                }
                else if (restaurantName == "Sushi Time")
                {
                    prize = 5.19;
                }
                else if (restaurantName == "Sushi Bar")
                {
                    prize = 4.75;
                }
                else if (restaurantName == "Asian Pub")
                {
                    prize = 5.50;
                }
                else
                {
                    isValid = false;
                    Console.WriteLine($"{restaurantName} is invalid restaurant!");
                }
            }
            
            if (delivery =='Y')
            {
                prize = (prize * portionsCount) + 0.2 * (prize * portionsCount);
            }
            else if (delivery == 'N')
            {
                prize = prize * portionsCount;
                
            }
            if (isValid)
            {
                Console.WriteLine($"Total price: {Math.Ceiling(prize)} lv.");
            }
            
        }
    }
}
