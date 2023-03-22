using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.IO;
using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Infrastructure.Context.Configuration
{
    public class PartyConfiguration : IEntityTypeConfiguration<Party>
    {
        public void Configure(EntityTypeBuilder<Party> builder)
        {
            builder.HasKey(party => party.PartyId);
            builder.Property(party => party.Name)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(128);
            builder.HasIndex(party => party.Name)
                .IsUnique();
            builder.Property(party => party.Acronym)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(16);
            builder.HasIndex(party => party.Acronym)
                .IsUnique();
            builder.Property(party => party.Description)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(256);
        }
    }
}
