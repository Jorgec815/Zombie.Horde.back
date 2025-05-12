namespace ZombieHorde.Core.Entities
{
    public class ZombieEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid ThreatLevelId { get; set; }

        public short TimeNeeded { get; set; }

        public short NeccesaryBullets { get; set; }

        public short Score { get; set; }

        public DateTime RegisterDate { get; set; }

        public string RegisterBy { get; set; }

        public DateTime? EditionDate { get; set; }

        public string? EditionBy { get; set; }

        public ZombieLevelEntity ZombieLevel { get; set; }

        public ICollection<SimulationDetailEntity>? SimulationDetails { get; set; }
    }
}
