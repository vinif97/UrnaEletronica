using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Infrastructure.Context.Configuration
{
    public class StateConfiguration : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.HasKey(state => state.StateId);
            builder.Property(state => state.StateName)
                .HasColumnType("varchar")
                .HasMaxLength(128)
                .IsRequired();
            builder.HasIndex(state => state.StateName)
                .IsUnique();
            builder.HasOne(state => state.Country)
                .WithMany(c => c.States)
                .IsRequired();
        }
    }
}
