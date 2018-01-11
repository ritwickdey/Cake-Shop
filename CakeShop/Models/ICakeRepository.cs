using System.Collections.Generic;

namespace CakeShop.Models
{
    public interface ICakeRepository
    {
        IEnumerable<Cake> Cakes { get; }
        IEnumerable<Cake> CakesOfTheWeek { get; }

        Cake GetCakeById(int cakeId);
    }
}
