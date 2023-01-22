using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Infrastructure.Context.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(user => user.UserId);
            builder.Property(user => user.UserName)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(32);
            builder.HasIndex(user => user.UserName)
                .IsUnique();
            builder.Property(user => user.Email)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(128);
            builder.HasIndex(user => user.Email)
                .IsUnique();
            builder.Property(user => user.Password)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(128);
            builder.Property(user => user.ConfirmPassword)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(128);
            builder.Property(user => user.LoginAttemps)
                .IsRequired()
                .HasColumnType("tinyint");
            builder.Property(user => user.PasswordSalt)
                .IsRequired()
                .HasColumnType("binary")
                .HasMaxLength(64);
        }
    }
}
