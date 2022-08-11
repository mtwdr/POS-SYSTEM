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
    public partial class SearchProduct : Form
    {
        public SearchProduct()
        {
            InitializeComponent();
            searchInput.Controls.RemoveAt(0);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "pos_system";
            string username = "root";
            string password = "";
            string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();

            string query = "select * from inventory where Sku = '" + searchInput.Value.ToString() + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Sku: " + searchInput.Value.ToString() + "\nBarcode: " + dr["Barcode"].ToString() + "\nProduct Name:" + dr["ProductName"].ToString() + "\nPrice: " + dr["Price"].ToString() + "\nQuantity: " + dr["Quantity"].ToString() + "\nLocation: " + dr["Location"].ToString());
            }
            else
            {
                MessageBox.Show("Product Not Found");
            }
        }
    }
}
