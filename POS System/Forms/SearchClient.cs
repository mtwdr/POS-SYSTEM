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
    public partial class SearchClient : Form
    {
        public SearchClient()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

        }

        private void searchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            IList<string> lstString = new List<string>();
            lstString.Add("Last Name");
            lstString.Add("First Name");
            lstString.Add("Company");
            lstString.Add("Telephone");
            lstString.Add("Email");
            label2.Text = lstString[searchBy.SelectedIndex];
        }
    }
}
