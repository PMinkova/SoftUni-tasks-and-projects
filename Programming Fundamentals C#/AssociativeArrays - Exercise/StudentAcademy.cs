using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            var studentDiary = new Dictionary<string, List<double>>();

            for (int i = 0; i < rows; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentDiary.ContainsKey(student))
                {
                    studentDiary.Add(student, new List<double>());
                }

                studentDiary[student].Add(grade);
            }

            foreach (var student in studentDiary.Where(x => x.Value.Average() >= 4.5).OrderByDescending(x => x.Value.Average()))
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
            }
        }
    }
}

