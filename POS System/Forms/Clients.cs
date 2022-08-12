using MySql.Data.MySqlClient;
using System.Data;

namespace POS_System.Forms
{
    public partial class Clients : Form
    {
        public static string selectedtelephone = "";

        public Clients()
        {
            InitializeComponent();

        }

        private void Clients_Load(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "pos_system";
            string username = "root";
            string password = "";
            string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();

            string query = "select * from clients";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            clientsView.DataSource = dt;

            StyleDataGridView();
        }

        private void createClientBtn_Click(object sender, EventArgs e)
        {
            CreateClient createClient = new CreateClient();
            createClient.ShowDialog();
        }

        private void searchClientBtn_Click(object sender, EventArgs e)
        {
            SearchClient searchClient = new SearchClient();
            searchClient.ShowDialog();
        }

        private void updateClientBtn_Click(object sender, EventArgs e)
        {
            

            if (clientsView.SelectedCells[0].ColumnIndex.Equals(4))
            {
                selectedtelephone = clientsView.SelectedCells[0].Value.ToString();

                UpdateClient updateClient = new UpdateClient();
                updateClient.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select the telephone number.");
            }
        }

        private void deleteClientBtn_Click(object sender, EventArgs e)
        {
            if (clientsView.SelectedCells[0].ColumnIndex.Equals(4))
            {
                string server = "localhost";
                string database = "pos_system";
                string username = "root";
                string password = "";
                string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

                MySqlConnection conn = new MySqlConnection(constring);
                conn.Open();

                string query = "delete from clients where telephone=@TELEPHONE";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    cmd.Parameters.AddWithValue("@TELEPHONE", clientsView.SelectedCells[0].Value.ToString());
                    cmd.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show("Successfully Deleted");

                }
            }
            else
            {
                MessageBox.Show("Please select the telephone number.");
            }
        }

        void StyleDataGridView()
        {
            clientsView.BorderStyle = BorderStyle.None;
            clientsView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            clientsView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 32, 79);
            clientsView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            clientsView.BackgroundColor = Color.FromArgb(30, 30, 30);
            clientsView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            clientsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            clientsView.EnableHeadersVisualStyles = false;
            clientsView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            clientsView.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10);
            clientsView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            clientsView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
