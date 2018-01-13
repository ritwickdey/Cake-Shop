using CakeShop.Core.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShop.Persistence
{
    public class MockCakeRepository : ICakeRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public async Task<IEnumerable<Cake>> GetCakes(string category = null)
        {
            var cakes = new List<Cake>
            {
                new Cake { Id = 1, Name="Strawberry Cake", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot cake jelly-o cheesecake. tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake.dragée gummies.", Category = (await _categoryRepository.GetCategories()).ToList()[0],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", InStock=true, IsCakeOfTheWeek=false, ImageThumbnailUrl="/img/chocolate-cake2.jpg"},
                new Cake { Id = 2, Name="Cheese Cake", Price=18.95M, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot cake jelly-o cheesecake. tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake.dragée gummies.", Category = (await _categoryRepository.GetCategories()).ToList()[1],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", InStock=true, IsCakeOfTheWeek=false, ImageThumbnailUrl="/img/fruit-cake.jpg"},
                new Cake { Id = 3, Name="Rhubarb Cake", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot cake jelly-o cheesecake. tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake.dragée gummies.", Category = (await _categoryRepository.GetCategories()).ToList()[0],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg", InStock=true, IsCakeOfTheWeek=true, ImageThumbnailUrl="/img/vanilla-cake2.jpg"},
                new Cake { Id = 4, Name="Pumpkin Cake", Price=12.95M, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot cake jelly-o cheesecake. tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake.caramels.", Category = (await _categoryRepository.GetCategories()).ToList()[2],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg", InStock=true, IsCakeOfTheWeek=true, ImageThumbnailUrl="/img/chocolate-cake3.jpg"}

            };

            return await Task.FromResult(cakes);
        }

        public async Task<Cake> GetCakeById(int cakeId)
        {
            var cakes = await GetCakes();
            return cakes.Where(e => e.Id == cakeId).SingleOrDefault();
        }

        public Task<IEnumerable<Cake>> GetCakesOfTheWeek()
        {
            throw new System.NotImplementedException();
        }
    }
}
