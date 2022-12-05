namespace Formula1.Models
{
    using Contracts;
    using Utilities;
    using System;

    public class Pilot : IPilot
    {
        private const int FullNameLength = 5;

        private string fullName;
        private IFormulaOneCar car;

        public Pilot(string fullName)
        {
            this.FullName = fullName;
        }

        public string FullName
        {
            get
            {
                return this.fullName;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value) || value.Length < FullNameLength)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidPilot, value));
                }

                this.fullName = value;
            }
        }

        public IFormulaOneCar Car
        {
            get
            {
                return this.car;
            }
            private set
            {
                if (value == null)
                {
                    throw new NullReferenceException(ExceptionMessages.InvalidCarForPilot);
                }

                this.car = value;
            }
        }

        public int NumberOfWins { get; private set; }

        public bool CanRace { get; private set; }

        public void AddCar(IFormulaOneCar car)
        {
            this.car = car;
            this.CanRace = true;
        }

        public void WinRace()
        {
            this.NumberOfWins++;
        }

        public override string ToString()
        {
            return $"Pilot {this.FullName} has {this.NumberOfWins} wins.";
        }
    }
}
