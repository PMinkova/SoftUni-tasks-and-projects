namespace SpaceStation.Models.Astronauts
{
    using System;
    using System.Linq;
    using System.Text;

    using Bags;
    using Bags.Contracts;
    using Contracts;
    using Utilities.Messages;

    public abstract class Astronaut : IAstronaut
    {
        private const double OxygenUnitsDecrement = 10;
        private string name;
        private double oxygen;


        public Astronaut(string name, double oxygen) : this()
        {
            this.Name = name;
            this.Oxygen = oxygen;
        }

        private Astronaut()
        {
            this.Bag = new Backpack();
        }


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
                    throw new ArgumentNullException(nameof(Name), ExceptionMessages.InvalidAstronautName);
                }

                this.name = value;
            }
        }

        public double Oxygen
        {
            get
            {
                return this.oxygen;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidOxygen);
                }

                this.oxygen = value;
            }
        }

        public bool CanBreath
        {
            get
            {
                return this.Oxygen > 0;
            }
        }

        public IBag Bag { get; private set; }

        public virtual void Breath()
        {
            this.Oxygen -= OxygenUnitsDecrement;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            var bagItems = this.Bag.Items.Any() ? String.Join(", ", this.Bag.Items) : "none";

            sb
                .AppendLine($"Name: {this.Name}")
                .AppendLine($"Oxygen: {this.Oxygen}")
                .AppendLine($"Bag items: {bagItems}");

            return sb.ToString().TrimEnd();
        }
    }
}
