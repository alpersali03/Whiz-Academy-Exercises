using Microsoft.EntityFrameworkCore;
using NewEntityFramework;

using(AppDbContext data = new AppDbContext())
{
    List<Product> products = data.Products.Include(c => c.Category).ToList();
    ;

}