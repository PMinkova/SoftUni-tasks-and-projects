namespace Heroes.Core
{
    using System;
    using System.Linq;

    using Contracts;
    using Models.Contracts;
    using Models.Heroes;
    using Models.Map;
    using Models.Weapons;
    using Repositories;
    using Repositories.Contracts;

    public class Controller : IController
    {
        private IRepository<IHero> heroes;
        private IRepository<IWeapon> weapons;
        private IMap map;

        public Controller()
        {
            this.heroes = new HeroRepository();
            this.weapons = new WeaponRepository();
            this.map = new Map();
        }

        public string CreateHero(string type, string name, int health, int armour)
        {
            if (heroes.FindByName(name) != null)
            {
                throw new InvalidOperationException($"The hero {name} already exists.");
            }

            IHero hero;

            if (type == nameof(Knight))
            {
                hero = new Knight(name, health, armour);
            }
            else if (type == nameof(Barbarian))
            {
                hero = new Barbarian(name, health, armour);
            }
            else
            {
                throw new InvalidOperationException("Invalid hero type.");
            }

            this.heroes.Add(hero);

            var addedHero = type == nameof(Knight) ? "Sir" : type;

            return $"Successfully added {addedHero} {name} to the collection.";
        }

        public string CreateWeapon(string type, string name, int durability)
        {
            if (this.weapons.FindByName(name) != null)
            {
                throw new InvalidOperationException($"The weapon {name} already exists.");
            }

            IWeapon weapon;

            if (type == nameof(Mace))
            {
                weapon = new Mace(name, durability);
            }
            else if (type == nameof(Claymore))
            {
                weapon = new Claymore(name, durability);
            }
            else
            {
                throw new InvalidOperationException("Invalid weapon type.");
            }

            this.weapons.Add(weapon);

            return $"A {type.ToLower()} {name} is added to the collection.";
        }

        public string AddWeaponToHero(string weaponName, string heroName)
        {
            var hero = this.heroes.FindByName(heroName);

            if (hero == null)
            {
                throw new InvalidOperationException($"Hero {heroName} does not exist.");
            }

            var weapon = this.weapons.FindByName(weaponName);

            if (weapon == null)
            {
                throw new InvalidOperationException($"Weapon {weaponName} does not exist.");
            }

            if (hero.Weapon != null)
            {
                throw new InvalidOperationException($"Hero {heroName} is well-armed.");
            }

            hero.AddWeapon(weapon);
            this.weapons.Remove(weapon);

            return $"Hero {heroName} can participate in battle using a {weapon.GetType().Name.ToLower()}.";
        }

        public string StartBattle()
        {
            var aliveHeroesWithWeapon = this.heroes.Models
                .Where(h => h.IsAlive)
                .Where(h => h.Weapon != null)
                .ToList();

            return this.map.Fight(aliveHeroesWithWeapon);
        }

        public string HeroReport()
        {
            var sortedHeroes = this.heroes.Models
                .OrderBy(h => h.GetType().Name)
                .ThenByDescending(h => h.Health)
                .ThenBy(h => h.Name)
                .ToList();

            return String.Join(Environment.NewLine, sortedHeroes);
        }
    }
}
