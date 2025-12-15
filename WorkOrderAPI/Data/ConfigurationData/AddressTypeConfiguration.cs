using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkOrderAPI.Models;

namespace WorkOrderAPI.Data.ConfigurationData
{
    public class AddressTypeConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("address");

            builder.HasKey(a => a.Id);

            builder
               .Property(x => x.Id)
               .HasColumnType("int")
               .HasColumnName("id")
               .IsRequired();

            builder
               .Property(x => x.Country)
               .HasColumnType("varchar(20)")
               .HasColumnName("country")
               .IsRequired();

            builder
               .Property(x => x.City)
               .HasColumnType("varchar(40)")
               .HasColumnName("city")
               .IsRequired();

            builder
               .Property(x => x.PostalCode)
               .HasColumnType("varchar(20)")
               .HasColumnName("postal_code")
               .IsRequired();

            builder
               .Property(x => x.Region)
               .HasColumnType("varchar(40)")
               .HasColumnName("region")
               .IsRequired();
        }
    }
}
