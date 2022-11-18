namespace WildFarm.Factories.Contracts
{
    using Models.Interfaces;

    public interface IFoodFactory
    {
        IFood CreateFood(string type, int quantity);
    }
}