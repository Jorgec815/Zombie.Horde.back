namespace ZombieHorde.Core.Entities
{
    public class ZombieLevelEntity
    {
        public ZombieLevelEntity()
        {
            Zombies = new HashSet<ZombieEntity>();
        }
        public Guid Id { get; set; }

        public string Description { get; set; }

        public byte Level { get; set; }

        public DateTime RegisterDate { get; set; }

        public string RegisterBy { get; set; }

        public DateTime? EditionDate { get; set; }

        public string? EditionBy { get; set; }

        public ICollection<ZombieEntity> Zombies { get; set; }
    }
}
