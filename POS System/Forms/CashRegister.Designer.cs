namespace POS_System.Forms
{
    partial class CashRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuBar = new System.Windows.Forms.Panel();
            this.checkout = new FontAwesome.Sharp.IconButton();
            this.deleteItem = new FontAwesome.Sharp.IconButton();
            this.quantityChange = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.nextItemBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.quantityInput = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.productInput = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.qst = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gst = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grandTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.subTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cartView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInput)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(79)))));
            this.menuBar.Controls.Add(this.checkout);
            this.menuBar.Controls.Add(this.deleteItem);
            this.menuBar.Controls.Add(this.quantityChange);
            this.menuBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuBar.Location = new System.Drawing.Point(0, 581);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(1060, 112);
            this.menuBar.TabIndex = 4;
            // 
            // checkout
            // 
            this.checkout.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkout.FlatAppearance.BorderSize = 0;
            this.checkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkout.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkout.ForeColor = System.Drawing.Color.White;
            this.checkout.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            this.checkout.IconColor = System.Drawing.Color.White;
            this.checkout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.checkout.Location = new System.Drawing.Point(190, 0);
            this.checkout.Name = "checkout";
            this.checkout.Size = new System.Drawing.Size(95, 112);
            this.checkout.TabIndex = 3;
            this.checkout.Text = "Pay";
            this.checkout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.checkout.UseVisualStyleBackColor = true;
            this.checkout.Click += new System.EventHandler(this.checkout_Click);
            // 
            // deleteItem
            // 
            this.deleteItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.deleteItem.FlatAppearance.BorderSize = 0;
            this.deleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteItem.ForeColor = System.Drawing.Color.White;
            this.deleteItem.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            this.deleteItem.IconColor = System.Drawing.Color.White;
            this.deleteItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteItem.Location = new System.Drawing.Point(95, 0);
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(95, 112);
            this.deleteItem.TabIndex = 2;
            this.deleteItem.Text = "Delete Item";
            this.deleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.deleteItem.UseVisualStyleBackColor = true;
            this.deleteItem.Click += new System.EventHandler(this.deleteItem_Click);
            // 
            // quantityChange
            // 
            this.quantityChange.Dock = System.Windows.Forms.DockStyle.Left;
            this.quantityChange.FlatAppearance.BorderSize = 0;
            this.quantityChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quantityChange.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantityChange.ForeColor = System.Drawing.Color.White;
            this.quantityChange.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            this.quantityChange.IconColor = System.Drawing.Color.White;
            this.quantityChange.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.quantityChange.Location = new System.Drawing.Point(0, 0);
            this.quantityChange.Name = "quantityChange";
            this.quantityChange.Size = new System.Drawing.Size(95, 112);
            this.quantityChange.TabIndex = 0;
            this.quantityChange.Text = "Change Quantity";
            this.quantityChange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.quantityChange.UseVisualStyleBackColor = true;
            this.quantityChange.Click += new System.EventHandler(this.quantityChange_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 481);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 100);
            this.panel1.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.nextItemBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(665, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(395, 100);
            this.panel5.TabIndex = 1;
            // 
            // nextItemBtn
            // 
            this.nextItemBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(79)))));
            this.nextItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextItemBtn.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nextItemBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.nextItemBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nextItemBtn.Location = new System.Drawing.Point(12, 27);
            this.nextItemBtn.Name = "nextItemBtn";
            this.nextItemBtn.Size = new System.Drawing.Size(372, 62);
            this.nextItemBtn.TabIndex = 26;
            this.nextItemBtn.Text = "Next Item";
            this.nextItemBtn.UseVisualStyleBackColor = false;
            this.nextItemBtn.Click += new System.EventHandler(this.nextItemBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.quantityInput);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.productInput);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(665, 100);
            this.panel4.TabIndex = 0;
            // 
            // quantityInput
            // 
            this.quantityInput.InterceptArrowKeys = false;
            this.quantityInput.Location = new System.Drawing.Point(505, 66);
            this.quantityInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.quantityInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityInput.Name = "quantityInput";
            this.quantityInput.Size = new System.Drawing.Size(149, 23);
            this.quantityInput.TabIndex = 25;
            this.quantityInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(500, 41);
            this.label7.TabIndex = 5;
            this.label7.Text = "Scan Barcode or Enter Sku:";
            // 
            // productInput
            // 
            this.productInput.InterceptArrowKeys = false;
            this.productInput.Location = new System.Drawing.Point(505, 27);
            this.productInput.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.productInput.Name = "productInput";
            this.productInput.Size = new System.Drawing.Size(149, 23);
            this.productInput.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(321, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 41);
            this.label8.TabIndex = 24;
            this.label8.Text = "Quantity:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.qst);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.gst);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.grandTotal);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.subTotal);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(665, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 481);
            this.panel2.TabIndex = 6;
            // 
            // qst
            // 
            this.qst.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.qst.Location = new System.Drawing.Point(90, 374);
            this.qst.Name = "qst";
            this.qst.Size = new System.Drawing.Size(304, 23);
            this.qst.TabIndex = 9;
            this.qst.Text = "0.00";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "QST (9.9%):";
            // 
            // gst
            // 
            this.gst.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gst.Location = new System.Drawing.Point(90, 353);
            this.gst.Name = "gst";
            this.gst.Size = new System.Drawing.Size(304, 23);
            this.gst.TabIndex = 7;
            this.gst.Text = "0.00";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(16, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "GST (5%):";
            // 
            // grandTotal
            // 
            this.grandTotal.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grandTotal.ForeColor = System.Drawing.Color.Green;
            this.grandTotal.Location = new System.Drawing.Point(227, 397);
            this.grandTotal.Name = "grandTotal";
            this.grandTotal.Size = new System.Drawing.Size(167, 41);
            this.grandTotal.TabIndex = 5;
            this.grandTotal.Text = "0.00$";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "Grand Total:";
            // 
            // subTotal
            // 
            this.subTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subTotal.Location = new System.Drawing.Point(90, 330);
            this.subTotal.Name = "subTotal";
            this.subTotal.Size = new System.Drawing.Size(304, 23);
            this.subTotal.TabIndex = 3;
            this.subTotal.Text = "0.00";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sub-Total:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::POS_System.Properties.Resources.circle_dashed_4_512;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 316);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cartView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(665, 481);
            this.panel3.TabIndex = 7;
            // 
            // cartView
            // 
            this.cartView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cartView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.cartView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4});
            this.cartView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartView.Location = new System.Drawing.Point(0, 0);
            this.cartView.Name = "cartView";
            this.cartView.RowTemplate.Height = 25;
            this.cartView.Size = new System.Drawing.Size(665, 481);
            this.cartView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product SKU";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Product Name";
            this.Column5.Name = "Column5";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Quantity";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Single Price";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // CashRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 693);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuBar);
            this.Name = "CashRegister";
            this.Text = "CashRegister";
            this.Load += new System.EventHandler(this.CashRegister_Load);
            this.menuBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quantityInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInput)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cartView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel menuBar;
        private FontAwesome.Sharp.IconButton quantityChange;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView cartView;
        private PictureBox pictureBox1;
        private Label subTotal;
        private Label label1;
        private Label label7;
        private Label qst;
        private Label label6;
        private Label gst;
        private Label label4;
        private Label grandTotal;
        private Label label2;
        private Label label8;
        private NumericUpDown productInput;
        private NumericUpDown quantityInput;
        private Button nextItemBtn;
        private Panel panel5;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton checkout;
        private FontAwesome.Sharp.IconButton deleteItem;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}