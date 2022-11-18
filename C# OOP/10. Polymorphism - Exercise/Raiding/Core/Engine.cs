namespace Raiding.Core
{
    using System;
    using System.Collections.Generic;

    using Contracts;
    using Exceptions;
    using Factories.Contracts;
    using IO.Contracts;
    using Models.Contracts;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        private IBaseHeroFactory baseHeroFactory;

        private ICollection<IBaseHero> heros;

        private Engine()
        {
            this.heros = new HashSet<IBaseHero>();
        }

        public Engine(IReader reader, IWriter writer, IBaseHeroFactory baseHeroFactory)
            : this()
        {
            this.reader = reader;
            this.writer = writer;

            this.baseHeroFactory = baseHeroFactory;
        }

        public void Run()
        {
            var inputLines = int.Parse(reader.ReadLine());
           
            for (int i = 0; i < inputLines; i++)
            {
                try
                {
                    IBaseHero currentHero = BuildHeroUsingFactory();
                }
                catch (InvalidHeroTypeException ihte)
                {
                    writer.WriteLine(ihte.Message);
                    i--;
                }
            }


            var bossPower = int.Parse(reader.ReadLine());

            var totalHerosPower = 0;

            foreach (var hero in heros)
            {
                writer.WriteLine(hero.CastAbility());
                totalHerosPower += hero.Power;
            }

            writer.WriteLine(DefeatBoss(bossPower, totalHerosPower));

        }

        private IBaseHero BuildHeroUsingFactory()
        {
            var heroName = reader.ReadLine();
            var heroType = reader.ReadLine();

            var currentHero = baseHeroFactory.createBaseHero(heroName, heroType);
            heros.Add(currentHero);

            return currentHero;
        }

        private string DefeatBoss(int bossPower, int totalHerosPower)
        {
            if (bossPower <= totalHerosPower)
            {
                return "Victory!";
            }
            else
            {
                return "Defeat...";
            }
        }
    }
}