namespace WildFarm.Factories
{
    using Contracts;
    using Exceptions;
    using Models.Animals;
    using Models.Interfaces;

    public class AnimalFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal(string[] animalArguments)
        {
            var type = animalArguments[0];
            var name = animalArguments[1];
            var weight = double.Parse(animalArguments[2]);

            IAnimal animal;

            if (type == "Owl")
            {
                var wingSize = double.Parse(animalArguments[3]);
                animal = new Owl(name, weight, wingSize);
            }
            else if (type == "Hen")
            {
                var wingSize = double.Parse(animalArguments[3]);
                animal = new Hen(name, weight, wingSize);
            }
            else if (type == "Mouse")
            {
                var livingRegion = animalArguments[3];
                animal = new Mouse(name, weight, livingRegion);
            }
            else if (type == "Dog")
            {
                var livingRegion = animalArguments[3];
                animal = new Dog(name, weight, livingRegion);
            }
            else if (type == "Cat")
            {
                var livingRegion = animalArguments[3];
                var breed = animalArguments[4];
                animal = new Cat(name, weight, livingRegion, breed);
            }
            else if (type == "Tiger")
            {
                var livingRegion = animalArguments[3];
                var breed = animalArguments[4];
                animal = new Tiger(name, weight, livingRegion, breed);
            }
            else
            {
                throw new InvalidAnimalTypeException();
            }

            return animal;
        }
    }
}