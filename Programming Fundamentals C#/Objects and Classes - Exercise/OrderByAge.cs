using System;
using System.Linq;
using System.Collections.Generic;

namespace _07_OrderByAge
{
    class Person
    {
        public string Name { get; set; }

        public string Id { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{this.Name} with ID: {this.Id} is {this.Age} years old.";
        }
    }

    class OrderByAge
    {
        static void Main()
        {
            string input = Console.ReadLine();

            List<Person> people = new List<Person>();

            while (input != "End")
            {
                string[] data = input.Split();

                string name = data[0];
                string id = data[1];
                int age = int.Parse(data[2]);

                Person person = new Person();

                person.Name = name;
                person.Id = id;
                person.Age = age;

                people.Add(person);

                input = Console.ReadLine();
            }

            people.OrderBy(x => x.Age).ToList().ForEach(x => Console.WriteLine(x));
            
        }
    }
}
