namespace _01.DogVet
{
    using System.Collections.Generic;

    public class Owner
    {
        public Owner(string id, string name)
        {
            this.Id = id;
            this.Name = name;
            this.Dogs = new Dictionary<string, Dog>();
        }

        public Dictionary<string, Dog> Dogs;

        public string Id { get; set; }

        public string Name { get; set; }

    }
}