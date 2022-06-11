using System.ComponentModel.DataAnnotations.Schema;

namespace RadiaTagineShop.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int TagineId { get; set; }
        public int Amount { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        public Tagine Tagine { get; set; }
        public Order Order { get; set; }
    }
}
