

// seed data

using EF_core_Advance.Models;

//using var context = new ApplicationContext();
//SeedData.InitializedDatabse(context);

//Global Query Filter
using var context = new ApplicationContext();
var oredr1 = new Order(200000,DateOnly.FromDateTime(DateTime.Now));
var oredr2 = new Order(300000, DateOnly.FromDateTime(DateTime.Now));
context.Orders.AddRange(oredr1, oredr2);
context.SaveChanges();

Console.WriteLine("Succeed");

Console.ReadKey();
