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
    public partial class SearchResult : UserControl
    {
        public List<Order> allOrders;
        public SearchResult()
        {
            InitializeComponent();
            SearchByComboBox.SelectedIndex = 1;
        }

        public void showAllOds()
        {
            for (int i = 0; i < allOrders.Count(); i++)
            {
                OrderCell orderCell = new OrderCell(allOrders[i].id, allOrders[i].customerName, allOrders[i].totalPrice, allOrders[i].OrderItems);

                orderCell.Width = 340;
                orderCell.Height = 200;
                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                {
                    flowLayoutPanel1.Controls.Add(orderCell);
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            int searchByIndex = SearchByComboBox.SelectedIndex;
            if (File.Exists("order.xml"))
            {
                OrderServices os1 = new OrderServices();
                allOrders = os1.Import();

                if (searchByIndex == 0)
                {
                    string uname = inputUsernameTextBox.Text;
                    allOrders = os1.searchOrderByName(uname, allOrders);
                }
                else
                {
                    int max = Convert.ToInt32(inputMaxPriceTextBox.Text);
                    int min = Convert.ToInt32(inputMinPriceTextBox.Text);
                    allOrders = os1.searchOrderByMoney(min, max, allOrders);
                }
            }
            showAllOds();
        }
    }
}
