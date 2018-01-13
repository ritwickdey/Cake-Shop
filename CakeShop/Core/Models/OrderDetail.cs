namespace CakeShop.Core.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int CakeId { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }

        public Cake Cake { get; set; }
        public Order Order { get; set; }
    }
}
