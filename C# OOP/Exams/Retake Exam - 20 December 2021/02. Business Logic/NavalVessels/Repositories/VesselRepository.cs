namespace NavalVessels.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;
    using Models.Contracts;

    public class VesselRepository : IRepository<IVessel>
    {
        private readonly List<IVessel> models;

        public VesselRepository()
        {
            this.models = new List<IVessel>();
        }

        public IReadOnlyCollection<IVessel> Models => this.models.AsReadOnly();

        public void Add(IVessel model)
        {
            this.models.Add(model);
        }

        public bool Remove(IVessel model)
        {
            return this.models.Remove(model);
        }

        public IVessel FindByName(string name)
        {
            return this.Models.FirstOrDefault(m => m.Name == name);
        }
    }
}