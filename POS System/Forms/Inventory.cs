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
    public partial class Inventory : Form
    {
        public static string selectedsku = "";

        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "pos_system";
            string username = "root";
            string password = "";
            string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();

            string query = "select * from inventory";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            inventoryView.DataSource = dt;
        }

        private void createProductBtn_Click(object sender, EventArgs e)
        {
            CreateProduct createProduct = new CreateProduct();
            createProduct.ShowDialog();
        }

        private void searchProductBtn_Click(object sender, EventArgs e)
        {
            SearchProduct searchProduct = new SearchProduct();
            searchProduct.ShowDialog();
        }

        private void updateProductBtn_Click(object sender, EventArgs e)
        {
            if (inventoryView.SelectedCells[0].ColumnIndex.Equals(0))
            {
                selectedsku = inventoryView.SelectedCells[0].Value.ToString();

                UpdateProduct updateProduct = new UpdateProduct();
                updateProduct.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select the product sku.");
            }
        }

        private void deleteProductBtn_Click(object sender, EventArgs e)
        {
            if (inventoryView.SelectedCells[0].ColumnIndex.Equals(0))
            {
                string server = "localhost";
                string database = "pos_system";
                string username = "root";
                string password = "";
                string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

                MySqlConnection conn = new MySqlConnection(constring);
                conn.Open();

                string query = "delete from inventory where Sku=@SKU";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    cmd.Parameters.AddWithValue("@SKU", inventoryView.SelectedCells[0].Value.ToString());
                    cmd.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show("Successfully Deleted");

                }
            }
            else
            {
                MessageBox.Show("Please select the product sku.");
            }
        }
    }
}
