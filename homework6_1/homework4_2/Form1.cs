using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HomeBtStrip.Visible = true;
            AddOrderStrip.Visible = false;
            DeleteOrderStrip.Visible = false;
            SearchStrip.Visible = false;
            ShowUC uc1 = new ShowUC();
            addUserControl(uc1);
        }
        private void addUserControl(UserControl uc)
        {
            mainScreenPanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            mainScreenPanel.Controls.Add(uc);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            HomeBtStrip.Visible = false;
            AddOrderStrip.Visible = false;
            DeleteOrderStrip.Visible = false;
            SearchStrip.Visible = true;
            SearchResult searchResult = new SearchResult();
            addUserControl(searchResult); 
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            HomeBtStrip.Visible = true;
            AddOrderStrip.Visible = false;
            DeleteOrderStrip.Visible = false;
            SearchStrip.Visible = false;
            ShowUC uc1  = new ShowUC();
            addUserControl(uc1);
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            HomeBtStrip.Visible = false;
            AddOrderStrip.Visible = true;
            DeleteOrderStrip.Visible = false;
            SearchStrip.Visible = false;
            AddOrder addOrder = new AddOrder();
            addUserControl(addOrder);
        }

        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            HomeBtStrip.Visible =false;
            AddOrderStrip.Visible = false;
            DeleteOrderStrip.Visible = true;
            SearchStrip.Visible = false;
            DeleteItem deleteItem = new DeleteItem();
            addUserControl(deleteItem);
        }
    }
}
