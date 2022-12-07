namespace WarCroft.Entities.Items
{
    using Characters.Contracts;

    public class FirePotion : Item
    {
        private const int DefaultWeight = 5;
        private const int HealthPoints = 20;

        public FirePotion()
            : base(DefaultWeight)
        {

        }

        public override void AffectCharacter(Character character)
        {
            base.AffectCharacter(character);

            character.Health -= HealthPoints;
        }
    }
}
