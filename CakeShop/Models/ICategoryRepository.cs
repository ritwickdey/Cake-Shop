using System.Collections.Generic;
using System.Threading.Tasks;

namespace CakeShop.Models
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCategories();
    }
}
