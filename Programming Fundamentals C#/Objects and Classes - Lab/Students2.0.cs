using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices;

namespace _05_Students
{
    class Student
    {
        public Student(string firstName, string lastName, int age, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = city;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>()
                ;
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] studentsInfo = input.Split();

                string firstName = studentsInfo[0];
                string lastName = studentsInfo[1];
                int age = int.Parse(studentsInfo[2]);
                string city = studentsInfo[3];

                bool isStudentExisting = CheckStudentForPresence(firstName, lastName, students);

                if (isStudentExisting)
                {
                    ChangeStudentInfo(students, firstName, lastName, age, city);
                }
                else
                {
                    students.Add(new Student(firstName, lastName, age, city));
                }

                input = Console.ReadLine();
            }

            string homeTown = Console.ReadLine();

            PrintStudents(students, homeTown);
        }

        private static void PrintStudents(List<Student> students, string homeTown)
        {
            students.Where(s => s.HomeTown == homeTown)
                .ToList().ForEach(s => Console.WriteLine($"{s.FirstName} {s.LastName} is {s.Age} years old."));
        }

        static void ChangeStudentInfo(List<Student> students, string firstName, string lastName, int age, string city)
        {
            foreach (var student in students.Where(s => s.FirstName == firstName && s.LastName == lastName))
            {
                student.Age = age;
            }
        }

        static bool CheckStudentForPresence(string firstName, string lastName, List<Student> students)
        {
            foreach (var student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
