using System;
using System.Linq;
using System.Collections.Generic;

namespace _10_SoftUniExamResults
{
    class SotUniExamResults
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var results = new Dictionary<string, int>();
            var submissions = new Dictionary<string, int>();

            while (input != "exam finished")
            {
                string[] tokens = input.Split("-");

                string username = tokens[0];

                if (tokens.Length > 2)
                {
                    string language = tokens[1];
                    int points = int.Parse(tokens[2]);

                    if (!results.ContainsKey(username))
                    {
                        results.Add(username, 0);
                    }

                    if (points > results[username])
                    {
                        results[username] = points;
                    }

                    if (!submissions.ContainsKey(language))
                    {
                        submissions.Add(language, 0);
                    }

                    submissions[language]++;
                }
                else
                {
                    results.Remove(username);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Results:");

            foreach (var kvp in results.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var language in submissions.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}
