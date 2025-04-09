using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEntityFramework
{
    public class AppDbContext:DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
 modelBuilder.Entity<Category>().HasData(
        new Category { Id = 1, Name = "Electronics" },
        new Category { Id = 2, Name = "Clothing" },
        new Category { Id = 3, Name = "Books" },
        new Category { Id = 4, Name = "Home & Kitchen" },
        new Category { Id = 5, Name = "Toys" },
        new Category { Id = 6, Name = "Sports" }
    );

    // Seed Products
    modelBuilder.Entity<Product>().HasData(
        new Product { Id = 1, Name = "Smartphone", Price = 299.99M, CategoryId = 1 },
        new Product { Id = 2, Name = "Laptop", Price = 799.99M, CategoryId = 1 },
        new Product { Id = 3, Name = "Headphones", Price = 49.99M, CategoryId = 1 },
        new Product { Id = 4, Name = "T-Shirt", Price = 19.99M, CategoryId = 2 },
        new Product { Id = 5, Name = "Jeans", Price = 39.99M, CategoryId = 2 },
        new Product { Id = 6, Name = "Jacket", Price = 89.99M, CategoryId = 2 },
        new Product { Id = 7, Name = "Novel", Price = 14.99M, CategoryId = 3 },
        new Product { Id = 8, Name = "Cookbook", Price = 29.99M, CategoryId = 3 },
        new Product { Id = 9, Name = "Comics", Price = 9.99M, CategoryId = 3 },
        new Product { Id = 10, Name = "Blender", Price = 49.99M, CategoryId = 4 },
        new Product { Id = 11, Name = "Microwave", Price = 99.99M, CategoryId = 4 },
        new Product { Id = 12, Name = "Vacuum Cleaner", Price = 149.99M, CategoryId = 4 },
        new Product { Id = 13, Name = "Board Game", Price = 24.99M, CategoryId = 5 },
        new Product { Id = 14, Name = "Action Figure", Price = 14.99M, CategoryId = 5 },
        new Product { Id = 15, Name = "Puzzle", Price = 9.99M, CategoryId = 5 },
        new Product { Id = 16, Name = "Football", Price = 19.99M, CategoryId = 6 },
        new Product { Id = 17, Name = "Basketball", Price = 29.99M, CategoryId = 6 },
        new Product { Id = 18, Name = "Tennis Racket", Price = 49.99M, CategoryId = 6 },
        new Product { Id = 19, Name = "Camera", Price = 499.99M, CategoryId = 1 },
        new Product { Id = 20, Name = "Smartwatch", Price = 199.99M, CategoryId = 1 },
        new Product { Id = 21, Name = "Socks", Price = 4.99M, CategoryId = 2 },
        new Product { Id = 22, Name = "Sneakers", Price = 59.99M, CategoryId = 2 },
        new Product { Id = 23, Name = "Fantasy Novel", Price = 19.99M, CategoryId = 3 },
        new Product { Id = 24, Name = "Cookware Set", Price = 79.99M, CategoryId = 4 },
        new Product { Id = 25, Name = "Plush Toy", Price = 19.99M, CategoryId = 5 },
        new Product { Id = 26, Name = "Outdoor Tent", Price = 129.99M, CategoryId = 6 },
        new Product { Id = 27, Name = "Portable Speaker", Price = 99.99M, CategoryId = 1 },
        new Product { Id = 28, Name = "Winter Coat", Price = 129.99M, CategoryId = 2 },
        new Product { Id = 29, Name = "Comic Book", Price = 14.99M, CategoryId = 3 },
        new Product { Id = 30, Name = "Coffee Maker", Price = 59.99M, CategoryId = 4 }
    );
            }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-AUT50J3;Database=Market;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
