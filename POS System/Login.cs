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

namespace POS_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void close_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void username_Input_Click(object sender, EventArgs e)
        {
            username_Input.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            password_Input.BackColor = SystemColors.Control;
        }

        private void password_Input_Click(object sender, EventArgs e)
        {
            password_Input.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel3.BackColor = SystemColors.Control;
            username_Input.BackColor = SystemColors.Control;
        }

        private void login_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }
    }
}
