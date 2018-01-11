using System.Collections.Generic;

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
    }
}
