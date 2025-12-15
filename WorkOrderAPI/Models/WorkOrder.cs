using System.ComponentModel.DataAnnotations;

namespace WorkOrderAPI.Models
{
    public class WorkOrder
    {
        [Key]
        public int Id { get; set; }

        public virtual Customer Customer { get; set; }

        [Required]        
        public DateOnly DateOpen { get; set; }
        
        [Required]        
        public DateOnly DateClose { get; set; }

        public string Description { get; set; }

    }
}
