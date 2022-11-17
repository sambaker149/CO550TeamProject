using System.ComponentModel.DataAnnotations;

namespace CO550TeamProject.Models
{
    public class OrderItem
    {
        [Key]
        public virtual ICollection<Shoe> Shoes { get; set; }

        [Key]
        public virtual ICollection<Order> Orders { get; set; }

        [Required, Range(15.00,100)]
        public decimal SalePrice { get; set; }

        [Required, Range(1,5)]
        public int Quantity { get; set; }
    }
}
