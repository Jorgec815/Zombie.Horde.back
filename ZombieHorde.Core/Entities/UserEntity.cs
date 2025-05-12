namespace ZombieHorde.Core.Entities
{
    public class UserEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public Guid ProfileId { get; set; }

        public DateTime RegisterDate { get; set; }

        public string RegisterBy { get; set; }

        public DateTime? EditionDate { get; set; }

        public string? EditionBy { get; set; }

        public ProfileEntity? Profile { get; set; }

        public ICollection<SimulationEntity>? Simulations { get; set; }
    }
}
