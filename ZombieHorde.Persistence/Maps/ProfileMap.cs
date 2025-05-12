using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZombieHorde.Core.Entities;

namespace ZombieHorde.Persistence.Maps
{
    public class ProfileMap : IEntityTypeConfiguration<ProfileEntity>
    {
        public void Configure(EntityTypeBuilder<ProfileEntity> builder)
        {
            builder.ToTable("Profile");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Description)
                .HasColumnName("Description")
                .HasMaxLength(100);

            builder.Property(x => x.RegisterDate)
                .HasColumnName("RegisterDate")
                .IsRequired()
                .HasDefaultValueSql("GETDATE()");

            builder.Property(x => x.RegisterBy)
                .HasColumnName("RegisterBy")
                .IsRequired();

            builder.Property(x => x.EditionBy)
                .HasColumnName("EditionBy");

            builder.Property(x => x.EditionDate)
                .HasColumnName("EditionDate");

            builder.HasMany(p => p.Users)
                .WithOne(u => u.Profile)
                .HasForeignKey(u => u.ProfileId)
                .HasPrincipalKey(p => p.Id)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
