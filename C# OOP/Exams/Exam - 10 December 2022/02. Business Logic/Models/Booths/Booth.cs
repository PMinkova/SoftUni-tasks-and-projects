namespace ChristmasPastryShop.Models.Booths
{
    using System;
    using System.Text;

    using Cocktails.Contracts;
    using Contracts;
    using Delicacies.Contracts;
    using Repositories;
    using Repositories.Contracts;

    public class Booth : IBooth
    {
        private int capacity;

        public Booth(int boothId, int capacity)
            : this()
        {
            this.BoothId = boothId;
            this.Capacity = capacity;
        }
        private Booth()
        {
            this.DelicacyMenu = new DelicacyRepository();
            this.CocktailMenu = new CocktailRepository();
        }

        public int BoothId { get; }

        public int Capacity
        {
            get => this.capacity;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Capacity has to be greater than 0!");
                }

                this.capacity = value;
            }
        }
        public IRepository<IDelicacy> DelicacyMenu { get; }

        public IRepository<ICocktail> CocktailMenu { get; }

        public double CurrentBill { get; private set; }

        public double Turnover { get; private set; }

        public bool IsReserved { get; private set; }

        public void UpdateCurrentBill(double amount)
        {
            this.CurrentBill += amount;
        }

        public void Charge()
        {
            this.Turnover += this.CurrentBill;
            this.CurrentBill = 0;
        }

        public void ChangeStatus()
        {
            this.IsReserved = !this.IsReserved;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb
                .AppendLine($"Booth: {this.BoothId}")
                .AppendLine($"Capacity: {this.Capacity}")
                .AppendLine($"Turnover: {this.Turnover:F2} lv")
                .AppendLine($"-Cocktail menu:");

            foreach (var cocktail in this.CocktailMenu.Models)
            {
                sb.AppendLine($"--{cocktail}");
            }

            sb.AppendLine("-Delicacy menu:");

            foreach (var delicacy in this.DelicacyMenu.Models)
            {
                sb.AppendLine($"--{delicacy}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
