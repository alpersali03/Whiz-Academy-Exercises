
using Market;
using Microsoft.EntityFrameworkCore;
using System;

using var context = new AppDbContext();

// 1.Get all product names and prices.
var allProductsNamesNPrices = context.Products
.Select(x=>new { x.Name, x.Price })
.ToList();

//2.Find customers who have placed at least one order.
//var customers = context.Customers
//    .Include(c => c.Orders)  
//    .Where(c => c.Orders.Count() > 0) 
//    .ToList();

//3.Get a list of products sorted by price (lowest to highest).
//var productSortedByPrice = context.Products.OrderBy(p => p.Price).ToList();

//4. Find the most expensive product.
//var mostExpensiveProd = context.Products.OrderByDescending(p => p.Price).ToList();

//5.Retrieve the total number of orders placed.
//var totalOrders = context.Orders.Count();

//6.Get the customer who has spent the most (total order amount).
//var theRichest = context.Customers.Include(o=>o.Orders).Where(x=>x.Orders.Count > 0).ToList();

//7.Find all orders placed in the last 30 days.
//var ordersDate = context.Orders.Where(o=>o.OrderDate >=  DateTime.Now.AddDays(-30));

//8.Get a list of customers along with the number of orders they placed.
//var listOfCustomersWithOrders = context.Customers.Include(x => x.Orders.Count()).ToList();

//9.Find products that are out of stock (Stock = 0).
//var outOfStock = context.Products.Where(p=>p.AvailableStock == 0).ToList();

//10. Find the most recent order placed.
//var recentOrder = context.Orders.OrderByDescending(o => o.OrderDate).Take(1).ToList();

//11.Find customers who have placed at least one order.
//var customersOrders = context.Customers.Include(o => o.Orders).Where(x=>x.Orders.Count() == 0);

//12.Get a list of products sorted by price (lowest to highest).
//var listProducts = context.Products.OrderBy(p => p.Price).ToList();

//13.Find the most expensive product
//var mostExpensive = context.Products.OrderByDescending(p => p.Id).Take(1).ToList();

//14.Retrieve the total number of orders placed.
//var totalNumberOfOrders = context.Orders.Count();



;
