namespace Formula1.Models
{
    using System;

    using Contracts;
    using Utilities;

    public abstract class FormulaOneCar : IFormulaOneCar
    {
        private const int MinModelLength = 3;
        private const int MinHorsepowerValue = 900;
        private const int MaxHorsepowerValue = 1050;

        private const double MinEngineDisplacement = 1.6;
        private const double MaxEngineDisplacement = 2.0;

        private string model;
        private int horsepower;
        private double engineDisplacement;

        public FormulaOneCar(string model, int horsepower, double engineDisplacement)
        {
            this.Model = model;
            this.Horsepower = horsepower;
            this.EngineDisplacement = engineDisplacement;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value) || value.Length < MinModelLength)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidF1CarModel, value));
                }

                this.model = value;
            }
        }

        public int Horsepower
        {
            get
            {
                return this.horsepower;
            }
            private set
            {
                if (value < MinHorsepowerValue || MaxHorsepowerValue < value)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidF1HorsePower, value));
                }

                this.horsepower = value;
            }
        }

        public double EngineDisplacement
        {
            get
            {
                return this.engineDisplacement;
            }
            private set
            {
                if (value < MinEngineDisplacement || MaxEngineDisplacement < value)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidF1EngineDisplacement, value));
                }

                this.engineDisplacement = value;
            }
        }
        public double RaceScoreCalculator(int laps)
        {
            return this.EngineDisplacement / this.Horsepower * laps;
        }
    }
}
