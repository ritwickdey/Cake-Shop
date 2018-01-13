using CakeShop.Core.Models;
using System.Collections.Generic;

namespace CakeShop.Core.ViewModel
{
    public class CakesListViewModel
    {
        public IEnumerable<Cake> Cakes { get; set; }
        public string CurrentCategory { get; set; }
    }
}
