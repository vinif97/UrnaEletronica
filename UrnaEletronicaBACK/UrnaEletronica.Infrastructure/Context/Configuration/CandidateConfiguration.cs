using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Infrastructure.Context.Configuration
{
    public class CandidateConfiguration : IEntityTypeConfiguration<Candidate>
    {
        public void Configure(EntityTypeBuilder<Candidate> builder)
        {
            builder.HasKey(candidate => candidate.CandidateId);
            builder.Property(candidate => candidate.FullName)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(256);
            builder.Property(candidate => candidate.FullName)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(256);
            builder.Property(candidate => candidate.PoliticalRole)
                .IsRequired()
                .HasColumnType("tinyint");
            builder.HasOne(candidate => candidate.Party)
                .WithMany(party => party.Candidates)
                .IsRequired();
            builder.HasOne(candidate => candidate.ElectionCycle)
                .WithMany(electionCycle => electionCycle.Candidates);
        }
    }
}
