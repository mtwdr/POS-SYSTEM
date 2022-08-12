using System.Runtime.InteropServices;

namespace POS_System
{

    public partial class Dashboard : Form
    {
        private Form activeForm; //private variable for which form is the dashboard currently on.

        public static string user; //public variable to see what kind of user logged in. 

        public Dashboard()
        {
            InitializeComponent();

            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            if (Int32.Parse(user) >= 500) //MANAGER ACCESS 
            {
                //ACCESS TO EVERYTHING 
            }
            else if (Int32.Parse(user) >= 400 && Int32.Parse(user) <= 499) //CUSTOMER SERVICE ACCESS
            {
                usersBtn.Visible = false; //hiding the functionalities depending on the user. 
                clientsBtn.Visible = false;
            }
            else if (Int32.Parse(user) >= 300 && Int32.Parse(user) <= 399) //CASHIER ACCESS
            {
                usersBtn.Visible = false; //hiding the functionalities depending on the user.
                clientsBtn.Visible = false;
                ordersBtn.Visible = false;
            }
            else if (Int32.Parse(user) >= 200 && Int32.Parse(user) <= 299) //CLERK ACCESS
            {
                cashBtn.Visible = false; //hiding the functionalities depending on the user.
                usersBtn.Visible = false;
                clientsBtn.Visible = false;
                ordersBtn.Visible = false;
            }

            activeForm = new Form(); //new active form.

            OpenChildForm(new Forms.Home(), activeForm); //opens the home form by default.
            closeForm.Visible = false; //closing the previous form.


        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] //allows user to move the window arround. 
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void OpenChildForm(Form childForm, object btnSender) //method to change the active form. 
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

        private void cashBtn_Click(object sender, EventArgs e) //cash button onclick, opens the cash form, and closes the previous one. 
        {
            labelTitle.Text = "Cash Register";

            OpenChildForm(new Forms.CashRegister(), sender);
            closeForm.Visible = true;
        }

        private void orderBtn_Click(object sender, EventArgs e) //order button onclick, opens the order form, and closes the previous one. 
        {
            labelTitle.Text = "Orders";

            OpenChildForm(new Forms.Orders(), sender);
            closeForm.Visible = true;
        }

        private void inventoryBtn_Click(object sender, EventArgs e) //inventory button onclick, opens the inventory form, and closes the previous one. 
        {
            labelTitle.Text = "Inventory";

            OpenChildForm(new Forms.Inventory(), sender);
            closeForm.Visible = true;
        }

        private void usersBtn_Click(object sender, EventArgs e) //users button onclick, opens the user form, and closes the previous one.
        {
            labelTitle.Text = "Users";

            OpenChildForm(new Forms.Users(), sender);
            closeForm.Visible = true;

        }

        private void clientsBtn_Click(object sender, EventArgs e) //clients button onclick, opens the clients form, and closes the previous one.
        {
            labelTitle.Text = "Clients";

            OpenChildForm(new Forms.Clients(), sender);
            closeForm.Visible = true;
        }

        private void imgHome_Click(object sender, EventArgs e) //logo image button onclick, opens the home form, and closes the previous one.
        {
            labelTitle.Text = "Home";

            OpenChildForm(new Forms.Home(), sender);
            closeForm.Visible = true;
        }

        private void logoutBtn_Click(object sender, EventArgs e) //logout button, logs out the user and opens the login form. 
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void closeForm_Click(object sender, EventArgs e) //close button onclick, opens back the home form. 
        {
            imgHome_Click(sender, e);
            closeForm.Visible = false;
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e) //allows user to move the window around. 
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e) //closes the application
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e) //maximizes the application, WORKS BUT DISABLED BECAUSE OF SCALING ISSUE. 
        {
            //if (WindowState == FormWindowState.Normal)
                //this.WindowState = FormWindowState.Maximized;
            //else
                //this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e) //minimizes the application
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
