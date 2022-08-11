﻿using MySql.Data.MySqlClient;

namespace POS_System.Forms
{
    public partial class CreateClient : Form
    {

        public CreateClient()
        {
            InitializeComponent();
            telephoneInput.Controls.RemoveAt(0);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "pos_system";
            string username = "root";
            string password = "";
            string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();

            string query = "insert into clients values (@LNAME, @FNAME, @COMPANY, @ADDRESS, @TELEPHONENO, @EMAIL)";
            MySqlCommand cmd = new MySqlCommand(query, conn);  

            if (lastnameInput.ToString() == string.Empty || firstnameInput.Text == string.Empty || companyInput.Text == string.Empty
                || addressInput.Text == string.Empty || emailInput.Text == string.Empty || (telephoneInput.Value > 0000000001 && telephoneInput.Value < 100000000))
            {
                MessageBox.Show("Make sure all the fields are filled.");

            }
            else 
            {
                cmd.Parameters.AddWithValue("@LNAME", lastnameInput.Text);
                cmd.Parameters.AddWithValue("@FNAME", firstnameInput.Text);
                cmd.Parameters.AddWithValue("@COMPANY", companyInput.Text);
                cmd.Parameters.AddWithValue("@ADDRESS", addressInput.Text);
                cmd.Parameters.AddWithValue("@TELEPHONENO", telephoneInput.Value.ToString());
                cmd.Parameters.AddWithValue("@EMAIL", emailInput.Text);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Successfully created client.");
            }
        }
    }
}
