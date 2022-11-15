namespace MilitaryElite.Models
{
    using Contracts;

    public class Repair : IRepair
    {
        public Repair(string repairPart, int repairHours)
        {
            this.RepairPart = repairPart;
            this.RepairHours = repairHours;
        }
        public string RepairPart { get; }

        public int RepairHours { get; }

        public override string ToString()
        {
            return $"Part Name: {this.RepairPart} Hours Worked: {this.RepairHours}";
        }
    }
}
