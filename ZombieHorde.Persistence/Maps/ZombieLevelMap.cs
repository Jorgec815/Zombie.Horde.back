using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZombieHorde.Core.Entities;

namespace ZombieHorde.Persistence.Maps
{
    public class ZombieLevelMap: IEntityTypeConfiguration<ZombieLevelEntity>
    {
        public void Configure(EntityTypeBuilder<ZombieLevelEntity> builder)
        {
            builder.ToTable("ZombieLevel");

            builder.HasKey(x => x.Id);

            builder.HasMany(zl => zl.Zombies)
                .WithOne(z => z.ZombieLevel)
                .HasForeignKey(z => z.ThreatLevelId)
                .HasPrincipalKey(zl => zl.Id)
                .OnDelete(DeleteBehavior.NoAction);
        }

    }
}
