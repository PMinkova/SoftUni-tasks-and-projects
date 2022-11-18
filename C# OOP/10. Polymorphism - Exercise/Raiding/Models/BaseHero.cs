namespace Raiding.Models
{
    using Contracts;

    public abstract class BaseHero : IBaseHero
    {
        protected BaseHero(string name, int power)
        {
            this.Name = name;
            this.Power = power;
        }

        public string Name { get; }

        public int Power { get; }

        public abstract string CastAbility();

    }
}
