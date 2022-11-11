using System;

namespace FootballTeamGenerator
{
    public class Stats
    {
        private const int StatMinValue = 0;
        private const int StatMaxValue = 100;

        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Stats(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public int Endurance
        {
            get
            {
                return this.endurance;
            }
            private set
            {
                if (IsStatInvalid(value))
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.StatShouldBeBetween0and100,
                        nameof(this.Endurance)));
                }

                this.endurance = value;
            }
        }

        public int Sprint
        {
            get
            {
                return this.sprint;
            }
            private set
            {
                if (IsStatInvalid(value))
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.StatShouldBeBetween0and100,
                        nameof(this.Sprint)));
                }

                this.sprint = value;
            }
        }

        public int Dribble
        {
            get
            {
                return this.dribble;
            }
            private set
            {
                if (IsStatInvalid(value))
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.StatShouldBeBetween0and100,
                        nameof(this.Dribble)));
                }

                this.dribble = value;
            }
        }

        public int Passing
        {
            get
            {
                return this.passing;
            }
            private set
            {
                if (IsStatInvalid(value))
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.StatShouldBeBetween0and100,
                        nameof(this.Passing)));
                }

                this.passing = value;
            }
        }

        public int Shooting
        {
            get
            {
                return this.shooting;
            }
            private set
            {
                if (IsStatInvalid(value))
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.StatShouldBeBetween0and100,
                        nameof(this.Shooting)));
                }

                this.shooting = value;
            }
        }

        private bool IsStatInvalid(int value)
        {
            return value < StatMinValue || StatMaxValue < value;
        }
    }
}
