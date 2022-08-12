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
    public partial class UpdateUser : Form
    {
        public UpdateUser()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string server = "localhost"; //same db logic 
            string database = "pos_system";
            string username = "root";
            string password = "";
            string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();

            string query = "update Users set LastName=@LNAME, FirstName=@FNAME, Password=@PASSWORD where ID = '" + Users.selectedid + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn); //same updating logic 

            cmd.Parameters.AddWithValue("@LNAME", lastnameInput.Text);
            cmd.Parameters.AddWithValue("@FNAME", firstnameInput.Text);
            cmd.Parameters.AddWithValue("@PASSWORD", passwordInput.Text);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Successfully Updated");

        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            IDInput.Text = Users.selectedid;

            string server = "localhost";
            string database = "pos_system";
            string username = "root";
            string password = "";
            string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();

            string query = "select * from users where ID = '" + Users.selectedid + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                lastnameInput.Text = dr["LastName"].ToString(); //same updating logic 
                firstnameInput.Text = dr["FirstName"].ToString();
                passwordInput.Text = dr["Password"].ToString();
                usertypeInput.Text = dr["UserType"].ToString();
            }
        }
    }
}
