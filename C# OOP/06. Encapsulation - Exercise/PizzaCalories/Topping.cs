using System;
using System.Collections;

namespace PizzaCalories
{
    public class Topping
    {
        private const double BaseCaloriesPerGram = 2;
        private const double MinimalToppingWeight = 1;
        private const double MaximalToppingWeight = 100;

        private const double MeatModifier = 1.2;
        private const double VeggiesModifier = 0.8;
        private const double CheeseModifier = 1.1;
        private const double SauceModifier = 0.9;

        private string toppingType;
        private double grams;

        public Topping(string toppingType, double grams)
        {
            this.ToppingType = toppingType;
            this.Grams = grams;
        }

        public string ToppingType
        {
            get
            {
                return this.toppingType;
            }
            private set
            {
                if (value.ToLower() != "meat" 
                    && value.ToLower() != "veggies" 
                    && value.ToLower() != "cheese"
                    && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.toppingType = value;
            }
        }

        public double Grams
        {
            get
            {
                return this.grams;
            }
            private set
            {
                if (value < MinimalToppingWeight || value > MaximalToppingWeight)
                {
                    throw new ArgumentException($"{this.ToppingType} weight should be in the range [1..50].");
                }

                this.grams = value;
            }
        }

        public double Calories => this.CalculateCalories();

        private double CalculateCalories()
        {
            var modifier = 0.0;

            switch (this.ToppingType.ToLower())
            {
                case "meat":
                    modifier = MeatModifier;
                    break;
                case "veggies":
                    modifier = VeggiesModifier;
                    break;
                case "cheese":
                    modifier = CheeseModifier;
                    break;
                case "sauce":
                    modifier = SauceModifier ;
                    break;
            }

            var totalCalories = modifier * this.Grams * BaseCaloriesPerGram;

            return totalCalories;
        }
    }
}
