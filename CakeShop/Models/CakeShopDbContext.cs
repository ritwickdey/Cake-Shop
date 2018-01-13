using CakeShop.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace CakeShop.Models
{
    public class CakeShopDbContext : DbContext
    {
        public DbSet<Cake> Cakes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }


        public CakeShopDbContext(DbContextOptions<CakeShopDbContext> options)
            : base(options)
        {

        }
    }
}
