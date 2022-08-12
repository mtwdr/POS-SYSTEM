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
    public partial class Users : Form
    {

        public static string selectedid = "";

        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            string server = "localhost"; //SAME DB LOGIC 
            string database = "pos_system";
            string username = "root";
            string password = "";
            string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();

            string query = "select * from users";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt); //POPULATES DATA GRID VIEW
            usersView.DataSource = dt;

            StyleDataGridView();
        }

        private void createUserBtn_Click(object sender, EventArgs e) //opens appropriate forms 
        {
            CreateUser createUser = new CreateUser();
            createUser.ShowDialog();
        }

        private void searchUserBtn_Click(object sender, EventArgs e) //opens appropriate forms 
        {
            SearchUser searchUser = new SearchUser();
            searchUser.ShowDialog();
        }

        private void updateUserBtn_Click(object sender, EventArgs e) //same update logic as others 
        {
            if (usersView.SelectedCells[0].ColumnIndex.Equals(0))
            {
                selectedid = usersView.SelectedCells[0].Value.ToString();

                UpdateUser updateUser = new UpdateUser();
                updateUser.ShowDialog();
            } else
            {
                MessageBox.Show("Please select the user ID");
            }

        }
        
        private void deleteUserBtn_Click(object sender, EventArgs e) //same deleting logic as others
        {
            if (usersView.SelectedCells[0].ColumnIndex.Equals(0))
            {
                string server = "localhost";
                string database = "pos_system";
                string username = "root";
                string password = "";
                string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

                MySqlConnection conn = new MySqlConnection(constring);
                conn.Open();

                string query = "delete from users where ID=@ID";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    cmd.Parameters.AddWithValue("@ID", usersView.SelectedCells[0].Value.ToString());
                    cmd.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show("Successfully Deleted");

                }
            }
            else
            {
                MessageBox.Show("Please select the user ID");
            }

        }

        void StyleDataGridView() //styling the datagridview
        {
            usersView.BorderStyle = BorderStyle.None;
            usersView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            usersView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 32, 79);
            usersView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            usersView.BackgroundColor = Color.FromArgb(30, 30, 30);
            usersView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            usersView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            usersView.EnableHeadersVisualStyles = false;
            usersView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            usersView.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10);
            usersView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            usersView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
