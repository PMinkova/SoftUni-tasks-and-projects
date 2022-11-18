namespace WildFarm.Models.Animals
{
    using System;
    using System.Collections.Generic;

    using Food;

    public class Hen : Bird
    {
        private const double HenWeightMultiplier = 0.35;

        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {

        }

        protected override double WeightMultiplier
            => HenWeightMultiplier;

        // TODO Use Reflection!
        public override IReadOnlyCollection<Type> PrefferedFoods
            => new HashSet<Type>
                { typeof(Vegetable), typeof(Meat), typeof(Seeds), typeof(Fruit) };

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}
