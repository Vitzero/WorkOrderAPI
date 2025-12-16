using System.ComponentModel.DataAnnotations;

namespace WorkOrderAPI.Models
{
    public class WorkOrder
    {
        [Key]
        public int Id { get; set; }

        public int CustomerID { get; set; }

        public virtual Customer Customer { get; set; }

        [Required]
        public DateOnly DateOpen { get; set; }

        [Required]
        public DateOnly DateClose { get; set; }

        public string Description { get; set; } = string.Empty;

        // Relaçoes M:M

        // ServiceOrderTechnician.cs

        public virtual ICollection<ServiceOrderTechnician> ServiceOrderTechnicians { get; set; }

        // ServiceOrderItem.cs

        public virtual ICollection<ServiceOrderItem> ServiceOrderItems { get; set; }


    }
}
