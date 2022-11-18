namespace WildFarm.Factories.Contracts
{
    using Models.Interfaces;

    public interface IAnimalFactory
    {
        IAnimal CreateAnimal(string[] animalArguments);
    }
}