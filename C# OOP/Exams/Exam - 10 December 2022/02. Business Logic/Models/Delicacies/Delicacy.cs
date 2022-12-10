namespace ChristmasPastryShop.Models.Delicacies
{
    using System;

    using Contracts;

    public abstract class Delicacy : IDelicacy
    {
        private string name;

        protected Delicacy(string delicacyName, double price)
        {
            this.Name = delicacyName;
            this.Price = price;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or whitespace!");
                }

                this.name = value;
            }
        }
        public double Price { get; private set; }

        public override string ToString()
        {
            return $"{this.Name} - {this.Price:F2} lv";
        }
    }
}
