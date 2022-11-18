using Raiding.Models.Contracts;

namespace Raiding.Factories.Contracts
{
    public interface IBaseHeroFactory
    {
        IBaseHero createBaseHero(string name, string type);
    }
}