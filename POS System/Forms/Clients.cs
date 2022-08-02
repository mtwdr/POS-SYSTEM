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
    public partial class Clients : Form
    {
        String stdDetails = "{0, -20}{1, -20}{2, -20}{3, -20}{4, -20}{5, -20}";

        public Clients()
        {
            InitializeComponent();

        }

        private void Clients_Load(object sender, EventArgs e)
        {
            clientListBox.Items.Add(String.Format(stdDetails, "Last Name", "First Name", "Company", "Address", "Telephone No", "Email"));
        }

        private void createClientBtn_Click(object sender, EventArgs e)
        {
            CreateClient createClient = new CreateClient();
            createClient.ShowDialog();
        }

        private void searchClientBtn_Click(object sender, EventArgs e)
        {
            SearchClient searchClient = new SearchClient();
            searchClient.ShowDialog();
        }

        private void updateClientBtn_Click(object sender, EventArgs e)
        {
            UpdateClient updateClient = new UpdateClient();
            updateClient.ShowDialog();
        }

        private void deleteClientBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
