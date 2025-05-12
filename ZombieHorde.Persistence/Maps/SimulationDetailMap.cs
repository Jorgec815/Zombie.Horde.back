using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZombieHorde.Core.Entities;

namespace ZombieHorde.Persistence.Maps
{
    public class SimulationDetailMap : IEntityTypeConfiguration<SimulationDetailEntity>
    {
        public void Configure(EntityTypeBuilder<SimulationDetailEntity> builder)
        {
            builder.ToTable("SimulationDetail");

            builder.HasKey(x => x.Id);

            builder.HasOne(sd => sd.Simulation)
                .WithMany(s => s.SimulationDetails)
                .HasForeignKey(sd => sd.SimulationId)
                .HasPrincipalKey(s => s.Id)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(sd => sd.Zombie)
                .WithMany(z => z.SimulationDetails)
                .HasForeignKey(sd => sd.ZombieId)
                .HasPrincipalKey(z => z.Id)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
