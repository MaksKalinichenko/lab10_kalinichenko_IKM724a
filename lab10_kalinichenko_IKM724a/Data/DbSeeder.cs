using lab10_kalinichenko_IKM724a.Models;

namespace lab10_kalinichenko_IKM724a.Data;

public static class DbSeeder
{
    public static void SeedData(ApplicationDbContext context)
    {
        if (!context.Products.Any())
        {
            context.Products.AddRange(
                new Product { Name = "Laptop", Price = 1000, CategoryId = 1 },
                new Product { Name = "Smartphone", Price = 500, CategoryId = 1 },
                new Product { Name = "ASP.NET Core Book", Price = 30, CategoryId = 2 }
            );
            context.SaveChanges();
        }
    }
}