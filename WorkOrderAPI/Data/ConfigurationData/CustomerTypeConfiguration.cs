using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkOrderAPI.Models;

namespace WorkOrderAPI.Data.ConfigurationData
{
    public class CustomerTypeConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");
            builder.HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .HasColumnType("integer")
                .HasColumnName("id")
                .IsRequired();

            builder
                .Property(x => x.Name)
                .HasColumnType("varchar(40)")
                .HasColumnName("name")
                .IsRequired();

            builder
                .Property(x => x.PhoneNumber)
                .HasColumnType("varchar(40)")
                .HasColumnName("PhoneNumber")
                .IsRequired();

            builder
                .Property(x => x.Email)
                .HasColumnType("varchar(40)")
                .HasColumnName("Email")
                .IsRequired();

            builder
                .Property(x=>x.AddressId)
                .HasColumnName("AddressId")
                .HasColumnType ("integer")
                .IsRequired ();

            builder
                .HasOne(x => x.Address)
                .WithOne()
                .HasForeignKey<Customer>(x => x.AddressId) // pai Cliente contem o children (endereco)
                .IsRequired();

        }
    }
}
