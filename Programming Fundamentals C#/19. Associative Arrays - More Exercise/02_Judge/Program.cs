using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Tracing;

namespace _02_Judge
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> courses = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, Dictionary<string, int>> participants = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "no more time")
            {
                string[] commandArgs = input.Split(" -> ");

                string username = commandArgs[0];
                string contest = commandArgs[1];
                int points = int.Parse(commandArgs[2]);

                if (!participants.ContainsKey(username)) // if participant`s attending a contest for a first time
                {
                    participants.Add(username, new Dictionary<string, int>());
                    participants[username].Add(contest, points);
                }
                else // if participant attends a contest for a second time
                {
                    if (participants[username].ContainsKey(contest)) // if attending same contest, take the higher score
                    {
                        if (points > participants[username][contest])
                        {
                            participants[username][contest] = points;
                        }
                    }
                    else
                    {
                        participants[username].Add(contest, points); 
                    }
                }

                if (courses.ContainsKey(contest))
                {
                    if (courses[contest].ContainsKey(username)) // If the participant is in the list, take the higher score.
                    {
                        if (points > courses[contest][username])
                        {
                            courses[contest][username] = points;
                        }
                    }
                    else
                    {
                        courses[contest].Add(username, points); // If the participant is not int the list, add it.
                    }
                }
                else
                {
                    courses.Add(contest, new Dictionary<string, int>());
                    courses[contest].Add(username, points);
                }

                input = Console.ReadLine();
            }

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count} participants");

                int counter = 1;

                foreach (var participant in course.Value.OrderByDescending(p => p.Value).ThenBy(p => p.Key))
                {
                    Console.WriteLine($"{counter}. {participant.Key} <::> {participant.Value}");
                    counter++;
                }
            }

            Console.WriteLine("Individual standings:");

            int count = 1;
            foreach (var participant in participants.OrderByDescending(p => p.Value.Values.Sum()).ThenBy(p => p.Key))
            {
                Console.Write($"{count}. {participant.Key} -> {participant.Value.Values.Sum()}");
                count++;
                Console.WriteLine();
            }
        }
    }
}
