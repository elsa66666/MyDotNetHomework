using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework4_2
{
    public partial class OrderCell : UserControl
    {
        public OrderCell(int orderID, string usname, double totalPrice, List<OrderDetails> orderDetailArray)
        {
            InitializeComponent();
            OrderIDLabel.Text = orderID.ToString();
            UsernameLabel.Text = usname;
            totalPriceLabel.Text = totalPrice.ToString();
            if (orderDetailArray != null)
            {
                for (int i = 0; i < orderDetailArray.Count(); i++)
                {
                    DataGridViewRow dr = new DataGridViewRow();
                    dr.CreateCells(orderDetailGridView);
                    dr.Cells[0].Value = i;
                    dr.Cells[1].Value = orderDetailArray[i].ItemName;
                    dr.Cells[2].Value = orderDetailArray[i].AmountBought;
                    dr.Cells[3].Value = orderDetailArray[i].PerPrice;
                    orderDetailGridView.Rows.Add(dr);
                }
            }   
        }

        private int orderID;
        public int OrderID 
        {
            get { return orderID; }
            set { orderID = value; }
        }
        private string usname;
        public string Usname 
        {
            get { return usname; }
            set { usname = value; }
        }
        private double totalPrice;
        public double TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }
    
        private List<OrderDetails> orderDetailArray;
        public List<OrderDetails> OrderDetailArray 
        {
            get { return orderDetailArray; }
            set {orderDetailArray = value; }
        }

    }
}
