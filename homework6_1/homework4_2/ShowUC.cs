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
using MySql.Data.MySqlClient;

namespace homework4_2
{
    public partial class ShowUC : UserControl
    {
        public List<Order> allOrders;
        public string conString = "datasource=localhost;username=root;" +
                "password=111;database=order_sql;charset=utf8";
        public ShowUC()
        {
            InitializeComponent();
            Query();
            showAllOds();
        }
        private MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(conString);
            connection.Open();
            return connection;
        }

        private void Query()
        {
            using (MySqlConnection conn = GetConnection())
            {
                string stm = "SELECT * FROM order";
                using (MySqlCommand cmd = new MySqlCommand(stm, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {//逐行读取
                            Order od1 = new Order();
                            od1.id = reader.GetInt32(1);
                            od1.customerName = reader.GetString(2);
                            od1.totalPrice = (double)reader.GetDecimal(3);
                            
                            List<OrderDetails> odtArray = new List<OrderDetails>();
                            string st1 = "SELECT * FROM orderdetail WHERE OrderID="+od1.id.ToString();
                            //商品详情
                            using (MySqlCommand cmd1 = new MySqlCommand(st1, conn))
                            {
                                using (MySqlDataReader reader1 = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        OrderDetails odt = new OrderDetails();
                                        odt.ItemName = reader1.GetString(3);
                                        odt.AmountBought = reader1.GetInt32(4);
                                        odt.PerPrice = (double)reader1.GetDecimal(5);
                                        odtArray.Add(odt);
                                    }
                                }
                            }
                            od1.OrderItems = odtArray;
                        }
                    }
                }
            }
        }

        public void showAllOds()
        {
            for(int i = 0; i < allOrders.Count(); i++)
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
    }
}
