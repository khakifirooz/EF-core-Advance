namespace EF_core_Advance.Models;

public class SeedData
{
    public static void InitializedDatabse(ApplicationContext context)
    {
        using var transaction = context.Database.BeginTransaction();
        if (context.Users.Any() && context.Roles.Any()) return;
        context.Database.EnsureCreated();
        var role1 = new Role { Name = "Admin" };
        var role2 = new Role { Name = "Employee" };
        context.Roles.AddRange(role1,role2);
        context.SaveChanges();
        var user = new User { Name = "Mehrshad" , Family = "Khakifirooz", RoleId = role1.Id };
        context.Users.Add(user);
        context.SaveChanges();
        transaction.Commit();

        Console.WriteLine("Secceed");
    }
}
