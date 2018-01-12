using System.Collections.Generic;
using System.Threading.Tasks;

namespace CakeShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories =>
            new List<Category>
            {
                new Category { Id = 1, Name = "Vanilla Cakes",  Description = "Colorful & Testy"  },
                new Category { Id = 2, Name = "Chocolate Cakes", Description =  "Yaamy! & Chocolatey" },
                new Category { Id = 3, Name = "Red Velvet Cakes", Description = "Testy & New" },
                new Category { Id = 4, Name = "Fruit Cakes",  Description = "All Fruity cakes" }
            };

        public async Task<IEnumerable<Category>> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category { Id = 1, Name = "Vanilla Cakes",  Description = "Colorful & Testy"  },
                new Category { Id = 2, Name = "Chocolate Cakes", Description =  "Yaamy! & Chocolatey" },
                new Category { Id = 3, Name = "Red Velvet Cakes", Description = "Testy & New" },
                new Category { Id = 4, Name = "Fruit Cakes",  Description = "All Fruity cakes" }
            };

            return await Task.FromResult(categories);
        }
    }
}
