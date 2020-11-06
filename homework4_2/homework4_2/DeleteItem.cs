using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
namespace homework4_2
{
    public partial class DeleteItem : UserControl
    {
        public List<Order> allOrders = new List<Order>();
        public DeleteItem()
        {
            InitializeComponent();
            if (File.Exists("order.xml"))
            {
                OrderServices os1 = new OrderServices();
                allOrders = os1.Import();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            OrderServices os1 = new OrderServices();
            allOrders = os1.removeOrder(allOrders, Convert.ToInt32(IDbox.Value));
            os1.Export(allOrders);
        }
    }
}
