using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Teamwork
{
    class TeamworkProject
    {
        static void Main(string[] args)
        {
            int teamsCount = int.Parse(Console.ReadLine());
            List<Team> listOfTeams = new List<Team>();

            for (int i = 0; i < teamsCount; i++)
            {
                string[] teamInfoArr = Console.ReadLine().Split("-");
                string currentTeamCreator = teamInfoArr[0];
                string currentTeamName = teamInfoArr[1];

                if (CheckIfTeamNameIsPresent(listOfTeams, currentTeamName))
                {
                    Console.WriteLine($"Team {currentTeamName} was already created!");
                }

                else if (CheckIfTeamCreatorIsPresent(listOfTeams, currentTeamCreator))
                {
                    Console.WriteLine($"{currentTeamCreator} cannot create another team!");
                }

                else
                {
                    listOfTeams.Add(new Team(currentTeamCreator, currentTeamName));
                    Console.WriteLine($"Team {currentTeamName} has been created by {currentTeamCreator}!");
                }
            }

            string[] membersArr = Console.ReadLine().Split("->");

            while (membersArr[0] != "end of assignment")
            {
                string currentMemberName = membersArr[0];
                string currentTeamName = membersArr[1];

                if (CheckIfTeamCreatorIsPresent(listOfTeams, currentMemberName) && CheckIfTeamNameIsPresent(listOfTeams, currentTeamName))
                {
                    Console.WriteLine($"Member {currentMemberName} cannot join team {currentTeamName}!");
                }

                else if (CheckIfTeamNameIsPresent(listOfTeams, currentTeamName) == false)
                {
                    Console.WriteLine($"Team {currentTeamName} does not exist!");
                }
                else if (CheckIfMemberIsPresent(listOfTeams, currentMemberName))
                {
                    Console.WriteLine($"Member {currentMemberName} cannot join team {currentTeamName}!");
                }
                else if (CheckIfTeamNameIsPresent(listOfTeams, currentTeamName))
                {
                    int index = listOfTeams.FindIndex(team => team.TeamName.Equals(currentTeamName));
                    listOfTeams[index].Member.Add(currentMemberName);
                }

                membersArr = Console.ReadLine().Split("->");
            }

            foreach (Team team in listOfTeams.OrderByDescending(x => x.Member.Count).ThenBy(x => x.TeamName))
            {
                if (team.Member.Count > 0)
                {
                    Console.WriteLine(team);
                }
            }

            Console.WriteLine($"Teams to disband:");

            foreach (Team team in listOfTeams.OrderBy(x => x.TeamName))
            {
                if (team.Member.Count == 0)
                {
                    Console.WriteLine(team.TeamName);
                }
            }
        }

        static bool CheckIfMemberIsPresent(List<Team> listOfTeams, string teamMember)
        {
            foreach (Team team in listOfTeams)
            {
                foreach (string member in team.Member)
                {
                    if (member == teamMember)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        static bool CheckIfTeamCreatorIsPresent(List<Team> listOfTeams, string teamCreator)
        {
            foreach (Team team in listOfTeams)
            {
                if (teamCreator == team.Creator)
                {
                    return true;
                }
            }

            return false;
        }

        static bool CheckIfTeamNameIsPresent(List<Team> listOfTeams, string teamName)
        {
            foreach (Team team in listOfTeams)
            {
                if (teamName == team.TeamName)
                {
                    return true;
                }
            }

            return false;
        }

        class Team
        {
            public Team(string creator, string name)
            {
                Creator = creator;
                TeamName = name;
                Member = new List<string>();
            }
            public string TeamName { get; set; }
            public string Creator { get; set; }
            public List<string> Member { get; set; }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(TeamName)
                    .Append(Environment.NewLine)
                    .Append($"- {Creator}")
                    .Append(Environment.NewLine);

                Member.Sort();

                foreach (string member in Member)
                {
                    sb.Append($"-- {member}").Append(Environment.NewLine);
                }

                return sb.ToString().TrimEnd();
            }
        }
    }
}