namespace ZombieHorde.Core.Entities
{
    public class SimulationDetailEntity
    {
        public Guid Id { get; set; }

        public Guid SimulationId { get; set; }

        public Guid ZombieId { get; set; }

        public short ZombiesDefeated { get; set; }

        public DateTime RegisterDate { get; set; }

        public string RegisterBy { get; set; }

        public DateTime? EditionDate { get; set; }

        public string? EditionBy { get; set; }

        public SimulationEntity Simulation { get; set; }

        public ZombieEntity Zombie { get; set; }
    }
}
