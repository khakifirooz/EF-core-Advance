using EF_core_Advance.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_core_Advance.Mapping;

public class UserMapping : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(x => x.Name)
            .HasColumnType("nvarchar(100)")
            .HasColumnName("First_Name");

        builder.Property(x => x.Family)
            .HasColumnType("nvarchar(100)")
            .HasColumnName("Last_Name");
    }
}
