namespace SpaceStation.Core
{
    using System;
    using System.Linq;
    using System.Text;

    using Contracts;
    using Models.Astronauts;
    using Models.Astronauts.Contracts;
    using Models.Mission;
    using Models.Mission.Contracts;
    using Models.Planets;
    using Models.Planets.Contracts;
    using Repositories;
    using Repositories.Contracts;
    using Utilities.Messages;

    public class Controller : IController
    {
        private const double MinimalOxygenUnits = 60;

        private readonly IRepository<IAstronaut> astronauts;
        private readonly IRepository<IPlanet> planets;
        private readonly IMission mission;

        private int exploredPlanetsCount = 0;

        public Controller()
        {
            this.astronauts = new AstronautRepository();
            this.planets = new PlanetRepository();
            this.mission = new Mission();
        }
        
        public string AddAstronaut(string type, string astronautName)
        {
            IAstronaut astronaut;

            if (type == "Biologist")
            {
                astronaut = new Biologist(astronautName);
            }
            else if (type == "Geodesist")
            {
                astronaut = new Geodesist(astronautName);
            }
            else if (type == "Meteorologist")
            {
                astronaut = new Meteorologist(astronautName);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAstronautType);
            }

            this.astronauts.Add(astronaut);
            return String.Format(OutputMessages.AstronautAdded, type, astronautName);
        }

        public string AddPlanet(string planetName, params string[] items)
        {
            var planet = new Planet(planetName);

            foreach (var item in items)
            {
                planet.Items.Add(item);
            }

            this.planets.Add(planet);

            return String.Format(OutputMessages.PlanetAdded, planetName);
        }

        public string RetireAstronaut(string astronautName)
        {
            var astronaut = this.astronauts.FindByName(astronautName);

            if (astronaut == null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.InvalidRetiredAstronaut, astronautName));
            }

            this.astronauts.Remove(astronaut);

            return String.Format(OutputMessages.AstronautRetired, astronautName);
        }

        public string ExplorePlanet(string planetName)
        {
            var suitableAstronauts = this.astronauts.Models
                .Where(a => a.Oxygen > MinimalOxygenUnits)
                .ToList();

            if (!suitableAstronauts.Any())
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAstronautCount);
            }

            var planet = this.planets.FindByName(planetName);

            this.mission.Explore(planet, suitableAstronauts);

            var deadAstronautsCount = suitableAstronauts.Count(a => !a.CanBreath);

            exploredPlanetsCount++;
            return String.Format(OutputMessages.PlanetExplored, planetName, deadAstronautsCount);
        }

        public string Report()
        {
            var sb = new StringBuilder();

            sb
                .AppendLine($"{exploredPlanetsCount} planets were explored!")
                .AppendLine("Astronauts info:");

            foreach (var astronaut in this.astronauts.Models)
            {
                sb.AppendLine(astronaut.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
