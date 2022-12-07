namespace WarCroft.Entities.Characters
{
    using System;
    using Constants;
    using Contracts;
    using Inventory;

    public class Warrior : Character, IAttacker
    {
        private const double BaseHealth = 100;
        private const double BaseArmor = 50;
        private const double AbilityPoints = 40;

        public Warrior(string name)
            : base(name, BaseHealth, BaseArmor, AbilityPoints, new Satchel())
        {

        }

        public void Attack(Character character)
        {
            this.EnsureAlive();

            if (!character.IsAlive)
            {
                throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
            }

            if (this.Equals(character))
            {
                throw new InvalidOperationException(ExceptionMessages.CharacterAttacksSelf);
            }

            character.TakeDamage(AbilityPoints);
        }
    }
}
