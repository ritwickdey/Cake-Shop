using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CakeShop.Core.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Cake> Cakes { get; set; }

        public Category()
        {
            Cakes = new Collection<Cake>();
        }
    }
}
