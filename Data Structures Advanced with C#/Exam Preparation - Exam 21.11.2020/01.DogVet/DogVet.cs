namespace _01.DogVet
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DogVet : IDogVet
    {
        private Dictionary<string, Dog> dogsByIds;
        private Dictionary<string, Owner> ownersByIds;
        public DogVet()
        {
            this.dogsByIds = new Dictionary<string, Dog>();
            this.ownersByIds = new Dictionary<string, Owner>();
        }

        public int Size => this.dogsByIds.Count;

        public void AddDog(Dog dog, Owner owner)
        {
            if (this.dogsByIds.ContainsKey(dog.Id))
            {
                throw new ArgumentException();
            }

            if (owner.Dogs.ContainsKey(dog.Name))
            {
                throw new ArgumentException();
            }

            if (!this.ownersByIds.ContainsKey(owner.Id))
            {
                this.ownersByIds.Add(owner.Id, owner);
            }

            this.dogsByIds.Add(dog.Id, dog);
            owner.Dogs.Add(dog.Name, dog);
            dog.Owner = owner;
        }

        public bool Contains(Dog dog)
        {
            return this.dogsByIds.ContainsKey(dog.Id);
        }

        public Dog GetDog(string name, string ownerId)
        {
            if (!ownersByIds.ContainsKey(ownerId))
            {
                throw new ArgumentException();
            }

            var owner = ownersByIds[ownerId];

            if (!owner.Dogs.ContainsKey(name))
            {
                throw new ArgumentException();
            }

            return owner.Dogs[name];
        }

        public Dog RemoveDog(string name, string ownerId)
        {
            if (!this.ownersByIds.ContainsKey(ownerId))
            {
                throw new ArgumentException();
            }

            var owner = this.ownersByIds[ownerId];
            
            if (!owner.Dogs.ContainsKey(name))
            {
                throw new ArgumentException();
            }

            var dog = owner.Dogs[name];
            owner.Dogs.Remove(name);
            this.dogsByIds.Remove(dog.Id);
            dog.Owner = null;

            return dog;
        }

        public IEnumerable<Dog> GetDogsByOwner(string ownerId)
        {
            if (!this.ownersByIds.ContainsKey(ownerId))
            {
                throw new ArgumentException();
            }

            return this.ownersByIds[ownerId].Dogs.Values;
        }

        public IEnumerable<Dog> GetDogsByBreed(Breed breed)
        {
            var list = this.dogsByIds.Values.Where(d => d.Breed == breed).ToList();

            if (list.Count == 0)
            {
                throw new ArgumentException();
            }

            return list;
        }

        public void Vaccinate(string name, string ownerId)
        {
            if (!this.ownersByIds.ContainsKey(ownerId))
            {
                throw new ArgumentException();
            }

            var owner = this.ownersByIds[ownerId];

            if (!owner.Dogs.ContainsKey(name))
            {
                throw new ArgumentException();
            }

            var dog = owner.Dogs[name];

            dog.Vaccines++;
        }

        public void Rename(string oldName, string newName, string ownerId)
        {
            if (!this.ownersByIds.ContainsKey(ownerId))
            {
                throw new ArgumentException();
            }

            var owner = this.ownersByIds[ownerId];

            if (!owner.Dogs.ContainsKey(oldName))
            {
                throw new ArgumentException();
            }


            var dog = owner.Dogs[oldName];
            owner.Dogs.Remove(oldName);
            owner.Dogs.Add(newName, dog);

            dog.Name = newName;
        }

        public IEnumerable<Dog> GetAllDogsByAge(int age)
        {
            var result = this.dogsByIds.Values.Where(d => d.Age == age).ToList();

            if (result.Count == 0)
            {
                throw new ArgumentException();
            }

            return result;
        }

        public IEnumerable<Dog> GetDogsInAgeRange(int lo, int hi)
        {
            return this.dogsByIds.Values.Where(d => d.Age >= lo && d.Age <= hi).ToList();

        }

        public IEnumerable<Dog> GetAllOrderedByAgeThenByNameThenByOwnerNameAscending()
        {
            var orderedDogs = this.dogsByIds.Values
                .OrderBy(d => d.Age)
                .ThenBy(d => d.Name)
                .ThenBy(d => d.Owner.Name)
                .ToList();

            if (orderedDogs.Count == 0)
            {
                throw new ArgumentException();
            }

            return orderedDogs;
        }
    }
}