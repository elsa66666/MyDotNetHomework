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
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace homework4_2
{
    public partial class AddOrder : UserControl
    {
        public List<Order> allOrders = new List<Order>();
        Order od1 = new Order();
        int detailSum = 0;
        bool ifFinished = false;

        string conString = "datasource=localhost;username=root;" +
                "password=111;database=order_sql;charset=utf8";
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
            int order_id = allOrders[allOrders.Count() - 1].id + 1;
            int item_id = detailSum;
            string item_name = LabelTextBox.Text;
            int amount_bought = Convert.ToInt32(amountNumericUpDown.Value);
            double per_price = Convert.ToDouble(unitPriceTB.Text);

            //更新new order
            od1.addItemToOrder(order_id, item_id, item_name, amount_bought, per_price);
            detailSum++;
            //更新表格
            DataGridViewRow dr = new DataGridViewRow();
            dr.CreateCells(AddOrderDtGridView);
            dr.Cells[0].Value = detailSum;
            dr.Cells[1].Value = LabelTextBox.Text;
            dr.Cells[2].Value = Convert.ToInt32(amountNumericUpDown.Value);
            dr.Cells[3].Value = Convert.ToDouble(unitPriceTB.Text);
            AddOrderDtGridView.Rows.Add(dr);

            //在orderdetail中插入一行
            /*
            MySqlConnection connection = new MySqlConnection(conString);
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                using (connection)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO orderdetail(orderID,itemID,itemName,amountBought,perPrice) VALUES  (@orderID, @itemID, @itemName, @amountBought, @perPrice)";
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@orderID", allOrders[allOrders.Count() - 1].id + 1);
                    cmd.Parameters.AddWithValue("@itemID", detailSum);
                    cmd.Parameters.AddWithValue("@itemName", LabelTextBox.Text);
                    cmd.Parameters.AddWithValue("@amountBought", Convert.ToInt32(amountNumericUpDown.Value));
                    cmd.Parameters.AddWithValue("@perPrice", Convert.ToDouble(unitPriceTB.Text));

                    cmd.ExecuteNonQuery();
                }
            }
            connection.Close();
            */
            try
            {
                using (var db = new OrderContext())
                {
                    
                    OrderDetails item = new OrderDetails(order_id,item_id,item_name,amount_bought,per_price);
                    db.OrderItems.Add(item);
                    db.SaveChanges();
                }
            }
            catch
            {
                //TODO 需要更加错误类型返回不同错误信息
                throw new ApplicationException($"添加错误!");
            }

            //清空textbox
            LabelTextBox.Text = null;
            amountNumericUpDown.Value = 0;
            unitPriceTB.Text = null;
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            if (ifFinished == false)
            {
                ifFinished = true;
                //完善new order信息
                od1.id = allOrders[allOrders.Count() - 1].id + 1;
                od1.customerName = userNameTB.Text;
                od1.getAllPrice();

                //将new order加入orders
                 allOrders.Add(od1);

                //更新xml和数据库
                OrderServices os1 = new OrderServices();
                os1.Export(allOrders);

                //在order中插入一行
                MySqlConnection connection = new MySqlConnection(conString);
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    using (connection)
                    {
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandText = "INSERT INTO `order`(ID,userName,totalPrice) VALUES  (@ID, @userName, @totalPrice)";

                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("@ ID", allOrders[allOrders.Count() - 1].id + 1);
                        cmd.Parameters.AddWithValue("@userName", userNameTB.Text);
                        cmd.Parameters.AddWithValue("@totalPrice", od1.totalPrice);

                        cmd.ExecuteNonQuery();
                    }
                }
                connection.Close();
            }
            else  //避免重复添加
            {
                MessageBox.Show("The order has already added.");
            }
        }
    }
}
