namespace Formula1.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Contracts;
    using Utilities;

    public class Race : IRace
    {
        private const int MinRaceNameLength = 5;
        private const int MinLapsNumber = 1;

        private string raceName;
        private int numberOfLaps;
        private List<IPilot> pilots;

        public Race(string raceName, int numberOfLaps) 
            : this()
        {
            this.RaceName = raceName;
            this.NumberOfLaps = numberOfLaps;
        }

        public Race()
        {
            this.pilots = new List<IPilot>();
        }

        public string RaceName
        {
            get
            {
                return this.raceName;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value) || value.Length < MinRaceNameLength)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidRaceName, value));
                }

                this.raceName = value;
            }
        }

        public int NumberOfLaps
        {
            get
            {
                return this.numberOfLaps;
            }
            private set
            {
                if (value < MinLapsNumber)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidLapNumbers, value));
                }

                this.numberOfLaps = value;
            }
        }
        public bool TookPlace { get; set; }

        public ICollection<IPilot> Pilots
        {
            get
            {
                return this.pilots;
            }
        }

        public void AddPilot(IPilot pilot)
        {
            this.Pilots.Add(pilot);
        }

        public string RaceInfo()
        {
            var sb = new StringBuilder();

            var tookPlace = this.TookPlace ? "Yes" : "No";

            sb
                .AppendLine($"The {this.RaceName} race has:")
                .AppendLine($"Participants: {this.Pilots.Count}")
                .AppendLine($"Number of laps: {this.NumberOfLaps}")
                .AppendLine($"Took place: {tookPlace}");

            return sb.ToString().TrimEnd();
        }
    }
}
