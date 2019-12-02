using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_TeamworkProjects
{
    public class Team
    {
        public Team(string name, string creator)
        {
            Name = name;
            Creator = creator;
            Member = new List<string>();
        }

        public string Name { get; set; }

        public string Creator { get; set; }

        public List<string> Member { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int teamsCount = int.Parse(Console.ReadLine());

            var listOfTeams = new List<Team>();

            for (int i = 0; i < teamsCount; i++)
            {
                string[] data = Console.ReadLine().Split("-");

                string currentTeamCreator = data[0];
                string currentTeamName = data[1];

                if (isTeamNameExisting(listOfTeams, currentTeamName))
                {
                    Console.WriteLine($"Team {currentTeamName} was already created!");
                }
                else if (IsTeamUserAlreadyInTheList(listOfTeams, currentTeamCreator))
                {
                    Console.WriteLine($"{currentTeamCreator} cannot create another team!");
                }
                else
                {
                    listOfTeams.Add(new Team(currentTeamName, currentTeamCreator));
                    Console.WriteLine($"Team {currentTeamName} has been created by {currentTeamCreator}!");
                }
            }

            string input = Console.ReadLine();

            while (input != "end of assignment")
            {
                string[] newMembers = input.Split("->");

                string user = newMembers[0];
                string teamName = newMembers[1];

                if (IsTeamUserAlreadyInTheList(listOfTeams, teamName) && isTeamNameExisting(listOfTeams, teamName))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else if (!isTeamNameExisting(listOfTeams, teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (IsTeamUserAlreadyInTheList(listOfTeams, user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    AddMemberToAnExistingTeam(listOfTeams, teamName, user);
                }

                input = Console.ReadLine();
            }

            PrintValidTeams(listOfTeams);
            PrintTeamsForDisbanding(listOfTeams);
        }

        static void PrintTeamsForDisbanding(List<Team> listOfTeams)
        {
            Console.WriteLine("Teams to disband:");

            foreach (var team in listOfTeams)
            {
                if (team.Member.Count == 0)
                {
                    Console.WriteLine(team.Name);
                }
            }
        }

        static void PrintValidTeams(List<Team> listOfTeams)
        {
            foreach (var team in listOfTeams.OrderByDescending(t => t.Member.Count).ThenBy(t => t.Name))
            {
                if (team.Member.Count > 0)
                {
                    Console.WriteLine($"{team.Name}");
                    Console.WriteLine($"- {team.Creator}");

                    foreach (var member in team.Member)
                    {
                        Console.WriteLine($"-- {member}");
                    }
                }
            }
        }

        static void AddMemberToAnExistingTeam(List<Team> listOfTeams, string teamName, string user)
        {
            foreach (var team in listOfTeams)
            {
                if (team.Name == teamName)
                {
                    team.Member.Add(user);
                }
            }
        }

        static bool IsTeamUserAlreadyInTheList(List<Team> listOfTeams, string currentTeamCreator)
        {
            foreach (var team in listOfTeams)
            {
                if (team.Creator == currentTeamCreator)
                {
                    return true;
                }
            }

            return false;
        }

        static bool isTeamNameExisting(List<Team> listOfTeams, string teamName)
        {
            foreach (var team in listOfTeams)
            {
                if (teamName == team.Name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}