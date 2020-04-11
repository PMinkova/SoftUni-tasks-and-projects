using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
   public class StartUp
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                var commandArgs = Console.ReadLine().Split();
                var firstName = commandArgs[0];
                var lastName = commandArgs[1];
                var age = int.Parse(commandArgs[2]);

                var person = new Person(firstName, lastName, age);
                persons.Add(person);
            }

            persons
                .OrderBy(p => p.FirstName)
                .ThenBy(p => p.LastName)
                .ToList()
                .ForEach(p => Console.WriteLine(p));
        }
    }
}
