using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace POS_System
{
    public partial class Login : Form
    {
        

        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] //allows user to move the window arround. 
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void close_Btn_Click(object sender, EventArgs e) //closes the application 
        {
            Application.Exit();
        }

        private void login_Btn_Click(object sender, EventArgs e)
        {
            string server = "localhost"; //database credentials
            string database = "pos_system";
            string username = "root";
            string password = "";
            string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(constring); //mysql connection
            conn.Open(); //opening the connection

            string query = "select * from users where id='" + username_Input.Text + "' and password='" + password_Input.Text + "'"; //query
            MySqlCommand cmd = new MySqlCommand(query, conn); //command with the query and the connection

            MySqlDataReader dr = cmd.ExecuteReader(); //fetching information

            if (dr.Read()) //if dr can be read, meaning if it fetched any results from the db
            {
                conn.Close(); //closes connection
            
                Dashboard.user = username_Input.Text; //setting the public user variable to whoever successfully logged in.

                this.Hide(); //closes this form
                Dashboard dashboard = new Dashboard(); //opens dashboard form.
                dashboard.ShowDialog();


            }
            else //if no results are fetched, we tell the user the why.
            {
                MessageBox.Show("Please enter valid credentials"); 
            }
 
        }

        private void Login_MouseDown(object sender, MouseEventArgs e) //allows user to move the window arround depending on where they are pressing. 
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e) //allows user to move the window arround depending on where they are pressing.
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e) //allows user to move the window arround depending on where they are pressing.
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void languageSelect_SelectedIndexChanged(object sender, EventArgs e) //language selector method
        {
            switch (languageSelect.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US"); //changes the language of the login form to english.
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr-CA"); //changes the language of the login form to french.
                    break;
            }

            this.Controls.Clear(); //clears the control.
            InitializeComponent(); //refreshes the login form. 
        }
    }
}
