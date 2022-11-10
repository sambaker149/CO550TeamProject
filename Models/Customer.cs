using System.ComponentModel.DataAnnotations;

namespace CO550TeamProject.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(20)]
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        [Required, StringLength(100)]
        public string Email { get; set; }
        [StringLength(100)]
        public string PhoneNumber { get; set; }
        // Navigation Properties
        public CustomerAddress Address { get; set; }
        public CustomerPayment Payment { get; set; }
    }
}
