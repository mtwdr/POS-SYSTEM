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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "pos_system";
            string username = "root";
            string password = "";
            string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();

            string query = "select * from users where ID = '" + Dashboard.user + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                label2.Text = dr["FirstName"].ToString();
            }

            clock.Text = DateTime.Now.ToString("T");
            clockTimer.Start();  
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            clock.Text = DateTime.Now.ToString("T");
        }
    }
}
