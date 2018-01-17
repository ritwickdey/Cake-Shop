using System.ComponentModel.DataAnnotations;

namespace CakeShop.Core.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string CakeName { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
