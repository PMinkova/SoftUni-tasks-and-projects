namespace NavalVessels.Models
{
    using System.Text;
    using Contracts;

    public class Submarine : Vessel, ISubmarine
    {
        private const double InitialArmorThickness = 200;
        private const double MainWeaponCaliberChange = 40;
        private const double SpeedChange = 4;

        public Submarine(string name, double mainWeaponCaliber, double speed)
            : base(name, mainWeaponCaliber, speed, InitialArmorThickness)
        {
        }

        public override void RepairVessel()
        {
            this.ArmorThickness = InitialArmorThickness;
        }

        public bool SubmergeMode { get; private set; }

        public void ToggleSubmergeMode()
        {
            if (!this.SubmergeMode)
            {
                this.MainWeaponCaliber += MainWeaponCaliberChange;
                this.Speed -= SpeedChange;
            }
            else
            {
                this.MainWeaponCaliber -= MainWeaponCaliberChange;
                this.Speed += SpeedChange;
            }

            this.SubmergeMode = !this.SubmergeMode;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            string submergeModeOutput = this.SubmergeMode ? "ON" : "OFF";

            sb
                .AppendLine(base.ToString())
                .AppendLine($" *Submerge mode: {submergeModeOutput}");

            return sb.ToString().TrimEnd();
        }
    }
}