using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace homework4_2
{
    public partial class AddOrder : UserControl
    {
        public List<Order> allOrders = new List<Order>();
        Order od1 = new Order();
        int detailSum = 0;
        public AddOrder()
        {
            InitializeComponent();
            if (File.Exists("order.xml"))
            {
                OrderServices os1 = new OrderServices();
                allOrders = os1.Import();
            }    
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            //更新new order
            od1.addItemToOrder(LabelTextBox.Text, Convert.ToInt32(amountNumericUpDown.Value), Convert.ToDouble(unitPriceTB.Text));
            detailSum++;
            //更新表格
            DataGridViewRow dr = new DataGridViewRow();
            dr.CreateCells(AddOrderDtGridView);
            dr.Cells[0].Value = detailSum;
            dr.Cells[1].Value = LabelTextBox.Text;
            dr.Cells[2].Value = Convert.ToInt32(amountNumericUpDown.Value);
            dr.Cells[3].Value = Convert.ToDouble(unitPriceTB.Text);
            AddOrderDtGridView.Rows.Add(dr);

            //清空textbox
            LabelTextBox.Text = null;
            amountNumericUpDown.Value = 0;
            unitPriceTB.Text = null;
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            //完善new order信息
            od1.id = allOrders.Count() + 1;
            od1.customerName = userNameTB.Text;
            od1.getAllPrice();

            //将new order加入orders
            allOrders.Add(od1);

            //更新数据库
            OrderServices os1 = new OrderServices();
            os1.Export(allOrders);
        }
    }
}
