using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UrnaEletronica.Domain.Model;
using UrnaEletronica.Domain.ValueObject;

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
            builder.OwnsOne(user => user.Password)
                .Property(user => user.PasswordString)
                .IsRequired()
                .HasColumnName("Password")
                .HasColumnType("varchar")
                .HasMaxLength(128);
            builder.OwnsOne(user => user.Password)
                .Property(user => user.ConfirmPassword)
                .IsRequired()
                .HasColumnName("ConfirmPassword")
                .HasColumnType("varchar")
                .HasMaxLength(128);
            builder.Property(user => user.LoginAttemps)
                .IsRequired()
                .HasColumnType("tinyint");
            builder.OwnsOne(user => user.Password)
                .Property(user => user.PasswordSalt)
                .IsRequired()
                .HasColumnName("PasswordSalt")
                .HasColumnType("binary")
                .HasMaxLength(64);
        }
    }
}
