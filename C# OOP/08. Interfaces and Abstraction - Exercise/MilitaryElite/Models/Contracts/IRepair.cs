namespace MilitaryElite.Models.Contracts
{
    public interface IRepair
    {
        string RepairPart { get; }

        int RepairHours { get; }
    }
}
