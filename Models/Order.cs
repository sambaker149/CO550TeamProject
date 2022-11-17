using System.ComponentModel.DataAnnotations;

namespace CO550TeamProject.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime PlannedDelivery { get; set; }

        [DataType(DataType.Date)]
        public DateTime ActualDelivery { get; set; }

        [StringLength(20)]
        public string OrderStatus { get; set; } = String.Empty;

        // Navigation Properties
        public virtual ICollection<Customer> CustomerDetails { get; set; }
    }
}
