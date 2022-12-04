namespace CarRacing.Models.Racers
{
    using Cars.Contracts;

    public class ProfessionalRacer: Racer
    {
        private const int InitialDrivingExperience = 30;
        private const int DrivingExperienceIncrement = 10;
        private const string DefaultRacingBehavior = "strict";
        public ProfessionalRacer(string username, ICar car)
            : base(username, DefaultRacingBehavior, InitialDrivingExperience, car)
        {

        }

        public override void Race()
        {
            base.Race();
            this.DrivingExperience += DrivingExperienceIncrement;
        }
    }
}
