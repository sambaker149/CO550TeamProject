using System.ComponentModel.DataAnnotations;

namespace CO550TeamProject.Models
{
    public class CustomerAddress
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int HouseNumber { get; set; }

        [StringLength(25)]
        public string HouseName { get; set; } = String.Empty;

        [Required, StringLength(50)]
        public string RoadName { get; set; } = String.Empty;

        [Required, StringLength(50)]
        public string PostTown { get; set; } = String.Empty;

        [Required, StringLength(8), DataType(DataType.PostalCode)]
        public string Postcode { get; set; } = String.Empty;
    }
}
