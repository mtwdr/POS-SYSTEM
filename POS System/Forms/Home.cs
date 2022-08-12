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
            string server = "localhost"; //same db logic
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
                label2.Text = dr["FirstName"].ToString(); //changes the welcome text to the first name of the logged in user. 
            }

            clock.Text = DateTime.Now.ToString("T");
            clockTimer.Start();  //starts the clock at the time of your computer.
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            clock.Text = DateTime.Now.ToString("T"); //sets clock 
        }
    }
}
