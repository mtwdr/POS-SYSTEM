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
    public partial class Orders : Form
    {
        private decimal subtotal; //private variables for subtotal
        private decimal total; //private variables for total

        public Orders()
        {
            InitializeComponent();
            StyleDataGridView();

            orderType.SelectedIndex = 0;

            quantityChange.Visible = false;
            deleteItem.Visible = false;
            completeOrder.Visible = false; 
            nextItemBtn.Visible = false;

            searchInput.Controls.RemoveAt(0);
            quantityInput.Controls.RemoveAt(0);
            productInput.Controls.RemoveAt(0);
        }

        private void quantityChange_Click(object sender, EventArgs e)
        {
            if (orderView.SelectedCells[0].ColumnIndex.Equals(0)) //Check if user is selecting the product sku column.
            {

                //SAME LOGIC^^
                decimal oldtotal = Decimal.Parse(orderView.Rows[orderView.CurrentCell.RowIndex].Cells[3].Value.ToString()) * Decimal.Parse(orderView.Rows[orderView.CurrentCell.RowIndex].Cells[2].Value.ToString());
                orderView.Rows[orderView.CurrentCell.RowIndex].Cells[2].Value = quantityInput.Value;

                subtotal += (Decimal.Parse(orderView.Rows[orderView.CurrentCell.RowIndex].Cells[3].Value.ToString()) * Decimal.Parse(orderView.Rows[orderView.CurrentCell.RowIndex].Cells[2].Value.ToString())) - oldtotal;
                subTotal.Text = subtotal.ToString();
                decimal gstcalc = (Decimal)subtotal * (Decimal)0.05;
                gst.Text = gstcalc.ToString("#.##");
                decimal qstcalc = (Decimal)subtotal * (Decimal)0.099;
                qst.Text = qstcalc.ToString("#.##");
                total = subtotal + gstcalc + qstcalc;
                grandTotal.Text = total.ToString("#.##") + "$";
            }
            else
            {
                MessageBox.Show("Please select the Product Sku.");
            }
        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
            if (orderView.SelectedCells[0].ColumnIndex.Equals(0)) //SAME LOGIC^^
            {
                decimal oldtotal = Decimal.Parse(orderView.Rows[orderView.CurrentCell.RowIndex].Cells[3].Value.ToString()) * Decimal.Parse(orderView.Rows[orderView.CurrentCell.RowIndex].Cells[2].Value.ToString());
                orderView.Rows.RemoveAt(orderView.CurrentCell.RowIndex);

                subtotal -= oldtotal;
                subTotal.Text = subtotal.ToString();
                decimal gstcalc = (Decimal)subtotal * (Decimal)0.05;
                gst.Text = gstcalc.ToString("#.##");
                decimal qstcalc = (Decimal)subtotal * (Decimal)0.099;
                qst.Text = qstcalc.ToString("#.##");
                total = subtotal + gstcalc + qstcalc;
                grandTotal.Text = total.ToString("#.##") + "$";
            }
            else
            {
                MessageBox.Show("Please select the Product Sku.");
            }
        }

        private void completeOrder_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to complete this order?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                string productsstring = "";
                string quantitystring = "";
                string pricesstring = "";

                for(int i = 1; i < orderView.Rows.Count - 1; i++)
                {
                    productsstring += orderView.Rows[i].Cells[0].Value.ToString() + ";";
                    quantitystring += orderView.Rows[i].Cells[2].Value.ToString() + ";";
                    pricesstring += orderView.Rows[i].Cells[3].Value.ToString() + ";";
                }

                string server = "localhost"; //same db logic 
                string database = "pos_system";
                string username = "root";
                string password = "";
                string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

                MySqlConnection conn = new MySqlConnection(constring);
                conn.Open();

                string query = "insert into orders values (@ORDERNUMBER, @ORDERTYPE, @LASTNAME, @FIRSTNAME, @COMPANY, @ADDRESS, @TELEPHONENO, @EMAIL, @PRODUCTS, @QUANTITIES, @PRICES, @TOTAL)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                Random rnd = new Random();

                cmd.Parameters.AddWithValue("@ORDERNUMBER", rnd.Next(1, 9999999).ToString()); 
                cmd.Parameters.AddWithValue("@ORDERTYPE", orderType.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@LASTNAME", LastName.Text);
                cmd.Parameters.AddWithValue("@FIRSTNAME", FirstName.Text);
                cmd.Parameters.AddWithValue("@COMPANY", Company.Text);
                cmd.Parameters.AddWithValue("@ADDRESS", Address.Text);
                cmd.Parameters.AddWithValue("@TELEPHONENO", Telephone.Text);
                cmd.Parameters.AddWithValue("@EMAIL", Email.Text);
                cmd.Parameters.AddWithValue("@PRODUCTS", productsstring);
                cmd.Parameters.AddWithValue("@QUANTITIES", quantitystring);
                cmd.Parameters.AddWithValue("@PRICES", pricesstring);
                cmd.Parameters.AddWithValue("@TOTAL", total.ToString("#.##"));

                cmd.ExecuteNonQuery(); //executing query 
                conn.Close();

                MessageBox.Show("Order has been successfully created.");
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if(searchInput.Text == "")
            {
                MessageBox.Show("Make sure the search field is filled");
            }
            else
            {
            string server = "localhost"; //same db logic 
            string database = "pos_system";
            string username = "root";
            string password = "";
            string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();

            string query = "select * from clients where Telephone = '" + searchInput.Value.ToString() + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read()) //if result found shows it in a textbox.
                {
                    quantityChange.Visible = true;
                    deleteItem.Visible = true;
                    completeOrder.Visible = true;
                    nextItemBtn.Visible = true;

                    LastName.Text = dr["LastName"].ToString();
                    FirstName.Text = dr["FirstName"].ToString();
                    Company.Text = dr["Company"].ToString();
                    Address.Text = dr["Address"].ToString();
                    Telephone.Text = dr["Telephone"].ToString();
                    Email.Text = dr["Email"].ToString();
                }
                else
                {
                    MessageBox.Show("Client not found");
                }
            } 
            
        }

        private void nextItemBtn_Click(object sender, EventArgs e)
        {
            string server = "localhost"; //SAME DB LOGIC
            string database = "pos_system";
            string username = "root";
            string password = "";
            string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();


            if (productInput.Value >= 100000 && productInput.Value <= 999999) //validating if the user inputted a sku or barcode. 
            {
                string query = "select * from inventory where Sku = '" + productInput.Value.ToString() + "'"; //checking sku
                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read()) //if dr can be read, meaning if it fetched any results from the db
                {
                    orderView.Rows.Add(dr["Sku"].ToString(), dr["ProductName"].ToString(), quantityInput.Value.ToString(), dr["Price"].ToString(), (Decimal.Parse(dr["Price"].ToString()) * quantityInput.Value));
                    //adds the product and its information to the datagridview

                    subtotal += Decimal.Parse(dr["Price"].ToString()) * quantityInput.Value; //add price x quantity of the item to the sub total.
                    subTotal.Text = subtotal.ToString(); //change label text
                    decimal gstcalc = (Decimal)subtotal * (Decimal)0.05; //calculate the gst.
                    gst.Text = gstcalc.ToString("#.##"); //change label text with correct decimal formatting 
                    decimal qstcalc = (Decimal)subtotal * (Decimal)0.099; //calculate the qst 
                    qst.Text = qstcalc.ToString("#.##"); //change label text with correct decimal formatting 
                    total = subtotal + gstcalc + qstcalc; //adding subtotal, gst and qst to find the total
                    grandTotal.Text = total.ToString("#.##") + "$"; // changing label text. 

                    productInput.Value = 0; //resetting the fields
                    quantityInput.Value = 1;

                    productInput.Select(); //moving the cursor back to product input


                }
                else //if no results are fetched, we tell the user the why.
                {
                    MessageBox.Show("Item not found");
                }
            }
            else if (productInput.Value >= 10000000000 && productInput.Value <= 99999999999) //SAME LOGIC^^
            {
                string query = "select * from inventory where Barcode = '" + productInput.Value.ToString() + "'"; //barcode instead of sku
                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    orderView.Rows.Add(dr["Sku"].ToString(), dr["ProductName"].ToString(), quantityInput.Value.ToString(), dr["Price"].ToString(), (Decimal.Parse(dr["Price"].ToString()) * quantityInput.Value));

                    subtotal += Decimal.Parse(dr["Price"].ToString()) * quantityInput.Value;
                    subTotal.Text = subtotal.ToString();
                    decimal gstcalc = (Decimal)subtotal * (Decimal)0.05;
                    gst.Text = gstcalc.ToString("#.##");
                    decimal qstcalc = (Decimal)subtotal * (Decimal)0.099;
                    qst.Text = qstcalc.ToString("#.##");
                    total = subtotal + gstcalc + qstcalc;
                    grandTotal.Text = total.ToString("#.##") + "$";

                    productInput.Value = Int32.Parse("");
                    quantityInput.Value = 1;

                    productInput.Select();

                }
                else
                {
                    MessageBox.Show("Item not found");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid product barcode or sku.");
            }
        }

        void StyleDataGridView() //styling the datagridview
        {
            orderView.BorderStyle = BorderStyle.None;
            orderView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            orderView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 32, 79);
            orderView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            orderView.BackgroundColor = Color.FromArgb(30, 30, 30);
            orderView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            orderView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            orderView.EnableHeadersVisualStyles = false;
            orderView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            orderView.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10);
            orderView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            orderView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void viewOrder_Click(object sender, EventArgs e)
        {

            ViewOrders viewOrders = new ViewOrders();
            viewOrders.ShowDialog();
        }
    }
}
