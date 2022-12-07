namespace WarCroft.Entities.Characters.Contracts
{
    using System;

    using Constants;
    using Inventory;
    using Items;

    public abstract class Character
    {
        private string name;
        private double health;
        private double armor;

        protected Character(string name, double health, double armor, double abilityPoints, Bag bag)
        {
            this.Name = name;
            this.BaseHealth = health;
            this.Health = health;
            this.BaseArmor = armor;
            this.Armor = armor;
            this.AbilityPoints = abilityPoints;
            this.Bag = bag;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.CharacterNameInvalid);
                }

                this.name = value;
            }
        }

        public double BaseHealth { get; private set; }

        public double BaseArmor { get; private set; }

        public double Armor
        {
            get => this.armor;
            set
            {
                if (value >= 0)
                {
                    this.armor = value;
                }
                else
                {
                    this.armor = 0;
                }
            }
        }

        public double Health
        {
            get => this.health;
            set
            {
                if (value < 0)
                {
                    health = 0;
                }
                else if (value > this.BaseHealth)
                {
                    value = this.BaseHealth;
                }
                else
                {
                    this.health = value;
                }
            }
        }

        public double AbilityPoints { get; set; }

        public Bag Bag { get; private set; }

        public bool IsAlive { get; set; } = true;

        protected void EnsureAlive()
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
            }
        }

        public void TakeDamage(double hitPoints)
        {
            this.EnsureAlive();

            var initialArmor = this.Armor;
            this.Armor -= hitPoints;

            var pointsLeft = hitPoints - initialArmor;

            if (pointsLeft > 0)
            {
                this.Health -= pointsLeft;
            }

            this.IsAlive = this.Health > 0;
        }

        public void UseItem(Item item)
        {
            this.EnsureAlive();
            item.AffectCharacter(this);
        }

        public override string ToString()
        {
            var status = this.IsAlive ? "Alive" : "Dead";

            return String.Format(SuccessMessages.CharacterStats,
                this.Name,
                this.Health,
                this.BaseHealth,
                this.Armor,
                this.BaseArmor,
                status);
        }
    }
}
