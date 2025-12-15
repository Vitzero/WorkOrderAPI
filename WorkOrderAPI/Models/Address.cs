using System.ComponentModel.DataAnnotations;

namespace WorkOrderAPI.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Region { get; set; }

        public string PostalCode { get; set; }

        [Required]
        public string Country { get; set; }


    }
}
