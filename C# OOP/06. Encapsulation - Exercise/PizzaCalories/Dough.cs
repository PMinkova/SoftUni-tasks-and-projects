using System;

namespace PizzaCalories
{
    public class Dough
    {
        private const double BaseCaloriesPerGram = 2;
        private const double MinimalDoughWeight = 1;
        private const double MaximalDoughWeight = 200;

        private const double WhiteFlowerModifier = 1.5;
        private const double WholegrainModifier = 1.0;
        private const double CrispyModifier = 0.9;
        private const double ChewyModifier = 1.1;
        private const double HomemadeModifier = 1.0;

        private string flowerType;
        private string bakingTechnique;
        private double grams;

        public Dough(string flowerType, string bakingTechnique, double grams)
        {
            this.FlowerType = flowerType;
            this.BakingTechnique = bakingTechnique;
            this.Grams = grams;
        }

        public string FlowerType
        {
            get
            {
                return this.flowerType;
            }
            private set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flowerType = value;
            }
        }

        public string BakingTechnique
        {
            get
            {
                return this.bakingTechnique;
            }
            private set
            {
                if (value.ToLower() != "crispy" 
                    && value.ToLower() != "chewy" 
                    && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.bakingTechnique = value;
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
                if (value < MinimalDoughWeight || value > MaximalDoughWeight)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                this.grams = value;
            }
        }

        public double Calories => this.CalculateCalories();

        private double CalculateCalories()
        {
            var flowerModifier = 0.0;

            switch (this.FlowerType.ToLower())
            {
                case "white":
                    flowerModifier = WhiteFlowerModifier;
                    break;
                case "wholegrain":
                    flowerModifier = WholegrainModifier;
                        break;
            }

            var bakingTechiqueModifier = 0.0;

            switch (this.BakingTechnique.ToLower())
            {
                case "crispy":
                    bakingTechiqueModifier = CrispyModifier;
                    break;
                case "chewy":
                    bakingTechiqueModifier = ChewyModifier;
                    break;
                case "homemade":
                    bakingTechiqueModifier = HomemadeModifier;
                    break;
            }

            var totalCalories = BaseCaloriesPerGram * flowerModifier * bakingTechiqueModifier * this.Grams;
            return totalCalories;
        }
    }
}
