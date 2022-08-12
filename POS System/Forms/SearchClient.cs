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
    public partial class SearchClient : Form
    {
        public SearchClient()
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
            string server = "localhost"; //same db logic 
            string database = "pos_system";
            string username = "root";
            string password = "";
            string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();

            string query = "select * from clients where Telephone = '" + searchInput.Value.ToString() + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read()) //if result found shows it in a textbox.
            {
                MessageBox.Show("Telephone: " + searchInput.Value.ToString() + "\nLast Name: " + dr["LastName"].ToString() + "\nFirst Name:" + dr["FirstName"].ToString() + "\nCompany: " + dr["Company"].ToString() + "\nAddress: " + dr["Address"].ToString() + "\nEmail: " + dr["Email"].ToString());
            }
            else
            {
                MessageBox.Show("Client Not Found");
            }
        }

      
    }
}
