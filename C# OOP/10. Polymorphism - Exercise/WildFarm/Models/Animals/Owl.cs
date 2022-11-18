namespace WildFarm.Models.Animals
{
    using System;
    using System.Collections.Generic;

    using Food;

    public class Owl : Bird
    {
        private const double OwlWeightMultiplier = 0.25;

        public Owl(string name, double weight, double wingSize) :
            base(name, weight, wingSize)
        {
        }

        protected override double WeightMultiplier
            => OwlWeightMultiplier;

        public override IReadOnlyCollection<Type> PrefferedFoods 
            => new HashSet<Type> {typeof(Meat)};

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
    }
}
