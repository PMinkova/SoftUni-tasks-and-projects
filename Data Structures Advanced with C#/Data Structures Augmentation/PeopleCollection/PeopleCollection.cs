namespace CollectionOfPeople
{
    using System;
    using System.Collections.Generic;

    public class PeopleCollection : IPeopleCollection
    {
        public int Count => throw new NotImplementedException();

        public bool Add(string email, string name, int age, string town)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string email)
        {
            throw new NotImplementedException();
        }

        public Person Find(string email)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> FindPeople(string emailDomain)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> FindPeople(string name, string town)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> FindPeople(int startAge, int endAge)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> FindPeople(int startAge, int endAge, string town)
        {
            throw new NotImplementedException();
        }
    }
}
