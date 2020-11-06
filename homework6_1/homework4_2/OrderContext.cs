using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace homework4_2
{
    public class OrderContext : DbContext
    {
        public OrderContext() : base("OrderDatabase")
        {
            Database.SetInitializer(
            new DropCreateDatabaseIfModelChanges<OrderContext>());
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderItems { get; set; }
        public DbSet<OrderServices> OrderServices { get; set; }
    }
}
