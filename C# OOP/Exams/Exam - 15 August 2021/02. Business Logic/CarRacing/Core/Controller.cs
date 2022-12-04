namespace CarRacing.Core
{
    using System;
    using System.Linq;
    using System.Text;

    using Contracts;
    using Models.Cars;
    using Models.Cars.Contracts;
    using Models.Maps;
    using Models.Maps.Contracts;
    using Models.Racers;
    using Models.Racers.Contracts;
    using Repositories;
    using Repositories.Contracts;
    using Utilities.Messages;

    public class Controller : IController
    {
        private readonly IRepository<ICar> cars;
        private readonly IRepository<IRacer> racers;
        private readonly IMap map;

        public Controller()
        {
            this.cars = new CarRepository();
            this.racers = new RacerRepository();
            this.map = new Map();
        }

        public string AddCar(string type, string make, string model, string VIN, int horsePower)
        {
            ICar car;

            if (type == "SuperCar")
            {
                car = new SuperCar(make, model, VIN, horsePower);
            }
            else if (type == "TunedCar")
            {
                car = new TunedCar(make, model, VIN, horsePower);
            }
            else
            {
                return ExceptionMessages.InvalidCarType;
            }

            this.cars.Add(car);

            return String.Format(OutputMessages.SuccessfullyAddedCar, make, model, VIN);
        }

        public string AddRacer(string type, string username, string carVIN)
        {
            var car = this.cars.FindBy(carVIN);

            if (car == null)
            {
                return ExceptionMessages.CarCannotBeFound;
            }

            IRacer racer;

            if (type == "ProfessionalRacer")
            {
                racer = new ProfessionalRacer(username, car);
            }
            else if (type == "StreetRacer")
            {
                racer = new StreetRacer(username, car);
            }
            else
            {
                return ExceptionMessages.InvalidRacerType;
            }

            this.racers.Add(racer);

            return String.Format(OutputMessages.SuccessfullyAddedRacer, racer.Username);
        }

        public string BeginRace(string racerOneUsername, string racerTwoUsername)
        {
            var racerOne = this.racers.FindBy(racerOneUsername);
            var racerTwo = this.racers.FindBy(racerTwoUsername);

            if (racerOne == null)
            {
                return String.Format(ExceptionMessages.RacerCannotBeFound, racerOneUsername);
            }

            if (racerTwo == null)
            {
                return String.Format(ExceptionMessages.RacerCannotBeFound, racerTwoUsername);
            }

            return this.map.StartRace(racerOne, racerTwo);
        }

        public string Report() //driving experience descending, then by username alphabetically. 
        {
            var orderedRacers = this.racers.Models
                .OrderByDescending(r => r.DrivingExperience)
                .ThenBy(r => r.Username)
                .ToList();

            var sb = new StringBuilder();

            foreach (var racer in orderedRacers)
            {
                sb.AppendLine(racer.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
