namespace OrderManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class OrderDetail
    {
        [Key]
        public int detailID { get; set; }

        public int OrderID { get; set; }

        [Required]
        [StringLength(45)]
        public string Supllier { get; set; }

        [Required]
        [StringLength(45)]
        public string Buyer { get; set; }

        [Required]
        [StringLength(45)]
        public string ObjectName { get; set; }

        [Required]
        public int Number { get; set; }

        public float UnitPrice { get; set; }

        public float TotalPrice { get; set; }

        [StringLength(45)]
        public string CreateTime { get; set; }

        public virtual Order order { get; set; }
    }
}