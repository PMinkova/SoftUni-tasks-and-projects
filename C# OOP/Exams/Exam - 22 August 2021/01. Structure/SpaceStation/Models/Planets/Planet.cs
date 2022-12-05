namespace SpaceStation.Models.Planets
{
    using System;
    using System.Collections.Generic;
    using Contracts;
    using Utilities.Messages;

    public class Planet : IPlanet
    {
        private string name;

        public Planet(string name) 
            : this()
        {
            this.Name = name;
        }

        private Planet()
        {
            this.Items = new List<string>();
        }

        public ICollection<string> Items { get; }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(Name), ExceptionMessages.InvalidPlanetName);
                }

                this.name = value;
            }
        }
        
    }
}
