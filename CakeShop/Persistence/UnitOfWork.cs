using CakeShop.Core;
using System.Threading.Tasks;

namespace CakeShop.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CakeShopDbContext _context;

        public UnitOfWork(CakeShopDbContext context)
        {
            _context = context;
        }

        public async Task CompleteAsync() =>
            await _context.SaveChangesAsync();
    }
}
