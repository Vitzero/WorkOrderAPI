using Microsoft.EntityFrameworkCore;
using WorkOrderAPI.Models;

namespace WorkOrderAPI.Data
{
    public class WorkOrderContext : DbContext
    {
        public WorkOrderContext(DbContextOptions<WorkOrderContext> opts) : base(opts) { 
            
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }


    }
}
