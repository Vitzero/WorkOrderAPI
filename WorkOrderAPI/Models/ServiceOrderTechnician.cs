using System.ComponentModel.DataAnnotations;

namespace WorkOrderAPI.Models
{
    public class ServiceOrderTechnician
    {
        [Key]
        public int Id { get; set; }

        public virtual Technician Technician { get; set; }

        public int TechnicianId { get; set; }

        public virtual ICollection<Technician> Technicians { get; set; }
    }
}
