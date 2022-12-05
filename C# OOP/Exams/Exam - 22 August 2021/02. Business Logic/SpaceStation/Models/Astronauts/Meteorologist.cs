namespace SpaceStation.Models.Astronauts
{
    public class Meteorologist : Astronaut
    {
        private const double InitialOxygenUnits = 90;

        public Meteorologist(string name) 
            : base(name, InitialOxygenUnits)
        {

        }
    }
}
