using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
namespace homework4_2
{
    public partial class DeleteItem : UserControl
    {
        public List<Order> allOrders = new List<Order>();
        string conString = "datasource=localhost;username=root;" +
                "password=111;database=order_sql;charset=utf8";
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
            int value = Convert.ToInt32(IDbox.Value);
            allOrders = os1.removeOrder(allOrders, value);
            os1.Export(allOrders);
            MessageBox.Show("The order with id: "+ value.ToString() + " is deleted.");

            //在orderdetail中删除一行
            MySqlConnection connection = new MySqlConnection(conString);
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                using (connection)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM `order` WHERE ID="+value.ToString();
                    cmd.ExecuteNonQuery();
                }
            }
            connection.Close();
        }
    }
}
