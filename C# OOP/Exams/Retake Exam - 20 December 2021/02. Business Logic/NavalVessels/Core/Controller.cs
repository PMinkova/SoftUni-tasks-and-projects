namespace NavalVessels.Core
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Linq;

    using Contracts;
    using Models.Contracts;
    using Models;
    using Repositories;
    using Repositories.Contracts;
    using Utilities.Messages;

    public class Controller : IController
    {
        private readonly IRepository<IVessel> vessels;
        private readonly ICollection<ICaptain> captains;

        public Controller()
        {
            this.vessels = new VesselRepository();
            this.captains = new List<ICaptain>();
        }

        public string HireCaptain(string fullName)
        {
            var captain = new Captain(fullName);

            if (this.captains.Any(c => c.FullName == fullName))
            {
                return String.Format(OutputMessages.CaptainIsAlreadyHired, fullName);
            }

            this.captains.Add(captain);
            return String.Format(OutputMessages.SuccessfullyAddedCaptain, fullName);
        }

        public string ProduceVessel(string name, string vesselType, double mainWeaponCaliber, double speed)
        {
            var producedVessel = this.vessels.FindByName(name);

            if (producedVessel != null)
            {
                return String.Format(OutputMessages.VesselIsAlreadyManufactured, vesselType, name);
            }

            IVessel vessel;

            if (vesselType == "Battleship")
            {
                vessel = new Battleship(name, mainWeaponCaliber, speed);
            }
            else if (vesselType == "Submarine")
            {
                vessel = new Submarine(name, mainWeaponCaliber, speed);
            }
            else
            {
                return String.Format(OutputMessages.InvalidVesselType);
            }

            this.vessels.Add(vessel);
            return String.Format(OutputMessages.SuccessfullyCreateVessel, vesselType, name, mainWeaponCaliber, speed);
        }

        public string AssignCaptain(string selectedCaptainName, string selectedVesselName)
        {
            var captainToAssign = this.captains
                .FirstOrDefault(c => c.FullName == selectedCaptainName);

            if (captainToAssign == null)
            {
                return String.Format(OutputMessages.CaptainNotFound, selectedCaptainName);
            }

            IVessel vessel = this.vessels.FindByName(selectedVesselName);

            if (vessel == null)
            {
                return String.Format(OutputMessages.VesselNotFound, selectedVesselName);
            }


            if (vessel.Captain != null)
            {
                return String.Format(OutputMessages.VesselOccupied, selectedVesselName);
            }

            vessel.Captain = captainToAssign;
            captainToAssign.AddVessel(vessel);

            return String.Format(OutputMessages.SuccessfullyAssignCaptain, selectedCaptainName, selectedVesselName);
        }

        public string CaptainReport(string captainFullName)
        {
            var captain = this.captains
                .First(c => c.FullName == captainFullName);

            return captain.Report();
        }

        public string VesselReport(string vesselName)
        {
            var vessel = this.vessels.FindByName(vesselName);
            return vessel.ToString();
        }

        public string ToggleSpecialMode(string vesselName)
        {
            var searchedVessel = this.vessels.FindByName(vesselName);

            if (searchedVessel == null)
            {
                return String.Format(OutputMessages.VesselNotFound, vesselName);
            }

            var vesselType = searchedVessel.GetType().Name;

            if (vesselType == "Battleship")
            {
                var battleship = (Battleship)searchedVessel;
                battleship.ToggleSonarMode();

                return String.Format(OutputMessages.ToggleBattleshipSonarMode, vesselName);
            }
            else
            {
                var submarine = (Submarine)searchedVessel;
                submarine.ToggleSubmergeMode();

                return String.Format(OutputMessages.ToggleSubmarineSubmergeMode, vesselName);
            }
        }

        public string ServiceVessel(string vesselName)
        {
            var vessel = this.vessels.FindByName(vesselName);

            if (vessel == null)
            {
                return String.Format(OutputMessages.VesselNotFound, vesselName);
            }

            vessel.RepairVessel();

            return String.Format(OutputMessages.SuccessfullyRepairVessel, vesselName);
        }
        public string AttackVessels(string attackingVesselName, string defendingVesselName)
        {
            var attackingVessel = this.vessels.FindByName(attackingVesselName);

            if (attackingVessel == null)
            {
                return String.Format(OutputMessages.VesselNotFound, attackingVesselName);
            }

            var defendingVessel = this.vessels.FindByName(defendingVesselName);

            if (defendingVessel == null)
            {
                return String.Format(OutputMessages.VesselNotFound, defendingVesselName);
            }

            if (attackingVessel.ArmorThickness == 0)
            {
                return String.Format(OutputMessages.AttackVesselArmorThicknessZero, attackingVesselName);
            }

            if (defendingVessel.ArmorThickness == 0)
            {
                return String.Format(OutputMessages.AttackVesselArmorThicknessZero, defendingVesselName);
            }

            attackingVessel.Attack(defendingVessel);

            return String.Format(OutputMessages.SuccessfullyAttackVessel,
                defendingVesselName,
                attackingVesselName,
                defendingVessel.ArmorThickness);
        }
    }
}
