using System.Collections.Generic;
using System.Threading.Tasks;

namespace CakeShop.Models
{
    public interface ICakeRepository
    {
        Task<IEnumerable<Cake>> GetCakes();
        Task<IEnumerable<Cake>> GetCakesOfTheWeek();

        Task<Cake> GetCakeById(int cakeId);
    }
}
