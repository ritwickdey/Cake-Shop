using Microsoft.EntityFrameworkCore;

namespace CakeShop.Models
{
    public class CakeShopDbContext : DbContext
    {
        public DbSet<Cake> Cakes { get; set; }
        public DbSet<Category> Categories { get; set; }

        public CakeShopDbContext(DbContextOptions<CakeShopDbContext> options)
            : base(options)
        {

        }
    }
}
