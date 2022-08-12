using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System.Forms
{
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
            StyleDataGridView();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            string server = "localhost"; //same db logic 
            string database = "pos_system";
            string username = "root";
            string password = "";
            string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();

            string query = "select * from orders";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt); //populates the data grid view
            ordersView.DataSource = dt;

            StyleDataGridView();
        }

        void StyleDataGridView() //styling the datagridview
        {
            ordersView.BorderStyle = BorderStyle.None;
            ordersView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            ordersView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 32, 79);
            ordersView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            ordersView.BackgroundColor = Color.FromArgb(30, 30, 30);
            ordersView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            ordersView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ordersView.EnableHeadersVisualStyles = false;
            ordersView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ordersView.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10);
            ordersView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            ordersView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
