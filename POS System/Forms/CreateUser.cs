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
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
            IDInput.Controls.RemoveAt(0); //removing arrows
            usertypeInput.SelectedIndex = 0; //setting default value 
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close(); //closes application
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            string server = "localhost"; //same db logic 
            string database = "pos_system";
            string username = "root";
            string password = "";
            string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();

            string query = "insert into users values (@ID, @LNAME, @FNAME, @PASSWORD, @USERTYPE)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            
            

            if (IDInput.ToString() == string.Empty || lastnameInput.Text == string.Empty || firstnameInput.Text == string.Empty
                || passwordInput.Text == string.Empty) //checking if fields are empty
            {
                MessageBox.Show("Make sure all the fields are filled.");

            } else 
            {
                //checks wat user type they chose and makes them choose an appropriate user id,
                //for example, if they selected manager they need a user id between 500 and 599
                if (usertypeInput.SelectedIndex == 0 && (IDInput.Value > 499 && IDInput.Value < 600)) //MANAGER
                {
                    //checks if the user id already exists. 
                    MySqlCommand cmd2 = new MySqlCommand("select * from users where id = '" + IDInput.Value.ToString() + "'", conn);
                    MySqlDataReader dr2 = cmd2.ExecuteReader();

                    if (dr2.Read())
                    {
                        MessageBox.Show("Please enter a different ID.");
                    } else
                    {
                        conn.Close();
                        conn.Open();

                        cmd.Parameters.AddWithValue("@ID", IDInput.Value.ToString());
                        cmd.Parameters.AddWithValue("@LNAME", lastnameInput.Text);
                        cmd.Parameters.AddWithValue("@FNAME", firstnameInput.Text);
                        cmd.Parameters.AddWithValue("@PASSWORD", passwordInput.Text);
                        cmd.Parameters.AddWithValue("@USERTYPE", usertypeInput.SelectedItem.ToString());

                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Successfully created user.");
                    }


                } else if (usertypeInput.SelectedIndex == 1 && (IDInput.Value > 399 && IDInput.Value < 500)) //CUSTOMER SERVICE
                {
                    MySqlCommand cmd2 = new MySqlCommand("select * from users where id = '" + IDInput.Value.ToString() + "'", conn);
                    MySqlDataReader dr2 = cmd2.ExecuteReader();

                    if (dr2.Read())
                    {
                        MessageBox.Show("Please enter a different ID.");
                    }
                    else
                    {
                        conn.Close();
                        conn.Open();

                        cmd.Parameters.AddWithValue("@ID", IDInput.Value.ToString());
                        cmd.Parameters.AddWithValue("@LNAME", lastnameInput.Text);
                        cmd.Parameters.AddWithValue("@FNAME", firstnameInput.Text);
                        cmd.Parameters.AddWithValue("@PASSWORD", passwordInput.Text);
                        cmd.Parameters.AddWithValue("@USERTYPE", usertypeInput.SelectedItem.ToString());

                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Successfully created user.");
                    }

                } else if (usertypeInput.SelectedIndex == 2 && (IDInput.Value > 299 && IDInput.Value < 400)) //CASHIER 
                {
                    MySqlCommand cmd2 = new MySqlCommand("select * from users where id = '" + IDInput.Value.ToString() + "'", conn);
                    MySqlDataReader dr2 = cmd2.ExecuteReader();

                    if (dr2.Read())
                    {
                        MessageBox.Show("Please enter a different ID.");
                    }
                    else
                    {
                        conn.Close();
                        conn.Open();

                        cmd.Parameters.AddWithValue("@ID", IDInput.Value.ToString());
                        cmd.Parameters.AddWithValue("@LNAME", lastnameInput.Text);
                        cmd.Parameters.AddWithValue("@FNAME", firstnameInput.Text);
                        cmd.Parameters.AddWithValue("@PASSWORD", passwordInput.Text);
                        cmd.Parameters.AddWithValue("@USERTYPE", usertypeInput.SelectedItem.ToString());

                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Successfully created user.");
                    }
                } else if (usertypeInput.SelectedIndex == 3 && (IDInput.Value > 199 && IDInput.Value < 300)) //CLERK 
                {
                    MySqlCommand cmd2 = new MySqlCommand("select * from users where id = '" + IDInput.Value.ToString() + "'", conn);
                    MySqlDataReader dr2 = cmd2.ExecuteReader();

                    if (dr2.Read())
                    {
                        MessageBox.Show("Please enter a different ID.");
                    }
                    else
                    {
                        conn.Close();
                        conn.Open();

                        cmd.Parameters.AddWithValue("@ID", IDInput.Value.ToString());
                        cmd.Parameters.AddWithValue("@LNAME", lastnameInput.Text);
                        cmd.Parameters.AddWithValue("@FNAME", firstnameInput.Text);
                        cmd.Parameters.AddWithValue("@PASSWORD", passwordInput.Text);
                        cmd.Parameters.AddWithValue("@USERTYPE", usertypeInput.SelectedItem.ToString());

                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Successfully created user.");
                    }
                } else
                {
                    MessageBox.Show("Please enter a valid ID per user type.");
                }

            }

        }
    }
}
