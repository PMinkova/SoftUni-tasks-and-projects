using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class StartUp
    {
        private static List<Team> teams;

        static void Main(string[] args)
        {

            teams = new List<Team>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                var commandArguments = input
                    .Split(';')
                    .ToArray();

                var command = commandArguments[0];
                var teamName = commandArguments[1];

                try
                {
                    if (command == "Team")
                    {
                        AddTeam(teamName);
                    }
                    else if (command == "Add")
                    {
                        AddPlayerToTeam(teamName, commandArguments);
                    }
                    else if (command == "Remove")
                    {
                        RemovePlayerFromTeam(commandArguments, teamName);
                    }
                    else if (command == "Rating")
                    {
                        RateTeam(teamName);
                    }

                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }

                input = Console.ReadLine();
            }
        }

        private static void RateTeam(string teamName)
        {
            var teamToRate = teams.FirstOrDefault(t => t.Name == teamName);

            if (teamToRate == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InexistingTeam, teamName));
            }

            Console.WriteLine(teamToRate);
        }

        private static void RemovePlayerFromTeam(string[] commandArguments, string teamName)
        {
            var playerName = commandArguments[2];
            var removingTeam = teams.FirstOrDefault(t => t.Name == teamName);

            if (removingTeam == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InexistingTeam, teamName));
            }

            removingTeam.RemovePlayer(playerName);
        }

        private static void AddPlayerToTeam(string teamName, string[] commandArguments)
        {
            var joiningTeam = teams.FirstOrDefault(t => t.Name == teamName);

            if (joiningTeam == null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.InexistingTeam, teamName));
            }

            var player = CreateNewPlayer(commandArguments);

            joiningTeam.AddPlayer(player);
        }

        private static Player CreateNewPlayer(string[] commandArguments)
        {
            var playerName = commandArguments[2];
            var endurance = int.Parse(commandArguments[3]);
            var sprint = int.Parse(commandArguments[4]);
            var dribble = int.Parse(commandArguments[5]);
            var passing = int.Parse(commandArguments[6]);
            var shooting = int.Parse(commandArguments[7]);

            var player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
            return player;
        }

        private static void AddTeam(string teamName)
        {
            var team = new Team(teamName);
            teams.Add(team);
        }
    }
}
