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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void close_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Btn_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "pos_system";
            string username = "root";
            string password = "";
            string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();

            string query = "select * from users where id='" + username_Input.Text + "' and password='" + password_Input.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                conn.Close();
            
                Dashboard.user = username_Input.Text;

                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.ShowDialog();


            }
            else
            {
                MessageBox.Show("Please enter valid credentials");
            }
 
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void languageSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (languageSelect.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr-CA");
                    break;
            }

            this.Controls.Clear();
            InitializeComponent();
        }
    }
}
