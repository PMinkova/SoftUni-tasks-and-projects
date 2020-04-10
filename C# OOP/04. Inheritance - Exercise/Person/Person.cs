using System;
using System.Text;

namespace Person
{
    public class Person
    {
        private string name;

        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value <=0)
                {
                    throw new ArgumentException("Invalid age!");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            var stringBuileder = new StringBuilder();

            stringBuileder.Append(String.Format("Name: {0}, Age: {1}", this.Name, this.Age));
            return stringBuileder.ToString();
        }
    }
}

