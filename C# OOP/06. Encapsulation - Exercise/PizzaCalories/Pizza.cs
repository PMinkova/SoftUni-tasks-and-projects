using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppingList;

        public Pizza()
        {
            toppingList = new List<Topping>();
        }

        public Pizza(string name) : this()
        {
            this.Name = name;
        }

        public Dough Dough
        {
            get
            {
                return this.dough;
            }
            set
            {
                this.dough = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value)
                    || value.Length < 0 
                    || 15 < value.Length)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }

        public double TotalCalories => CalculateCalories();

        public int ToppingsCount => this.toppingList.Count;

        public void AddTopping(Topping topping)
        {
            if (toppingList.Count > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            
            this.toppingList.Add(topping);
        }

        private double CalculateCalories()
        {
            var toppingCalories = this.toppingList.Select(t => t.Calories).Sum();
            return toppingCalories + this.dough.Calories;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.TotalCalories:F2} Calories.";
        }
    }
}
