using System;
using System.Collections.Generic;
using System.Linq;

namespace Concert
{
    class Concert
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> members = new Dictionary<string, List<string>>();
            Dictionary<string, int> timeOnStage = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "start of concert")
            {
                string[] commandArgs = input.Split("; ");

                string command = commandArgs[0];
                string bandName = commandArgs[1];

                AddNewBand(members, bandName, timeOnStage);

                switch (command)
                {
                    case "Add":
                    {
                        AddMembers(commandArgs, members, bandName);
                        break;
                    }
                    case "Play":
                    {
                        int time = int.Parse(commandArgs[2]);
                        IncreaseBandTime(timeOnStage, bandName, time);
                        break;
                    }
                }

                input = Console.ReadLine();
            }

            string lastBand = Console.ReadLine();

            PrintTotalBandTime(timeOnStage);

            PrintAllBandsAndTimes(timeOnStage);

            PrintBandWithMembers(lastBand, members);
        }

        private static void PrintBandWithMembers(string lastBand, Dictionary<string, List<string>> members)
        {
            Console.WriteLine(lastBand);

            members[lastBand].ForEach(x => Console.WriteLine($"=> {x}"));
        }

        private static void PrintAllBandsAndTimes(Dictionary<string, int> timeOnStage)
        {
            foreach (var band in timeOnStage.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{band.Key} -> {band.Value}");
            }
        }

        private static void PrintTotalBandTime(Dictionary<string, int> timeOnStage)
        {
            int totalTime = timeOnStage.Values.Sum();

            Console.WriteLine($"Total time: {totalTime}");
        }

        private static void IncreaseBandTime(Dictionary<string, int> timeOnStage, string bandName, int time)
        {
            timeOnStage[bandName] += time;
        }

        private static void AddMembers(string[] commandArgs, Dictionary<string, List<string>> members, string bandName)
        {
            string[] membersNames = commandArgs[2].Split(", ");

            for (int i = 0; i < membersNames.Length; i++)
            {
                string member = membersNames[i];

                if (!members[bandName].Contains(member))
                {
                    members[bandName].Add(member);
                }
            }
        }

        private static void AddNewBand(Dictionary<string, List<string>> members, string bandName, Dictionary<string, int> timeOnStage)
        {
            if (!members.ContainsKey(bandName))
            {
                members.Add(bandName, new List<string>());
                timeOnStage.Add(bandName, 0);
            }
        }
    }
}
