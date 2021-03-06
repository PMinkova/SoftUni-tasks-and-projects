﻿using System;
using System.Collections.Generic;

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
                var salary = decimal.Parse(commandArgs[3]);
                try
                {
                    var person = new Person(firstName, lastName, age, salary);
                    persons.Add(person);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

            var percentage = decimal.Parse(Console.ReadLine());
            persons.ForEach(p => p.IncreaseSalary(percentage));
            persons.ForEach(p => Console.WriteLine(p));
        }
    }
}