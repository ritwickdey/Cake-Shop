using System.ComponentModel.DataAnnotations;

namespace CakeShop.Core.Dto
{
    public class CakeDto
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Cake Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Short Description")]
        public string ShortDescription { get; set; }

        [Required]
        [Display(Name = "Long Description")]
        public string LongDescription { get; set; }

        [Required]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Image Url")]
        public string ImageUrl { get; set; }

        [Display(Name = "Is Cake Of the Week? ")]
        public bool IsCakeOfTheWeek { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }
    }
}
