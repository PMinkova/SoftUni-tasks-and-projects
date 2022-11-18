namespace WildFarm.Models.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Exceptions;
    using Interfaces;

    public abstract class Animal : IAnimal
    {
        protected Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name { get; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }

        protected abstract double WeightMultiplier { get; }

        public abstract IReadOnlyCollection<Type> PrefferedFoods { get; }

        public abstract string ProduceSound();

        public void Eat(IFood food)
        {
            if (!this.PrefferedFoods.Any(t => t.Name == food.GetType().Name))
            {
                var animalType = this.GetType().Name;
                var foodType = food.GetType().Name;

                throw new ArgumentException(string.Format(ExceptionMessages.FoodNotEatenExceptionMessage, animalType,
                    foodType));
            }

            this.FoodEaten += food.Quantity;
            this.Weight += food.Quantity * WeightMultiplier;
        }
    }
}
