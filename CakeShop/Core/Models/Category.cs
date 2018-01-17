using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace CakeShop.Core.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public ICollection<Cake> Cakes { get; set; }

        public Category()
        {
            Cakes = new Collection<Cake>();
        }
    }
}
