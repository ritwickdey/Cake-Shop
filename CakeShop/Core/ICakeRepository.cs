using CakeShop.Core.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CakeShop.Core.Models
{
    public interface ICakeRepository
    {
        Task<IEnumerable<Cake>> GetCakes(string category = null);
        Task<IEnumerable<Cake>> GetCakesOfTheWeek();

        Task<Cake> GetCakeById(int cakeId);

        Task<IEnumerable<CakeNameIdDto>> GetAllCakesNameId();

        void UpdateCake(Cake cake);
        Task AddCakeAsync(Cake cake);
        void Delete(int id);
    }
}
