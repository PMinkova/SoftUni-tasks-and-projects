namespace CollectionOfPeople
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;

    public class PeopleCollectionSlow : IPeopleCollection
    {
        private List<Person> people;

        public PeopleCollectionSlow()
        {
            this.people = new List<Person>();
        }

        public int Count => this.people.Count;


        public bool Add(string email, string name, int age, string town)
        {
            if (this.Find(email) != null)
            {
                return false;
            }

            this.people.Add(new Person(email, name, age, town));
            return true;
        }

        public bool Delete(string email)
        {
            var person = this.Find(email);

            return this.people.Remove(person);
        }

        public Person Find(string email)
        {
            return this.people.FirstOrDefault(p => p.Email == email);
        }

        public IEnumerable<Person> FindPeople(string emailDomain)
        {
            return this.people
                .Where(p => p.Email.EndsWith($"@{emailDomain}"))
                .OrderBy(p => p.Email);
        }

        public IEnumerable<Person> FindPeople(string name, string town)
        {
            return this.people
                .Where(p => p.Name == name && p.Town == town)
                .OrderBy(p => p.Email);
        }

        public IEnumerable<Person> FindPeople(int startAge, int endAge)
        {
            return this.people.Where(p => p.Age >= startAge && p.Age <= endAge)
                .OrderBy(p => p.Age)
                .ThenBy(p => p.Email);
        }

        public IEnumerable<Person> FindPeople(int startAge, int endAge, string town)
        {
            return this.FindPeople(startAge, endAge)
                .Where(p => p.Town == town)
                .OrderBy(p => p.Age)
                .ThenBy(p => p.Email);
        }
    }
}
