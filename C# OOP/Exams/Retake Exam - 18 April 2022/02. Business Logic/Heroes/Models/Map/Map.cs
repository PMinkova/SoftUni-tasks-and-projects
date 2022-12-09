namespace Heroes.Models.Map
{
    using System.Collections.Generic;
    using System.Linq;

    using Contracts;
    using Heroes;

    public class Map : IMap
    {
        public string Fight(ICollection<IHero> players)
        {
            var knights = players.Where(h => h.GetType().Name == nameof(Knight)).ToList();
            var barbarians = players.Where(h => h.GetType().Name == nameof(Barbarian)).ToList();

            var allKnightsAreDead = false;

            var deadKnights = 0;
            var deadBarbarians = 0;

            while (true)
            {
                foreach (var knight in knights.Where(h => h.IsAlive))
                {
                    foreach (var barbarian in barbarians.Where(h => h.IsAlive))
                    {
                        barbarian.TakeDamage(knight.Weapon.DoDamage());

                        if (!barbarian.IsAlive)
                        {
                            deadBarbarians++;
                        }
                    }
                }

                foreach (var barbarian in barbarians.Where(h => h.IsAlive))
                {
                    foreach (var knight in knights.Where(h => h.IsAlive))
                    {
                        knight.TakeDamage(barbarian.Weapon.DoDamage());

                        if (!knight.IsAlive)
                        {
                            deadKnights++;
                        }
                    }
                }

                if (knights.TrueForAll(h => !h.IsAlive))
                {
                    allKnightsAreDead = true;
                    break;
                }

                if (barbarians.TrueForAll(h => !h.IsAlive))
                {
                    break;
                }
            }

            if (allKnightsAreDead)
            {
                return $"The barbarians took {deadBarbarians} casualties but won the battle.";
            }

            return $"The knights took {deadKnights} casualties but won the battle.";
        }
    }
}
