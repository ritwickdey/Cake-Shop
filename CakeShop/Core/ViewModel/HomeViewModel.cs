using CakeShop.Core.Models;
using System.Collections.Generic;

namespace CakeShop.Core.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<Cake> CakeOfTheWeek { get; set; }
    }
}
