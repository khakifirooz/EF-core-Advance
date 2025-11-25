

// seed data

using EF_core_Advance.Models;

using var context = new ApplicationContext();
SeedData.InitializedDatabse(context);

Console.ReadKey();
