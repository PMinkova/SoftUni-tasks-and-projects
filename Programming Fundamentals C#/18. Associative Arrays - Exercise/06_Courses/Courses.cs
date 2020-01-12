using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_Courses
{
    class Courses
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var courses = new Dictionary<string, List<string>>();

            while (input != "end")
            {
                string[] data = input.Split(" : ");

                string courseName = data[0];
                string studentName = data[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }

                courses[courseName].Add(studentName);
                input = Console.ReadLine();
            }

            foreach (var course in courses.OrderByDescending(x => x.Value.Count))
            {
                int registeredStudents = course.Value.Count;

                Console.WriteLine($"{course.Key}: {registeredStudents}");

                course.Value.Sort();

                foreach (var student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
