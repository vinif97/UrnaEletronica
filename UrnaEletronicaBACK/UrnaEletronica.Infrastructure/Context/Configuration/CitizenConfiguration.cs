using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Infrastructure.Context.Configuration
{
    public class CitizenConfiguration : IEntityTypeConfiguration<Citizen>
    {
        public void Configure(EntityTypeBuilder<Citizen> builder)
        {
            builder.HasKey(citizen => citizen.CitizenId);
            builder.Property(citizen => citizen.CPF)
                .IsRequired()
                .HasColumnType("char")
                .HasMaxLength(11);
            builder.HasIndex(citizen => citizen.CPF)
                .IsUnique();
            builder.Property(citizen => citizen.FirstName)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(128);
            builder.Property(citizen => citizen.LastName)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(256);
            builder.HasOne(citizen => citizen.User)
                .WithOne(user => user.Citizen)
                .HasForeignKey<Citizen>(citizen => citizen.UserId)
                .IsRequired();
        }
    }
}
