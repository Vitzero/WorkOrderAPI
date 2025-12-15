using System.ComponentModel.DataAnnotations;

namespace WorkOrderAPI.Models
{
    public class Technician
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Specialty { get; set; }

        public string Email { get; set; }
        
        public string Phone {  get; set; }
      
    }
}
