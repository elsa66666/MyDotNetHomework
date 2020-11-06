namespace OrderManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Order
    {
        public Order()
        {
            orderdetails = new HashSet<orderdetail>();
        }

        [Key]
        public int OrderID { get; set; }

        [Required]
        public float Total_Price { get; set; }

        [StringLength(45)]
        [Required]
        public string Supplier { get; set; }

        [StringLength(45)]
        [Required]
        public string Buyer { get; set; }

        [StringLength(45)]
        [Required]
        public string Create_Time { get; set; }

        public virtual ICollection<OrderDetail> orderdetails { get; set; }

        public override bool Equals(object obj) {
            return obj is Order orderlist &&
                   OrderID == orderlist.OrderID &&
                   Supplier == orderlist.Supplier &&
                   Buyer == orderlist.Buyer;
        }
    }
}
