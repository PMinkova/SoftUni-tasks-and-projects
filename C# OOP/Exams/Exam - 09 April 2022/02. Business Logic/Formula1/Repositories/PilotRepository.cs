namespace Formula1.Repositories
{
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;

    using Contracts;
    using Models.Contracts;

    public class PilotRepository : IRepository<IPilot>
    {
        private readonly ICollection<IPilot> models;

        public PilotRepository()
        {
            this.models = new List<IPilot>();
        }

        public IReadOnlyCollection<IPilot> Models
        {
            get
            {
                return this.models.ToImmutableArray();
            }
        }

        public void Add(IPilot model)
        {
            this.models.Add(model);
        }

        public bool Remove(IPilot model)
        {
            return this.models.Remove(model);
        }

        public IPilot FindByName(string name)
        {
            return this.models.FirstOrDefault(p => p.FullName == name);
        }
    }
}
