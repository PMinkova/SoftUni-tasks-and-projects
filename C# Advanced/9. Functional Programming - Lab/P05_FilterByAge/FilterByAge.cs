using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

namespace P05_FilterByAge
{
    class FilterByAge
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());

            Dictionary<string, int> people = new Dictionary<string, int>();

            for (int i = 0; i < peopleCount; i++)
            {
                string[] personInfo = Console.ReadLine().Split(", ");
                string name = personInfo[0];
                int ageOfThePerson = int.Parse(personInfo[1]);

                people.Add(name, ageOfThePerson);
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<int, bool> filterAge = CreateFilter(condition, age);
            Action<KeyValuePair<string, int>> write = CreateWriter(format);

            foreach (var kvp in people)
            {
                if (filterAge(kvp.Value))
                {
                    write(kvp);
                }
            }
        }

        static Action<KeyValuePair<string, int>> CreateWriter(string format)
        {
            switch (format)
            {                                                                  
                case "name":                                                   
                    return x => Console.WriteLine(x.Key);                      
                case "age":                                                    
                    return x => Console.WriteLine(x.Value);                    
                default:                                                       
                    return x => Console.WriteLine($"{x.Key} -> {x.Value}");    
            }                                                                  
        }                                                                      
                                                                               
        static Func<int, bool> CreateFilter(string condition, int age)
        {
            if (condition == "older")
            {
                return x => x >= age;
            }

            return x => x < age;
        }
    }
}
