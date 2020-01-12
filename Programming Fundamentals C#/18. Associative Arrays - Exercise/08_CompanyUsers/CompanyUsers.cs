using System;
using System.Linq;
using System.Collections.Generic;

namespace _08_CompanyUsers
{
    class CompanyUsers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var companiesInfo = new SortedDictionary<string, List<string>>();

            while (input != "End")
            {
                string[] data = input.Split();

                string company = data[0];
                string employeeId = data[2];

                if (!companiesInfo.ContainsKey(company))
                {
                    companiesInfo.Add(company, new List<string>());
                }

                if (!companiesInfo[company].Contains(employeeId))
                {
                    companiesInfo[company].Add(employeeId);
                }

                input = Console.ReadLine();
            }

            foreach (var company in companiesInfo)
            {
                Console.WriteLine(company.Key);
                company.Value.ForEach(c => Console.WriteLine($"-- {c}"));
            }
        }
    }
}
