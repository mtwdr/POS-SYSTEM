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
    public partial class Users : Form
    {
        String stdDetails = "{0, -20}{1, -20}{2, -20}{3, -20}{4, -20}{5, -20}";

        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            usersListBox.Items.Add(String.Format(stdDetails, "ID", "Last Name", "First Name", "Password", "Employee No", "User Type"));
        }

        private void createUserBtn_Click(object sender, EventArgs e)
        {
            CreateUser createUser = new CreateUser();
            createUser.ShowDialog();
        }

        private void searchUserBtn_Click(object sender, EventArgs e)
        {
            SearchUser searchUser = new SearchUser();
            searchUser.ShowDialog();
        }

        private void updateUserBtn_Click(object sender, EventArgs e)
        {
            UpdateUser updateUser = new UpdateUser();
            updateUser.ShowDialog();
        }
        
        private void deleteUserBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
