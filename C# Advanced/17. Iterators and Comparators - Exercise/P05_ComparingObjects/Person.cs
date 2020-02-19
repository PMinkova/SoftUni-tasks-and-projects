using System;
using System.Collections;

namespace P05_ComparingObjects
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }
        public string Name { get; set; }

        public int Age { get; set; }

        public string Town { get; set; }

        public int CompareTo(Person other)
        {
            var result = this.Name.CompareTo(this.Name);

            if (result == 0)
            {
                result = this.Age.CompareTo(other.Age);

                if (result == 0)
                { 
                    result = this.Name.CompareTo(other.Name);
                }
            }

            return result;
        }
    }
}
