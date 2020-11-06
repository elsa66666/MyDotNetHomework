namespace OrderManager.Models
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options)
            : base(options)
        {
        }

        public virtual DbSet<OrderDetail> orderdetails { get; set; }
        public virtual DbSet<Order> orderlists { get; set; }

    }
}
