using System;
using System.Collections.Generic;
using System.Linq;

namespace P08_Ranking
{
    class Ranking
    {
        static void Main(string[] args)
        {
            var validationData = new Dictionary<string, string>();
            var studentsInfo = new SortedDictionary<string, Dictionary<string, int>>();

            var input = Console.ReadLine();

            while (input != "end of contests")
            {
                var inputArgs = input.Split(":", StringSplitOptions.RemoveEmptyEntries);

                var contest = inputArgs[0];
                var password = inputArgs[1];

                if (!validationData.ContainsKey(contest))
                {
                    validationData.Add(contest, password);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "end of submissions")
            {
                var inputArgs = input.Split("=>");

                var contest = inputArgs[0];
                var password = inputArgs[1];
                var username = inputArgs[2];
                var points = int.Parse(inputArgs[3]);
                var isContestValid = validationData.ContainsKey(contest) && validationData.ContainsValue(password);

                AddStudentsContestsWithPoints(isContestValid, studentsInfo, username, contest, points);

                input = Console.ReadLine();
            }

            var maxResult = 0;
            var bestcandidate = String.Empty;

            maxResult = FindBestCandidateWithMaxResult(studentsInfo, maxResult, ref bestcandidate);

            Console.WriteLine($"Best candidate is {bestcandidate} with total {maxResult} points.");
            Console.WriteLine("Ranking:");

            PrintAllStudentsWithResults(studentsInfo);
        }

        private static void AddStudentsContestsWithPoints(bool isContestValid, SortedDictionary<string, Dictionary<string, int>> studentsInfo, string username,
            string contest, int points)
        {
            if (isContestValid)
            {
                if (!studentsInfo.ContainsKey(username))
                {
                    studentsInfo.Add(username, new Dictionary<string, int>());
                }

                if (!studentsInfo[username].ContainsKey(contest))
                {
                    studentsInfo[username].Add(contest, points);
                }
                else if (studentsInfo[username][contest] < points)
                {
                    studentsInfo[username][contest] = points;
                }
            }
        }

        private static int FindBestCandidateWithMaxResult(SortedDictionary<string, Dictionary<string, int>> studentsInfo, int maxResult,
            ref string bestcandidate)
        {
            foreach (var (name, contests) in studentsInfo)
            {
                var sumResult = 0;

                foreach (var (contest, points) in contests)
                {
                    sumResult += points;
                }

                if (sumResult > maxResult)
                {
                    maxResult = sumResult;
                    bestcandidate = name;
                }
            }

            return maxResult;
        }

        private static void PrintAllStudentsWithResults(SortedDictionary<string, Dictionary<string, int>> studentsInfo)
        {
            foreach (var (username, contests) in studentsInfo)
            {
                Console.WriteLine($"{username}");

                foreach (var (contest, points) in contests.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest} -> {points}");
                }
            }
        }
    }
}
