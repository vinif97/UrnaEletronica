using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Infrastructure.Context.Configuration
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(city => city.CityId);
            builder.Property(city => city.CityName)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(128);
            builder.HasIndex(city => city.CityName)
                .IsUnique();
            builder.HasOne(city => city.State)
                .WithMany(state => state.Cities)
                .IsRequired();
    }
}
}
