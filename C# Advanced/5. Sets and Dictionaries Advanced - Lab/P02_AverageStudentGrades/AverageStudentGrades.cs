using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_AverageStudentGrades
{
    class AverageStudentsGrades
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] splitedInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = splitedInput[0];
                double grade = double.Parse(splitedInput[1]);

                if (!studentGrades.ContainsKey(name))
                {
                    studentGrades.Add(name, new List<double>());
                }

                studentGrades[name].Add(grade);
            }

            PrintStudentGrades(studentGrades);
        }

        private static void PrintStudentGrades(Dictionary<string, List<double>> studentGrades)
        {
            foreach (var student in studentGrades)
            {
                Console.Write($"{student.Key} -> ");

                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.Write($"(avg: {student.Value.Average():f2})");
                Console.WriteLine();
            }
        }
    }
}
