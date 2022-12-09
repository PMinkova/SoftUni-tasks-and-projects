namespace Heroes.Repositories
{
    using System.Collections.Generic;
    using System.Linq;

    using Contracts;
    using Models.Contracts;

    public class WeaponRepository : IRepository<IWeapon>
    {
        private readonly List<IWeapon> weapons;

        public WeaponRepository()
        {
            this.weapons = new List<IWeapon>();
        }

        public IReadOnlyCollection<IWeapon> Models => this.weapons.AsReadOnly();


        public void Add(IWeapon weapon)
        {
            this.weapons.Add(weapon);
        }

        public bool Remove(IWeapon weapon)
        {
            return this.weapons.Remove(weapon);
        }

        public IWeapon FindByName(string name)
        {
            return this.weapons.FirstOrDefault(w => w.Name == name);
        }
    }
}
