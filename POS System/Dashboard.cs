using System.Runtime.InteropServices;

namespace POS_System
{

    public partial class Dashboard : Form
    {
        private Form activeForm;

        public Dashboard()
        {
            InitializeComponent();

            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            activeForm = new Form();

            OpenChildForm(new Forms.Home(), activeForm);
            closeForm.Visible = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void cashBtn_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Cash Register";

            OpenChildForm(new Forms.CashRegister(), sender);
            closeForm.Visible = true;
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Orders";

            OpenChildForm(new Forms.Orders(), sender);
            closeForm.Visible = true;
        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Inventory";

            OpenChildForm(new Forms.Inventory(), sender);
            closeForm.Visible = true;
        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Users";

            OpenChildForm(new Forms.Users(), sender);
            closeForm.Visible = true;

        }

        private void clientsBtn_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Clients";

            OpenChildForm(new Forms.Clients(), sender);
            closeForm.Visible = true;
        }

        private void imgHome_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Home";

            OpenChildForm(new Forms.Home(), sender);
            closeForm.Visible = true;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            imgHome_Click(sender, e);
            closeForm.Visible = false;
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
    }
}
