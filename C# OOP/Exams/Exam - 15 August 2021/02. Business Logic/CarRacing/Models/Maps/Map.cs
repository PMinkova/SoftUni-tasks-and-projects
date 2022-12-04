namespace CarRacing.Models.Maps
{
    using Contracts;
    using Racers.Contracts;
    using Utilities.Messages;

    public class Map : IMap
    {
        public string StartRace(IRacer racerOne, IRacer racerTwo)
        {
            if (!racerOne.IsAvailable() && !racerTwo.IsAvailable())
            {
                return OutputMessages.RaceCannotBeCompleted;
            }

            if (!racerOne.IsAvailable())
            {
                return $"{racerTwo.Username} wins the race! {racerOne.Username} was not available to race!";
            }

            if (!racerTwo.IsAvailable())
            {
                return $"{racerOne.Username} wins the race! {racerTwo.Username} was not available to race!";
            }

            racerOne.Race();
            racerTwo.Race();

            var racerOneRacingBehaviorMultiplier = racerOne.RacingBehavior == "strict" ? 1.2 : 1.1;

            var racerOneChanceToWin =
                racerOne.Car.HorsePower * racerOne.DrivingExperience * racerOneRacingBehaviorMultiplier;

            var racerTwoRacingBehaviorMultiplier = racerTwo.RacingBehavior == "strict" ? 1.2 : 1.1;

            var racerTwoChanceToWin =
                racerTwo.Car.HorsePower * racerTwo.DrivingExperience * racerTwoRacingBehaviorMultiplier;

            var winnerUsername = racerOneChanceToWin > racerTwoChanceToWin 
                ? racerOne.Username 
                : racerTwo.Username;

           return $"{racerOne.Username} has just raced against {racerTwo.Username}! {winnerUsername} is the winner!";

        }
    }
}
