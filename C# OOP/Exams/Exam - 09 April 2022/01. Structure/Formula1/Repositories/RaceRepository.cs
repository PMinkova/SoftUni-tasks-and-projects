namespace Formula1.Repositories
{
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using Contracts;
    using Models.Contracts;

    public class RaceRepository : IRepository<IRace>
    {
        private readonly ICollection<IRace> models;

        public RaceRepository()
        {
            this.models = new List<IRace>();
        }

        public IReadOnlyCollection<IRace> Models
        {
            get
            {
                return this.models.ToImmutableArray();
            }
        }


        public void Add(IRace model)
        {
            this.models.Add(model);
        }

        public bool Remove(IRace model)
        {
           return this.models.Remove(model);
        }

        public IRace FindByName(string name)
        {
            return this.models.FirstOrDefault(r => r.RaceName == name);
        }
    }
}
