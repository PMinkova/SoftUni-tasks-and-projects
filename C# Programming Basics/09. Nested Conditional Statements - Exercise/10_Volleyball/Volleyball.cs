using System;

namespace _10_Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string leapOrNot = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());              
            int holidaysGoingHome = int.Parse(Console.ReadLine());    

            int holidaysInSofia = 48 - holidaysGoingHome;
            double gamesInSofiaInHolidays = 2.0/3.0 * holidays;
            double gamesInSofia = 0.75 * holidaysInSofia;
            double totalGamesInSofia = gamesInSofia + gamesInSofiaInHolidays;
            double gamesAtHome = holidaysGoingHome;
            double totalGames = gamesAtHome + totalGamesInSofia;

            if (leapOrNot == "leap")
            {
                totalGames *= 1.15;
            }

            Console.WriteLine($"{Math.Floor(totalGames)}");
        }
    }
}
