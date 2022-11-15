namespace MilitaryElite.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Contracts;
    using Enums;

    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private readonly ICollection<IRepair> repairs;

        public Engineer(int id, string firstName, string lastName, decimal salary, Corps corps, ICollection<IRepair> repairs)
            : base(id, firstName, lastName, salary, corps)
        {
            this.repairs = repairs;
        }

        public IReadOnlyCollection<IRepair> Repairs
            => (IReadOnlyCollection<IRepair>)this.repairs;

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder
                .AppendLine(base.ToString())
                .AppendLine("Repairs:")
                .AppendLine(String.Join(Environment.NewLine, this.Repairs));

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
