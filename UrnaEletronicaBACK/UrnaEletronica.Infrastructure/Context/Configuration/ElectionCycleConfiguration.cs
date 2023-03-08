using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Infrastructure.Context.Configuration
{
    public class ElectionCycleConfiguration : IEntityTypeConfiguration<ElectionCycle>
    {
        public void Configure(EntityTypeBuilder<ElectionCycle> builder)
        {
            builder.HasKey(electionCycle => electionCycle.ElectionCycleId);
            builder.Property(electionCycle => electionCycle.PoliticalRole)
                .HasColumnType("tinyint")
                .IsRequired();
            builder.HasIndex(electionCycle => new
            {
                electionCycle.ElectionId,
                electionCycle.PoliticalRole,
            })
                .IsUnique();
            builder.HasOne(electionCycle => electionCycle.Election)
                .WithMany(election => election.ElectionCycles)
                .HasForeignKey(electionCycle => electionCycle.ElectionId)
                .IsRequired();
        }
    }
}
