namespace SpaceStation.Repositories
{
    using System.Collections.Generic;
    using System.Linq;

    using Contracts;
    using Models.Astronauts.Contracts;

    public class AstronautRepository : IRepository<IAstronaut>
    {
        private readonly List<IAstronaut> models;

        public AstronautRepository()
        {
            this.models = new List<IAstronaut>();
        }

        public IReadOnlyCollection<IAstronaut> Models
        {
            get
            {
                return this.models.AsReadOnly();
            }
        }

        public void Add(IAstronaut model)
        {
            this.models.Add(model);
        }

        public bool Remove(IAstronaut model)
        {
            return this.models.Remove(model);
        }

        public IAstronaut FindByName(string name)
        {
            return this.models.FirstOrDefault(a => a.Name == name);
        }
    }
}
