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
    public partial class CashRegister : Form
    {

        private decimal subtotal; //private variables for subtotal
        private decimal total; //private variables for total

        public CashRegister()
        {
            InitializeComponent();
            productInput.Controls.RemoveAt(0); //removes arrows from productinput.
        }

        private void CashRegister_Load(object sender, EventArgs e)
        {
            StyleDataGridView();

            subtotal = 0; //setting the private variables back to 0. 
            total = 0; //setting the private variables back to 0. 
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
                    cartView.Rows.Add(dr["Sku"].ToString(), dr["ProductName"].ToString(), quantityInput.Value.ToString(), dr["Price"].ToString(), (Decimal.Parse(dr["Price"].ToString()) * quantityInput.Value));
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
            } else if (productInput.Value >= 10000000000 && productInput.Value <= 99999999999) //SAME LOGIC^^
            {
                string query = "select * from inventory where Barcode = '" + productInput.Value.ToString() + "'"; //barcode instead of sku
                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    cartView.Rows.Add(dr["Sku"].ToString(), dr["ProductName"].ToString(), quantityInput.Value.ToString(), dr["Price"].ToString(), (Decimal.Parse(dr["Price"].ToString()) * quantityInput.Value));

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
            } else
            {
                MessageBox.Show("Please enter a valid product barcode or sku.");
            }
         
        }

        private void quantityChange_Click(object sender, EventArgs e) //SAME LOGIC^^
        {
            if (cartView.SelectedCells[0].ColumnIndex.Equals(0)) //Check if user is selecting the product sku column.
            {

                //SAME LOGIC^^
                decimal oldtotal = Decimal.Parse(cartView.Rows[cartView.CurrentCell.RowIndex].Cells[3].Value.ToString()) * Decimal.Parse(cartView.Rows[cartView.CurrentCell.RowIndex].Cells[2].Value.ToString());
                cartView.Rows[cartView.CurrentCell.RowIndex].Cells[2].Value = quantityInput.Value;

                subtotal += (Decimal.Parse(cartView.Rows[cartView.CurrentCell.RowIndex].Cells[3].Value.ToString()) * Decimal.Parse(cartView.Rows[cartView.CurrentCell.RowIndex].Cells[2].Value.ToString())) - oldtotal;
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

        private void deleteItem_Click(object sender, EventArgs e) //SAME LOGIC^^
        {
            if (cartView.SelectedCells[0].ColumnIndex.Equals(0)) //SAME LOGIC^^
            {
                decimal oldtotal = Decimal.Parse(cartView.Rows[cartView.CurrentCell.RowIndex].Cells[3].Value.ToString()) * Decimal.Parse(cartView.Rows[cartView.CurrentCell.RowIndex].Cells[2].Value.ToString());
                cartView.Rows.RemoveAt(cartView.CurrentCell.RowIndex);

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

        private void checkout_Click(object sender, EventArgs e) //if datagridview is populated display message.
        {
            if(cartView.RowCount > 0)
            {
                MessageBox.Show("Please give client the pinpad, an invoice will print afterwards.");
            } else
            {
                MessageBox.Show("Please scan items.");
            }
        }

        void StyleDataGridView() //styling the datagridview
        {
            cartView.BorderStyle = BorderStyle.None;
            cartView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            cartView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 32, 79);
            cartView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            cartView.BackgroundColor = Color.FromArgb(30, 30, 30);
            cartView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            cartView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            cartView.EnableHeadersVisualStyles = false;
            cartView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            cartView.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10);
            cartView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            cartView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
