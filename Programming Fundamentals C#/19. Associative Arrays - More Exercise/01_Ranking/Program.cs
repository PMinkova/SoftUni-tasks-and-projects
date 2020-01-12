using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, string> contests = new Dictionary<string, string>();
            SortedDictionary<string, Dictionary<string, int>> users = new SortedDictionary<string, Dictionary<string, int>>();

            while (input != "end of contests")
            {
                string[] contestsData = input.Split(":");

                string nameOfContest = contestsData[0];
                string password = contestsData[1];

                contests.Add(nameOfContest, password);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "end of submissions")
            {
                string[] sumbissionsData = input.Split("=>");

                string nameOfContest = sumbissionsData[0];
                string password = sumbissionsData[1];
                string userName = sumbissionsData[2];
                int points = int.Parse(sumbissionsData[3]);

                bool isContestValid = contests.ContainsKey(nameOfContest);
                bool isPassWordCorrect = false;

                if (isContestValid && contests.ContainsValue(password))
                {
                    isPassWordCorrect = true;
                }

                if (isContestValid && isPassWordCorrect)
                {
                    if (users.ContainsKey(userName))
                    {
                        if (users[userName].ContainsKey(nameOfContest) && points > users[userName][nameOfContest])
                        {
                            users[userName][nameOfContest] = points;
                        }
                        else if (!users[userName].ContainsKey(nameOfContest))
                        {
                            users[userName].Add(nameOfContest, points);
                        }
                    }
                    else
                    {
                        users.Add(userName, new Dictionary<string, int>());
                        users[userName].Add(nameOfContest, points);
                    }
                }

                input = Console.ReadLine();
            }

            Dictionary<string, int> usersTotalPoints = new Dictionary<string, int>();

            foreach (var kvp in users)
            {
                usersTotalPoints[kvp.Key] = kvp.Value.Values.Sum();
            }

            string bestCandidat = String.Empty;
            int maxPoints = 0;

            foreach (var kvp in usersTotalPoints)
            {
                if (kvp.Value > maxPoints)
                {
                    maxPoints = kvp.Value;
                    bestCandidat = kvp.Key;
                }
            }

            Console.WriteLine($"Best candidate is {bestCandidat} with total {maxPoints} points.");
            Console.WriteLine("Ranking:");

            foreach (var kvp in users)
            {
                Console.WriteLine(kvp.Key);

                foreach (var contest in kvp.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}

