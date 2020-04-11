using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Team
    {
		private string name;

		private List<Person> firstTeam;

		private List<Person> reserveTeam;

        public Team(string name)
        {
            this.name = name;
            firstTeam = new List<Person>();
            reserveTeam = new List<Person>();
        }

        public IReadOnlyCollection<Person> FirstTeam => this.firstTeam.AsReadOnly();

        public IReadOnlyCollection<Person> ReserveTeam => this.reserveTeam;

        public void AddPlayer(Person person)
        {
            if (person.Age < 40)
            {
                this.firstTeam.Add(person);
            }
            else
            {
                this.reserveTeam.Add(person);
            }
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder
                .AppendLine($"First team has {this.firstTeam.Count} players.")
                .Append($"Reserve team has {this.reserveTeam.Count} players.");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
