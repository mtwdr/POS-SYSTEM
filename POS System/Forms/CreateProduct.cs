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
    public partial class CreateProduct : Form
    {
        public CreateProduct()
        {
            InitializeComponent();
            skuInput.Controls.RemoveAt(0);
            barcodeInput.Controls.RemoveAt(0);
            priceInput.Controls.RemoveAt(0);
            quantityInput.Controls.RemoveAt(0);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "pos_system";
            string username = "root";
            string password = "";
            string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();

            string query = "insert into inventory values (@SKU, @BARCODE, @PRODUCTNAME, @PRICE, @QUANTITY, @LOCATION)";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            if (productnameInput.ToString() == string.Empty || locationInput.Text == string.Empty || skuInput.Text == "" || barcodeInput.Text == ""
                || priceInput.Text == "" || quantityInput.Text == "")
            {
                MessageBox.Show("Make sure all the fields are filled.");

            }
            else
            {
                MySqlCommand cmd2 = new MySqlCommand("select * from inventory where Sku = '" + skuInput.Value.ToString() + "'", conn);
                MySqlDataReader dr2 = cmd2.ExecuteReader();

                if (dr2.Read())
                {
                    MessageBox.Show("Please enter a different SKU.");
                }
                else
                {
                    conn.Close();
                    conn.Open();

                    cmd.Parameters.AddWithValue("@SKU", skuInput.Value.ToString());
                    cmd.Parameters.AddWithValue("@BARCODE", barcodeInput.Value.ToString());
                    cmd.Parameters.AddWithValue("@PRODUCTNAME", productnameInput.Text);
                    cmd.Parameters.AddWithValue("@PRICE", priceInput.Value.ToString());
                    cmd.Parameters.AddWithValue("@QUANTITY", quantityInput.Value.ToString());
                    cmd.Parameters.AddWithValue("@LOCATION", locationInput.Text);

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Successfully added product.");
                }

                    
            }
        }
    }
}
