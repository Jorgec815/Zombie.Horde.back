using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZombieHorde.Core.Entities;

namespace ZombieHorde.Persistence.Maps
{
    public class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("User");

            builder.HasKey(x => x.Id);

            builder.Property(u => u.Name)
                .HasColumnName("Name")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(u => u.Email)
                .HasColumnName("Email")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(u => u.Password)
                .HasColumnName("Password")
                .IsRequired()
                .HasMaxLength(256);

            builder.Property(u => u.ProfileId)
                .HasColumnName("ProfileId")
                .IsRequired();

            builder.Property(u => u.RegisterDate)
                .HasColumnName("RegisterDate")
                .IsRequired()
                .HasDefaultValueSql("GETDATE()");

            builder.Property(u => u.RegisterBy)
                .HasColumnName("RegisterBy")
                .IsRequired();

            builder.Property(u => u.EditionBy)
                .HasColumnName("EditionBy");

            builder.Property(u => u.EditionDate)
                .HasColumnName("EditionDate");

            builder.HasMany(u => u.Simulations)
                .WithOne(s => s.User)
                .HasForeignKey(s => s.UserId)
                .HasPrincipalKey(u => u.Id)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(u => u.Profile)
                .WithMany(p => p.Users)
                .HasForeignKey(u => u.ProfileId)
                .HasPrincipalKey(p => p.Id)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
