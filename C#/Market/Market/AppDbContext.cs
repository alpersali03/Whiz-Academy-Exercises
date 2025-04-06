using Microsoft.EntityFrameworkCore;
using System;

namespace Market
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Market;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Explicitly defining precision for decimal properties
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Order>()
                .Property(o => o.TotalAmount)
                .HasColumnType("decimal(18,2)");

            // Fix dynamic DateTime issue by using a static value
            var fixedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Laptop", Price = 1200.99m, AvailableStock = 10 },
                new Product { Id = 2, Name = "Smartphone", Price = 699.50m, AvailableStock = 20 },
                new Product { Id = 3, Name = "Headphones", Price = 199.99m, AvailableStock = 50 },
                new Product { Id = 4, Name = "Tablet", Price = 499.99m, AvailableStock = 15 },
                new Product { Id = 5, Name = "Smartwatch", Price = 249.99m, AvailableStock = 30 },
                new Product { Id = 6, Name = "Monitor", Price = 299.99m, AvailableStock = 25 },
                new Product { Id = 7, Name = "Keyboard", Price = 89.99m, AvailableStock = 40 },
                new Product { Id = 8, Name = "Mouse", Price = 49.99m, AvailableStock = 60 },
                new Product { Id = 9, Name = "Printer", Price = 159.99m, AvailableStock = 12 }
            );

            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, FullName = "Alice Johnson", Email = "alice@example.com", PhoneNumber = "123-456-7890" },
                new Customer { Id = 2, FullName = "Bob Smith", Email = "bob@example.com", PhoneNumber = "987-654-3210" },
                new Customer { Id = 3, FullName = "Charlie Davis", Email = "charlie@example.com", PhoneNumber = "555-666-7777" },
                new Customer { Id = 4, FullName = "Diana Roberts", Email = "diana@example.com", PhoneNumber = "444-555-6666" },
                new Customer { Id = 5, FullName = "Edward Clark", Email = "edward@example.com", PhoneNumber = "111-222-3333" },
                new Customer { Id = 6, FullName = "Fiona Martinez", Email = "fiona@example.com", PhoneNumber = "888-999-0000" }
            );

            modelBuilder.Entity<Order>().HasData(
                new Order { Id = 1, CustomerId = 1, OrderDate = fixedDate, TotalAmount = 1200.99m },
                new Order { Id = 2, CustomerId = 2, OrderDate = fixedDate, TotalAmount = 699.50m },
                new Order { Id = 3, CustomerId = 3, OrderDate = fixedDate, TotalAmount = 499.99m },
                new Order { Id = 4, CustomerId = 4, OrderDate = fixedDate, TotalAmount = 199.99m },
                new Order { Id = 5, CustomerId = 5, OrderDate = fixedDate, TotalAmount = 249.99m },
                new Order { Id = 6, CustomerId = 6, OrderDate = fixedDate, TotalAmount = 299.99m },
                new Order { Id = 7, CustomerId = 1, OrderDate = fixedDate, TotalAmount = 89.99m },
                new Order { Id = 8, CustomerId = 2, OrderDate = fixedDate, TotalAmount = 49.99m },
                new Order { Id = 9, CustomerId = 3, OrderDate = fixedDate, TotalAmount = 159.99m }
            );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
