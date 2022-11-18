namespace WildFarm.Models.Animals
{
    using System;
    using System.Collections.Generic;

    using Food;

    public class Mouse : Mammal
    {
        private const double MouseWeigthMultiplier = 0.10;

        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {

        }

        protected override double WeightMultiplier
            => MouseWeigthMultiplier;

        public override IReadOnlyCollection<Type> PrefferedFoods
            => new HashSet<Type>
                {typeof(Vegetable), typeof(Fruit)};

        public override string ProduceSound()
        {
            return "Squeak";
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
