using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
		private string name;
        private decimal money;
        private List<Product> bag;

        public Person()
        {
            this.bag = new List<Product>();
        }

        public Person(string name, decimal price) : this()
        {
            this.Name = name;
            this.Money = price;
        }

		public string Name
		{
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                this.name = value;
            }
		}

        public decimal Money 
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.money = value;
            }
        }


        public void BuyProduct(Product product)
        {
            if (this.Money - product.Cost >= 0)
            {
                this.bag.Add(product);
                this.Money -= product.Cost;
                Console.WriteLine($"{name} bought {product}");
            }
            else
            {
                Console.WriteLine($"{name} can't afford {product}");
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append($"{this.Name} - ");
            sb.Append(this.bag.Count > 0 ? String.Join(", ", this.bag) : "Nothing bought ");

            return sb.ToString().TrimEnd();
        }
    }
}
