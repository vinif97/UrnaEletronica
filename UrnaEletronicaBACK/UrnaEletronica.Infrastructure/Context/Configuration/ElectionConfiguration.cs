using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Infrastructure.Context.Configuration
{
    public class ElectionConfiguration : IEntityTypeConfiguration<Election>
    {
        public void Configure(EntityTypeBuilder<Election> builder)
        {
            builder.HasKey(election => election.ElectionId);
            builder.Property(election => election.ElectionYear)
                .IsRequired()
                .HasColumnType("tinyint");
            builder.HasIndex(election => election.ElectionYear)
                .IsUnique();
        }
    }
}
