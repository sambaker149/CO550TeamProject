using System.ComponentModel.DataAnnotations;

namespace CO550TeamProject.Models
{
    public class Option
    {
        [Key]
        public virtual ICollection<Shoe> Shoes { get; set; }
        [Required, StringLength(20)]
        public string Type { get; set; }
        [Required, StringLength(20)]
        public string Brand { get; set; }
        [Required, Range(1,20)]
        public decimal Size { get; set; }
        [StringLength(20)]
        public string Style { get; set; }
        [StringLength(20)]
        public string Colour { get; set; }
        public int Gender { get; set; }
    }
}
