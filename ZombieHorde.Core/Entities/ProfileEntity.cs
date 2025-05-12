namespace ZombieHorde.Core.Entities
{
    public class ProfileEntity
    {
        public ProfileEntity()
        {
            Users = new HashSet<UserEntity>();
        }
        public Guid Id { get; set; }

        public string Description { get; set; }

        public DateTime RegisterDate { get; set; }

        public string RegisterBy { get; set; }

        public DateTime? EditionDate { get; set; }

        public string? EditionBy { get; set; }

        public ICollection<UserEntity> Users { get; set; }
    }
}
