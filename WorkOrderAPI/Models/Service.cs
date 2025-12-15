using System.ComponentModel.DataAnnotations;

namespace WorkOrderAPI.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }

        public virtual Technician Technician { get; set; }

        public int TechnicianId { get; set; }
    }
}
