using System;

namespace _10_Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string leapOrNot = Console.ReadLine();
            int praznici = int.Parse(Console.ReadLine());              //2
            int holidaysGoingHome = int.Parse(Console.ReadLine());    //3

            int holidaysInSofia = 48 - holidaysGoingHome;
            double gamesInSofiaInPraznici = 2.0/3.0 * praznici;
            double gamesInSofia = 0.75 * holidaysInSofia;
            double totalGamesInSofia = gamesInSofia + gamesInSofiaInPraznici;
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
