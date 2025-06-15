using Domain.Entities.PaymentMethod;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configuration
{
    public class PaymentMethodConfiguration : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.ToTable("PaymentMethod");
            builder.HasKey(pm => pm.Id);

            builder.Property(pm => pm.Id)
                .HasConversion(Id => Id.Value, value => new PaymentMethodId(value));

            builder.Property(pm => pm.Name)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
