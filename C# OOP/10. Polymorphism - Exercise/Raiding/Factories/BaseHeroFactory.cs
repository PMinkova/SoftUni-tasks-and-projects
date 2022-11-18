namespace Raiding.Factories
{
    using Contracts;
    using Exceptions;
    using Models;
    using Models.Contracts;

    public class BaseHeroFactory : IBaseHeroFactory
    {
        public IBaseHero createBaseHero(string name, string type)
        {
            IBaseHero baseHero;

            if (type == "Druid")
            {
                baseHero = new Druid(name);
            }
            else if (type == "Paladin")
            {
                baseHero = new Paladin(name);
            }
            else if (type == "Rogue")
            {
                baseHero = new Rogue(name);
            }
            else if (type == "Warrior")
            {
                baseHero = new Warrior(name);
            }
            else
            {
                throw new InvalidHeroTypeException();
            }

            return baseHero;
        }
    }
}