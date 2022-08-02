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
    }
}
