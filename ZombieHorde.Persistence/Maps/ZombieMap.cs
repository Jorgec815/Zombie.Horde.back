using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZombieHorde.Core.Entities;

namespace ZombieHorde.Persistence.Maps
{
    public class ZombieMap : IEntityTypeConfiguration<ZombieEntity>
    {
        public void Configure(EntityTypeBuilder<ZombieEntity> builder)
        {
            builder.ToTable("Zombie");

            builder.HasKey(x => x.Id);

            builder.HasOne(z => z.ZombieLevel)
                .WithMany(zl => zl.Zombies)
                .HasForeignKey(z => z.ThreatLevelId)
                .HasPrincipalKey(zl => zl.Id)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
