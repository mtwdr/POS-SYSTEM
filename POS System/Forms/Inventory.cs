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
        String stdDetails = "{0, -20}{1, -20}{2, -20}{3, -20}{4, -20}{5, -20}";

        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            inventoryListBox.Items.Add(String.Format(stdDetails, "SKU", "Barcode", "Product Name", "Price", "Quantity", "Location"));
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
            UpdateProduct updateProduct = new UpdateProduct();
            updateProduct.ShowDialog();
        }

        private void deleteProductBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
