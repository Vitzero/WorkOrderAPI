using System.ComponentModel.DataAnnotations;

namespace WorkOrderAPI.Models
{
    public class ServiceOrderItem
    {
        [Key]
        public int Id { get; set; }

        public virtual WorkOrder WorkOrder { get; set; }

        public int WorkOrderId { get; set; }    

        public virtual ICollection<Service> Services { get; set; }
    }
}
