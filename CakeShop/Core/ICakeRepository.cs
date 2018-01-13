using System.Collections.Generic;
using System.Threading.Tasks;

namespace CakeShop.Models
{
    public interface ICakeRepository
    {
        Task<IEnumerable<Cake>> GetCakes(string category = null);
        Task<IEnumerable<Cake>> GetCakesOfTheWeek();

        Task<Cake> GetCakeById(int cakeId);
    }
}
