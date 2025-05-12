namespace ZombieHorde.Core.Entities
{
    public class SimulationEntity
    {
        public SimulationEntity()
        {
            SimulationDetails = new HashSet<SimulationDetailEntity>();
        }
        public Guid Id { get; set; }

        public short AvalibleBullets { get; set; }

        public short AvalibleTime { get; set; }

        public short TotalScore { get; set; }

        public Guid UserId { get; set; }

        public DateTime RegisterDate { get; set; }

        public string RegisterBy { get; set; }

        public DateTime? EditionDate { get; set; }

        public string? EditionBy { get; set; }
        public UserEntity User { get; set; }

        public ICollection<SimulationDetailEntity> SimulationDetails { get; set; }
    }
}
