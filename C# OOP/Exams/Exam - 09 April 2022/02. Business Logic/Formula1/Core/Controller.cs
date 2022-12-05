namespace Formula1.Core
{
    using System;
    using System.Linq;
    using System.Text;

    using Contracts;
    using Models;
    using Models.Contracts;
    using Repositories;
    using Repositories.Contracts;
    using Utilities;

    public class Controller : IController
    {
        private IRepository<IPilot> pilots;
        private IRepository<IRace> races;
        private IRepository<IFormulaOneCar> cars;

        public Controller()
        {
            this.pilots = new PilotRepository();
            this.races = new RaceRepository();
            this.cars = new FormulaOneCarRepository();
        }

        public string CreatePilot(string fullName)
        {
            if (this.pilots.FindByName(fullName) != null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.PilotExistErrorMessage, fullName));
            }

            var pilot = new Pilot(fullName);

            this.pilots.Add(pilot);

            return String.Format(OutputMessages.SuccessfullyCreatePilot, fullName);
        }

        public string CreateCar(string type, string model, int horsepower, double engineDisplacement)
        {
            if (this.cars.FindByName(model) != null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.CarExistErrorMessage, model));
            }

            IFormulaOneCar car;

            if (type == nameof(Ferrari))
            {
                car = new Ferrari(model, horsepower, engineDisplacement);
            }
            else if (type == nameof(Williams))
            {
                car = new Williams(model, horsepower, engineDisplacement);
            }
            else
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.InvalidTypeCar, type));
            }

            this.cars.Add(car);

            return String.Format(OutputMessages.SuccessfullyCreateCar, type, model);
        }

        public string CreateRace(string raceName, int numberOfLaps)
        {
            if (this.races.FindByName(raceName) != null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.RaceExistErrorMessage, raceName));
            }

            var race = new Race(raceName, numberOfLaps);
            this.races.Add(race);

            return String.Format(OutputMessages.SuccessfullyCreateRace, raceName);
        }

        public string AddCarToPilot(string pilotName, string carModel)
        {
            var pilot = this.pilots.FindByName(pilotName);

            if (pilot == null || pilot.Car != null)
            {
                throw new InvalidOperationException(String
                    .Format(ExceptionMessages.PilotDoesNotExistOrHasCarErrorMessage, pilotName));
            }

            var car = this.cars.FindByName(carModel);

            if (car == null)
            {
                throw new NullReferenceException(String.Format(ExceptionMessages.CarDoesNotExistErrorMessage,
                    carModel));
            }

            pilot.AddCar(car);
            this.cars.Remove(car);

            return String.Format(OutputMessages.SuccessfullyPilotToCar,
                pilotName,
                car.GetType().Name,
                carModel);
        }

        public string AddPilotToRace(string raceName, string pilotFullName)
        {
            var race = this.races.FindByName(raceName);

            if (race == null)
            {
                throw new NullReferenceException(
                    String.Format(ExceptionMessages.RaceDoesNotExistErrorMessage, raceName));
            }

            var pilot = this.pilots.FindByName(pilotFullName);

            if (pilot == null || !pilot.CanRace || race.Pilots.Contains(pilot))
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.PilotDoesNotExistErrorMessage,
                    pilotFullName));
            }

            race.AddPilot(pilot);

            return String.Format(OutputMessages.SuccessfullyAddPilotToRace, pilotFullName, raceName);
        }

        public string StartRace(string raceName)
        {
            var race = this.races.FindByName(raceName);

            if (race == null)
            {
                throw new NullReferenceException(
                    String.Format(ExceptionMessages.RaceDoesNotExistErrorMessage, raceName));
            }

            if (race.Pilots.Count < 3)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.InvalidRaceParticipants, raceName));
            }

            if (race.TookPlace)
            {
                throw new InvalidOperationException(
                    String.Format(ExceptionMessages.RaceTookPlaceErrorMessage, raceName));
            }

            var threeFastestPilots = race.Pilots
                .OrderByDescending(p => p.Car.RaceScoreCalculator(race.NumberOfLaps))
                .Take(3)
                .ToList();

            var firstPilot = threeFastestPilots[0];
            var secondPilot = threeFastestPilots[1];
            var thirdPilot = threeFastestPilots[2];

            firstPilot.WinRace();
            race.TookPlace = true;

            var sb = new StringBuilder();

            sb
                .AppendLine($"Pilot {firstPilot.FullName} wins the {raceName} race.")
                .AppendLine($"Pilot {secondPilot.FullName} is second in the {raceName} race.")
                .AppendLine($"Pilot {thirdPilot.FullName} is third in the {raceName} race.");

            return sb.ToString().TrimEnd();
        }

        public string RaceReport()
        {
            var sb = new StringBuilder();

            var executedRaces = this.races.Models.Where(r => r.TookPlace);

            foreach (var race in executedRaces)
            {
                sb.AppendLine(race.RaceInfo());
            }

            return sb.ToString().TrimEnd();
        }

        public string PilotReport()
        {
            var sb = new StringBuilder();

           var orderedPilots = this.pilots.Models.OrderByDescending(p => p.NumberOfWins).ToList();

            foreach (var pilot in orderedPilots)
            {
                sb.AppendLine(pilot.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
