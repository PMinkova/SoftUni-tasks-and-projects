namespace Heroes.Models.Heroes
{
    using System;
    using System.Text;

    using Contracts;

    public abstract class Hero : IHero
    {
        private string name;
        private int health;
        private int armour;
        private IWeapon weapon;

        public Hero(string name, int health, int armour)
        {
            this.Name = name;
            this.Health = health;
            this.Armour = armour;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Hero name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public int Health
        {
            get => this.health;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hero health cannot be below 0.");
                }

                this.health = value;
            }
        }

        public int Armour
        {
            get => this.armour;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hero armour cannot be below 0.");
                }

                this.armour = value;
            }
        }

        public IWeapon Weapon
        {
            get => this.weapon;
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("Weapon cannot be null.");
                }

                this.weapon = value;
            }
        }

        public bool IsAlive => this.health > 0;

        public void TakeDamage(int points)
        {
            var pointsAfterDamage = points - this.Armour;

            if (pointsAfterDamage >= 0)
            {
                this.Armour = 0;
                this.Health = this.Health - pointsAfterDamage > 0 ? this.Health - pointsAfterDamage : 0;
            }
            else
            {
                this.Armour -= points;
            }
        }

        public void AddWeapon(IWeapon weapon)
        {
            this.Weapon = weapon;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            var weaponName = this.Weapon != null ? this.Weapon.Name : "Unarmed";

            sb
                .AppendLine($"{this.GetType().Name}: {this.Name}")
                .AppendLine($"--Health: {this.Health}")
                .AppendLine($"--Armour: {this.Armour}")
                .AppendLine($"--Weapon: {weaponName}");

            return sb.ToString().TrimEnd();
        }
    }
}