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
            string server = "localhost"; //same db logic 
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

            da.Fill(dt); //populates the data grid view
            inventoryView.DataSource = dt;

            StyleDataGridView();
        }

        private void createProductBtn_Click(object sender, EventArgs e) //opens appropriate form
        {
            CreateProduct createProduct = new CreateProduct();
            createProduct.ShowDialog();
        }

        private void searchProductBtn_Click(object sender, EventArgs e) //opens appropriate form
        {
            SearchProduct searchProduct = new SearchProduct();
            searchProduct.ShowDialog();
        }

        private void updateProductBtn_Click(object sender, EventArgs e)
        {
            if (inventoryView.SelectedCells[0].ColumnIndex.Equals(0)) //checks if the sku is populated 
            {
                selectedsku = inventoryView.SelectedCells[0].Value.ToString(); //instantiates the global value to the selected sku

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
            if (inventoryView.SelectedCells[0].ColumnIndex.Equals(0)) //checks if sky is selected 
            {
                string server = "localhost"; //same db logic 
                string database = "pos_system";
                string username = "root";
                string password = "";
                string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

                MySqlConnection conn = new MySqlConnection(constring);
                conn.Open();

                string query = "delete from inventory where Sku=@SKU";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) //dialog box to confirm the user
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

        void StyleDataGridView() //styling the data grid view
        {
            inventoryView.BorderStyle = BorderStyle.None;
            inventoryView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            inventoryView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 32, 79);
            inventoryView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            inventoryView.BackgroundColor = Color.FromArgb(30, 30, 30);
            inventoryView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            inventoryView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            inventoryView.EnableHeadersVisualStyles = false;
            inventoryView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            inventoryView.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10);
            inventoryView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            inventoryView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
