namespace Heroes.Repositories
{
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;

    using Contracts;
    using Models.Contracts;

    public class HeroRepository : IRepository<IHero>
    {
        private readonly ICollection<IHero> heroes;

        public HeroRepository()
        {
            this.heroes = new List<IHero>();
        }

        public IReadOnlyCollection<IHero> Models => this.heroes.ToImmutableArray();

        public void Add(IHero hero)
        {
            this.heroes.Add(hero);
        }

        public bool Remove(IHero hero)
        {
            return this.heroes.Remove(hero);
        }

        public IHero FindByName(string name)
        {
            return this.heroes.FirstOrDefault(h => h.Name == name);
        }
    }
}
