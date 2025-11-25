using System.Runtime.InteropServices.Marshalling;
using EF_core_Advance.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Client.Extensibility;

namespace EF_core_Advance.Models;

public class ApplicationContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configBulder = new ConfigurationBuilder();
        var configuration = configBulder.AddJsonFile("appsettings.json").Build();
        var configSection = configuration.GetSection("ConnectionStrings");
        var connectionString = configSection["DBConnection"];
        optionsBuilder.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Role>()
            .Property(x => x.Name)
            .HasColumnType("nvarchar(100)");

        //// seed data:
        //modelBuilder.Entity<Role>()
        //    .HasData(
        //        new Role { Id = 1 ,Name = "Admin"},
        //        new Role { Id = 2 , Name = "Employee"}
        //    );

        //modelBuilder.Entity<User>()
        //    .HasData(new User { Id = 1, Name = "mehrshad", Family = "Khakifirooz", RoleId = 1 });


        modelBuilder.ApplyConfiguration(new OrderMapping());

        modelBuilder.ApplyConfiguration(new UserMapping());


    }

}
