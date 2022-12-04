namespace CarRacing.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Contracts;
    using Models.Cars.Contracts;
    using Utilities.Messages;

    public class CarRepository : IRepository<ICar>
    {
        private readonly List<ICar> models;

        public CarRepository()
        {
            this.models = new List<ICar>();
        }

        public IReadOnlyCollection<ICar> Models
        {
            get
            {
                return this.models.AsReadOnly();
            }
        }

        public void Add(ICar model)
        {
            if (model == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidAddCarRepository);
            }

            this.models.Add(model);
        }

        public bool Remove(ICar model)
        {
            return this.models.Remove(model);
        }

        public ICar FindBy(string property)
        {
            return this.models.FirstOrDefault(c => c.VIN == property);
        }
    }
}
