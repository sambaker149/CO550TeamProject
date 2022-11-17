using System.ComponentModel.DataAnnotations;

namespace CO550TeamProject.Models
{
    public class Shoe
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } = String.Empty;

        [Required, StringLength(100)]
        public string Image { get; set; } = String.Empty;

        [StringLength(250)]
        public string Description { get; set; } = String.Empty;

        [Required, Range(15.00, 100.00)]
        public decimal Price { get; set; }
    }
}
