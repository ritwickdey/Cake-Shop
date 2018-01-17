using CakeShop.Core.Dto;
using CakeShop.Core.Models;
using System.Collections.Generic;

namespace CakeShop.Core.ViewModel
{
    public class CakeCreateUpdateViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
        public CakeDto CakeDto { get; set; }

        public CakeCreateUpdateViewModel()
        {
            Categories = new List<Category>();
        }
    }
}
