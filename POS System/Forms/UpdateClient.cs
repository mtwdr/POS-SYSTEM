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
    public partial class UpdateClient : Form
    {
        public UpdateClient()
        {
            InitializeComponent();
            telephoneInput.Controls.RemoveAt(0);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "pos_system";
            string username = "root";
            string password = "";
            string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();

            string query = "update Clients set LastName=@LNAME, FirstName=@FNAME, Company=@COMPANY, Address=@Address, Telephone=@TELEPHONE, Email=@EMAIL where Telephone = '" + Clients.selectedtelephone + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@LNAME", lastnameInput.Text);
            cmd.Parameters.AddWithValue("@FNAME", firstnameInput.Text);
            cmd.Parameters.AddWithValue("@COMPANY", companyInput.Text);
            cmd.Parameters.AddWithValue("@ADDRESS", addressInput.Text);
            cmd.Parameters.AddWithValue("@TELEPHONE", telephoneInput.Value.ToString());
            cmd.Parameters.AddWithValue("@EMAIL", emailInput.Text);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Successfully Updated");
        }

        private void UpdateClient_Load(object sender, EventArgs e)
        {
            telephoneInput.Value = Convert.ToDecimal(Clients.selectedtelephone);

            string server = "localhost";
            string database = "pos_system";
            string username = "root";
            string password = "";
            string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();

            string query = "select * from clients where Telephone = '" + Clients.selectedtelephone + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                lastnameInput.Text = dr["LastName"].ToString();
                firstnameInput.Text = dr["FirstName"].ToString();
                addressInput.Text = dr["Address"].ToString();
                companyInput.Text = dr["Company"].ToString();
                emailInput.Text = dr["Email"].ToString();
            }
        }
    }
}
