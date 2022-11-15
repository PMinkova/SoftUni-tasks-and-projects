namespace MilitaryElite.Models
{
    using System.Collections.Generic;
    using System.Text;

    using Contracts;

    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private readonly ICollection<IPrivate> privates;

        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary, ICollection<IPrivate> privates)
            : base(id, firstName, lastName, salary)
        {
            this.privates = privates;
        }

        public IReadOnlyCollection<IPrivate> Privates
            => (IReadOnlyCollection<IPrivate>)this.privates;

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder
                .AppendLine(base.ToString())
                .AppendLine("Privates:");

            foreach (var currentPrivate in this.Privates)
            {
                stringBuilder.AppendLine($"  {currentPrivate}");
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
