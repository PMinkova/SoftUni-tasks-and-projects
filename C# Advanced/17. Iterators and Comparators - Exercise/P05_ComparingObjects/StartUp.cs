using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace P05_ComparingObjects
{
    public class StartUp
    {
        static void Main()
        {
            var people = new List<Person>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                var personInfo = input.Split();

                var name = personInfo[0];
                var age = int.Parse(personInfo[1]);
                var town = personInfo[2];

                people.Add(new Person(name, age, town));
            }

            var index = int.Parse(Console.ReadLine()) - 1;

            var personToCompare = people[index];
            var matchesCount = 0;

            foreach (var person in people)
            {
                if (personToCompare.CompareTo(person) == 0)
                {
                    matchesCount++;
                }
            }


            if (matchesCount <= 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                var notMatched = people.Count - matchesCount;
                Console.WriteLine($"{matchesCount} {notMatched} {people.Count}");
            }
        }
    }
}
