using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZombieHorde.Core.Entities;

namespace ZombieHorde.Persistence.Maps
{
    public class SimulationMap : IEntityTypeConfiguration<SimulationEntity>
    {
        public void Configure(EntityTypeBuilder<SimulationEntity> builder)
        {
            builder.ToTable("Simulation");

            builder.HasKey(x => x.Id);

            builder.HasOne(s => s.User)
                .WithMany(u => u.Simulations)
                .HasForeignKey(s => s.UserId)
                .HasPrincipalKey(u => u.Id)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(s => s.SimulationDetails)
                .WithOne(sd => sd.Simulation)
                .HasForeignKey(sd => sd.SimulationId)
                .HasPrincipalKey(s => s.Id)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
