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
    public partial class UpdateProduct : Form
    {
        public UpdateProduct()
        {
            InitializeComponent();
            priceInput.Controls.RemoveAt(0); //removes arrows 
            quantityInput.Controls.RemoveAt(0);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string server = "localhost"; //same db logic 
            string database = "pos_system";
            string username = "root";
            string password = "";
            string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();

            string query = "update Inventory set ProductName=@PRODUCTNAME, Price=@PRICE, Quantity=@QUANTITY, Location=@LOCATION where Sku = '" + Inventory.selectedsku + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@PRODUCTNAME", productnameInput.Text); //same updating logic 
            cmd.Parameters.AddWithValue("@PRICE", priceInput.Value.ToString());
            cmd.Parameters.AddWithValue("@QUANTITY", quantityInput.ToString());
            cmd.Parameters.AddWithValue("@LOCATION", locationInput.Text);


            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Successfully Updated");
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            skuInput.Text = Inventory.selectedsku;

            string server = "localhost";
            string database = "pos_system";
            string username = "root";
            string password = "";
            string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();

            string query = "select * from inventory where Sku = '" + Inventory.selectedsku + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                barcodeInput.Text = dr["Barcode"].ToString(); //same updating logic 
                productnameInput.Text = dr["ProductName"].ToString();
                priceInput.Value = Convert.ToDecimal(dr["Price"].ToString());
                quantityInput.Value = Convert.ToDecimal(dr["Quantity"].ToString());
                locationInput.Text = dr["Location"].ToString();
            }
        }
    }
}
