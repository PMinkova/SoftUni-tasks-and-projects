using System;
using System.Collections.Generic;
using System.Linq;


namespace _04_Students
{
    class Student
    {
        public Student(string firstName, string lastname, double grade)
        {
            FirstName = firstName;
            LastName = lastname;
            Grade = grade;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }

    class Students
    {
        static void Main()
        {
            List<Student> students = new List<Student>();

            int studentsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentsCount; i++)
            {
                string[] studentsInfo = Console.ReadLine().Split();

                string firstName = studentsInfo[0];
                string lastName = studentsInfo[1];
                double grade = double.Parse(studentsInfo[2]);

                students.Add(new Student(firstName, lastName, grade));
            }

            students.OrderByDescending(s => s.Grade).ToList().ForEach(s => Console.WriteLine(s));
        }
    }
}