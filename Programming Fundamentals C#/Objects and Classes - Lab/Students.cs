using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _05_Students
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string City { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }
    }

    class Students
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split();

                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string city = tokens[3];

                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    City = city
                };

                students.Add(student);          
                input = Console.ReadLine();
            }

            string hometown = Console.ReadLine();


            foreach (var student in students)
            {
                if (student.City == hometown)
                {
                    Console.WriteLine(student);
                }
            }
        }
    }
}
