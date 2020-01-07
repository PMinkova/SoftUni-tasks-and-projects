using System;
using System.Collections.Generic;
using System.Linq;

namespace P09_PokemonTrainer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            string input = Console.ReadLine();

            while (input != "Tournament")
            {
                string[] commandArgs = input.Split();

                string trainerName = commandArgs[0];
                string pokemoneName = commandArgs[1];
                string pokemonElement = commandArgs[2];
                int pokemonHealth = int.Parse(commandArgs[3]);

                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, new Trainer(trainerName));
                }

                Trainer currentTrainer = trainers[trainerName];
                var pokemon = new Pokemon(pokemoneName, pokemonElement, pokemonHealth);

                currentTrainer.Pokemons.Add(pokemon);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                string element = input;

                foreach (var trainer in trainers)
                {
                    if (trainer.Value.Pokemons.Any(p => p.Element == element))
                    {
                        trainer.Value.NumberOfBadges++;
                    }
                    else
                    {
                        trainer.Value.Pokemons.Select(p => p.Health -= 10);
                        trainer.Value.Pokemons.RemoveAll(p => p.Health <= 0);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var trainer in trainers
                .OrderByDescending(t => t.Value.NumberOfBadges)
                .ThenBy(t => t.Value.Pokemons.Count))
            {
                string trainerName = trainer.Key;
                int badges = trainer.Value.NumberOfBadges;
                int pokemonsCount = trainer.Value.Pokemons.Count;

                Console.WriteLine($"{trainerName} {badges} {pokemonsCount}");
            }
        }
    }
}
