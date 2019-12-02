using System;
using System.Collections.Generic;
using System.Linq;


namespace _04_Students
{
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());

            var students = new List<Student>(); 

            for (int i = 0; i < studentsCount; i++)
            {
                string[] data = Console.ReadLine().Split();

                string firstName = data[0];
                string lastName = data[1];
                double grade = double.Parse(data[2]);

                var student = new Student();

                student.FirstName = firstName;
                student.LastName = lastName;
                student.Grade = grade;

                students.Add(student);
            }

            var studentsOrderedByGrade = students.OrderByDescending(s => s.Grade);

            foreach (var student in studentsOrderedByGrade)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
