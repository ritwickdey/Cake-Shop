using CakeShop.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CakeShop.Persistence
{
    public class CakeShopDbContext : IdentityDbContext<IdentityUser>
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
