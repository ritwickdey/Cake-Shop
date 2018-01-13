using CakeShop.Core.Models;
using System.Collections.Generic;

namespace CakeShop.Models.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<Cake> CakeOfTheWeek { get; set; }
    }
}
