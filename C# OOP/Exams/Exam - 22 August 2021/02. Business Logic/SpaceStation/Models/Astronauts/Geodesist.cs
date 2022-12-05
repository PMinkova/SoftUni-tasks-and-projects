namespace SpaceStation.Models.Astronauts
{
    public class Geodesist : Astronaut
    {
        private const double InitialOxygenUnits = 50;

        public Geodesist(string name) 
            : base(name, InitialOxygenUnits)
        {

        }
    }
}
