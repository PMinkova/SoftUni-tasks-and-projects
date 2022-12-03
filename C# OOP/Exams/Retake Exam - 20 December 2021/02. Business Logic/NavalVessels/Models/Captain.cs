namespace NavalVessels.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Contracts;
    using Utilities.Messages;

    public class Captain : ICaptain
    {
        private const int CombatExperienceIncreaseStep = 10;

        private string fullName;

        public Captain(string fullName) : this()
        {
            this.FullName = fullName;
        }

        private Captain()
        {
            this.Vessels = new HashSet<IVessel>();
        }

        public string FullName
        {
            get
            {
                return this.fullName;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(ExceptionMessages.InvalidCaptainName);
                }

                this.fullName = value;
            }
        }

        public int CombatExperience { get; private set; }

        public ICollection<IVessel> Vessels { get; private set; }

        public void AddVessel(IVessel vessel)
        {
            if (vessel == null)
            {
                throw new NullReferenceException(ExceptionMessages.InvalidVesselForCaptain);
            }

            this.Vessels.Add(vessel);
        }

        public void IncreaseCombatExperience()
        {
            this.CombatExperience += CombatExperienceIncreaseStep;
        }

        public string Report()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{this.FullName} has {this.CombatExperience} combat experience and commands {this.Vessels.Count} vessels.");

            foreach (var vessel in this.Vessels)
            {
                sb.AppendLine(vessel.ToString());
            }

            return sb.ToString().TrimEnd();
        }

    }
}
