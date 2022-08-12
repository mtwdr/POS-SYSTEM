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
    public partial class SearchUser : Form
    {
        public SearchUser()
        {
            InitializeComponent();
            searchInput.Controls.RemoveAt(0); //removes arrows 
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the application
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

            string query = "select * from users where ID = '" + searchInput.Value.ToString() + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read()) //same search logic
            {
                MessageBox.Show("ID: " + searchInput.Value.ToString() + "\nLast Name: "+  dr["lname"].ToString() + "\nFirst Name:" + dr["fname"].ToString() + "\nPassword: " + dr["password"].ToString() + "\nUser Type: " + dr["usertype"].ToString());
            } else
            {
                MessageBox.Show("User Not Found");
            }
        }
    }
}
