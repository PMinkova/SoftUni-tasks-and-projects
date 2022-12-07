namespace WarCroft.Entities.Characters
{
    using System;

    using Constants;
    using Contracts;
    using Inventory;

    public class Priest : Character, IHealer
    {
        private const double BaseHealth = 50;
        private const double BaseArmor = 25;
        private const double AbilityPoints = 40;

        public Priest(string name)
            : base(name, BaseHealth, BaseArmor, AbilityPoints, new Backpack())
        {

        }

        public void Heal(Character character)
        {
            this.EnsureAlive();

            if (!character.IsAlive)
            {
                throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
            }

            character.Health += AbilityPoints;
        }
    }
}
