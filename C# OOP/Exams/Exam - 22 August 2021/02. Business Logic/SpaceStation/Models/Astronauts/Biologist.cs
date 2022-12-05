namespace SpaceStation.Models.Astronauts
{
    public class Biologist : Astronaut
    {
        private const double InitialOxygenUnits = 70;
        private const double OxygenUnitsDecrement = 5;

        public Biologist(string name)
            : base(name, InitialOxygenUnits)
        {

        }

        public override void Breath()
        {
            this.Oxygen -= OxygenUnitsDecrement;
        }
    }
}
