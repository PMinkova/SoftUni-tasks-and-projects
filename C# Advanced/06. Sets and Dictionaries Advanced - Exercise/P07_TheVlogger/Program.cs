using System;
using System.Linq;
using System.Collections.Generic;

namespace P07_TheVlogger
{
    class Program
    {
        static void Main(string[] args)
        {
            var vloggerFollowings = new Dictionary<string, List<string>>();
            var vloggerFollowers = new Dictionary<string, List<string>>();

            var input = Console.ReadLine();

            while (input != "Statistics")
            {
                var inputInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var vloggername = inputInfo[0];

                if (inputInfo.Contains("joined"))
                {
                    if (!vloggerFollowers.ContainsKey(vloggername))
                    {
                        vloggerFollowers.Add(vloggername, new List<string>());
                        vloggerFollowings.Add(vloggername, new List<string>());
                    }
                }
                else
                {
                    var followedVlogger = inputInfo[2];

                    if (vloggerFollowers.ContainsKey(followedVlogger) &&
                        vloggerFollowings.ContainsKey(vloggername) &&
                        vloggername != followedVlogger &&
                        !vloggerFollowings[vloggername].Contains(followedVlogger))
                    {
                        vloggerFollowings[vloggername].Add(followedVlogger);
                        vloggerFollowers[followedVlogger].Add(vloggername);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {vloggerFollowers.Count} vloggers in its logs.");

            var vloggersRanking = 1;

            foreach (var kvp in vloggerFollowers.OrderByDescending(x => x.Value.Count).ThenBy(x => vloggerFollowings[x.Key].Count))
            {
                var vlogger = kvp.Key;
                var totatalFollowers = vloggerFollowers[vlogger].Count;
                var totalFollowings = vloggerFollowings[vlogger].Count;
                
                Console.WriteLine($"{vloggersRanking}. {vlogger} : {totatalFollowers} followers, {totalFollowings} following");

                if (vloggersRanking == 1)
                {
                    vloggerFollowers[kvp.Key].OrderBy(x => x).ToList().ForEach(x => Console.WriteLine($"*  {x}"));
                }

                vloggersRanking++;
            }
        }
    }
}
