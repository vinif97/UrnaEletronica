using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Infrastructure.Context.Configuration
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(address => address.AddressId);
            builder.Property(address => address.StreetAddress)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(256);
            builder.Property(address => address.Number)
                .IsRequired()
                .HasColumnType("smallint")
                .HasPrecision(5);
            builder.Property(address => address.Complement)
                .HasMaxLength(128);
            builder.Property(address => address.Reference)
                .HasColumnType("varchar")
                .HasMaxLength(256);
            builder.Property(address => address.Zipcode)
                .HasColumnType("char")
                .HasMaxLength(9)
                .IsRequired();
            builder.HasOne(address => address.User)
                .WithOne(user => user.Address)
                .HasForeignKey<Address>(address => address.UserId)
                .IsRequired();
            builder.HasOne(address => address.City)
                .WithMany(city => city.Addresses)
                .IsRequired();
        }
    }
}
