using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class Team
    {
        private List<Player> playerList;
        private string name;

        public Team()
        {
            this.playerList = new List<Player>();
        }
        public Team(string name) : this()
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NameCannotBeEmpty);
                }

                this.name = value;
            }
        }

        public double Rating
        {
            get
            {
                if (!this.playerList.Any())
                {
                    return 0;
                }

                return (double)Math.Round(this.playerList.Average(p => p.OverallRating), 0);
            }
        }

        public void AddPlayer(Player player)
        {
            this.playerList.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            var playerToRemove = this.playerList.FirstOrDefault(p => p.Name == playerName);

            if (playerToRemove == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.MissingPlayer,
                    playerName, this.Name));
            }

            this.playerList.Remove(playerToRemove);
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Rating}";
        }
    }
}
