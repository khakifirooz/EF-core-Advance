using EF_core_Advance.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client.Extensibility;

namespace EF_core_Advance.Mapping;

public class OrderMapping : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasQueryFilter(x => x.IsDeleted == false);  // Global filtering

        builder.Property(x => x.TotalPrice >= 1000);
    }
}
