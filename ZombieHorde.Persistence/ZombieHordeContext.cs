using Microsoft.EntityFrameworkCore;
using ZombieHorde.Core.Entities;
using ZombieHorde.Persistence.Maps;

namespace ZombieHorde.Persistence
{
    public class ZombieHordeContext: DbContext
    {
        public ZombieHordeContext(DbContextOptions<ZombieHordeContext> options) : base(options)
        {
        }

        public DbSet<ZombieEntity> Zombies { get; set; }

        public DbSet<ZombieLevelEntity> ZombieLevels { get; set; }
        public DbSet<SimulationEntity> Simulations { get; set; }

        public DbSet<SimulationDetailEntity> SimulationDetails { get; set; }

        public DbSet<ProfileEntity> Profiles { get; set; }

        public DbSet<UserEntity> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration<SimulationEntity>(new SimulationMap());
            modelBuilder.ApplyConfiguration<SimulationDetailEntity>(new SimulationDetailMap());
            modelBuilder.ApplyConfiguration<ZombieEntity>(new ZombieMap());
            modelBuilder.ApplyConfiguration<ZombieLevelEntity>(new ZombieLevelMap());
            modelBuilder.ApplyConfiguration<ProfileEntity>(new ProfileMap());
            modelBuilder.ApplyConfiguration<UserEntity>(new UserMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
