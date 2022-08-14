namespace POS_System.Forms
{
    partial class Orders
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
            this.viewOrder = new FontAwesome.Sharp.IconButton();
            this.completeOrder = new FontAwesome.Sharp.IconButton();
            this.deleteItem = new FontAwesome.Sharp.IconButton();
            this.quantityChange = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchInput = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.orderType = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Telephone = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Company = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.nextItemBtn = new System.Windows.Forms.Button();
            this.quantityInput = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.productInput = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.orderView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.qst = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gst = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grandTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.subTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchInput)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderView)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(79)))));
            this.menuBar.Controls.Add(this.viewOrder);
            this.menuBar.Controls.Add(this.completeOrder);
            this.menuBar.Controls.Add(this.deleteItem);
            this.menuBar.Controls.Add(this.quantityChange);
            this.menuBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuBar.Location = new System.Drawing.Point(0, 581);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(1060, 112);
            this.menuBar.TabIndex = 6;
            // 
            // viewOrder
            // 
            this.viewOrder.Dock = System.Windows.Forms.DockStyle.Right;
            this.viewOrder.FlatAppearance.BorderSize = 0;
            this.viewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewOrder.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewOrder.ForeColor = System.Drawing.Color.White;
            this.viewOrder.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            this.viewOrder.IconColor = System.Drawing.Color.White;
            this.viewOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.viewOrder.Location = new System.Drawing.Point(870, 0);
            this.viewOrder.Name = "viewOrder";
            this.viewOrder.Size = new System.Drawing.Size(95, 112);
            this.viewOrder.TabIndex = 4;
            this.viewOrder.Text = "View Orders";
            this.viewOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.viewOrder.UseVisualStyleBackColor = true;
            this.viewOrder.Click += new System.EventHandler(this.viewOrder_Click);
            // 
            // completeOrder
            // 
            this.completeOrder.Dock = System.Windows.Forms.DockStyle.Right;
            this.completeOrder.FlatAppearance.BorderSize = 0;
            this.completeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.completeOrder.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.completeOrder.ForeColor = System.Drawing.Color.White;
            this.completeOrder.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.completeOrder.IconColor = System.Drawing.Color.White;
            this.completeOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.completeOrder.Location = new System.Drawing.Point(965, 0);
            this.completeOrder.Name = "completeOrder";
            this.completeOrder.Size = new System.Drawing.Size(95, 112);
            this.completeOrder.TabIndex = 3;
            this.completeOrder.Text = "Complete Order";
            this.completeOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.completeOrder.UseVisualStyleBackColor = true;
            this.completeOrder.Click += new System.EventHandler(this.completeOrder_Click);
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
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.searchInput);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 79);
            this.panel1.TabIndex = 7;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.searchBtn.Location = new System.Drawing.Point(934, 17);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(95, 35);
            this.searchBtn.TabIndex = 29;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchInput
            // 
            this.searchInput.InterceptArrowKeys = false;
            this.searchInput.Location = new System.Drawing.Point(661, 23);
            this.searchInput.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.searchInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(246, 23);
            this.searchInput.TabIndex = 28;
            this.searchInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(651, 53);
            this.label3.TabIndex = 27;
            this.label3.Text = "Enter the Client Telephone Number:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.orderType);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.Email);
            this.panel2.Controls.Add(this.Telephone);
            this.panel2.Controls.Add(this.Address);
            this.panel2.Controls.Add(this.Company);
            this.panel2.Controls.Add(this.FirstName);
            this.panel2.Controls.Add(this.LastName);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1060, 100);
            this.panel2.TabIndex = 8;
            // 
            // orderType
            // 
            this.orderType.FormattingEnabled = true;
            this.orderType.Items.AddRange(new object[] {
            "Deliveries",
            "Pick Up",
            "Online Order"});
            this.orderType.Location = new System.Drawing.Point(748, 29);
            this.orderType.Name = "orderType";
            this.orderType.Size = new System.Drawing.Size(225, 23);
            this.orderType.TabIndex = 13;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(661, 3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(391, 23);
            this.label20.TabIndex = 12;
            this.label20.Text = "Order Type:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Email.Location = new System.Drawing.Point(310, 42);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(402, 21);
            this.Email.TabIndex = 11;
            this.Email.Text = "Email:";
            // 
            // Telephone
            // 
            this.Telephone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Telephone.Location = new System.Drawing.Point(310, 21);
            this.Telephone.Name = "Telephone";
            this.Telephone.Size = new System.Drawing.Size(96, 21);
            this.Telephone.TabIndex = 10;
            this.Telephone.Text = "Telephone:";
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Address.Location = new System.Drawing.Point(310, 0);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(402, 21);
            this.Address.TabIndex = 9;
            this.Address.Text = "Address:";
            // 
            // Company
            // 
            this.Company.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Company.Location = new System.Drawing.Point(95, 42);
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(92, 21);
            this.Company.TabIndex = 8;
            this.Company.Text = "Company:";
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstName.Location = new System.Drawing.Point(95, 21);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(95, 21);
            this.FirstName.TabIndex = 7;
            this.FirstName.Text = "First Name:";
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastName.Location = new System.Drawing.Point(95, 0);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(97, 21);
            this.LastName.TabIndex = 6;
            this.LastName.Text = "Last Name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(256, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 21);
            this.label13.TabIndex = 5;
            this.label13.Text = "Email:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(215, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 21);
            this.label12.TabIndex = 4;
            this.label12.Text = "Telephone:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(235, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 21);
            this.label11.TabIndex = 3;
            this.label11.Text = "Address:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(3, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "Company:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(0, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "First Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Last Name:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.orderView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 179);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(663, 402);
            this.panel3.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.nextItemBtn);
            this.panel5.Controls.Add(this.quantityInput);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.productInput);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 218);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(663, 184);
            this.panel5.TabIndex = 1;
            // 
            // nextItemBtn
            // 
            this.nextItemBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(79)))));
            this.nextItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextItemBtn.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nextItemBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.nextItemBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nextItemBtn.Location = new System.Drawing.Point(282, 107);
            this.nextItemBtn.Name = "nextItemBtn";
            this.nextItemBtn.Size = new System.Drawing.Size(372, 62);
            this.nextItemBtn.TabIndex = 30;
            this.nextItemBtn.Text = "Next Item";
            this.nextItemBtn.UseVisualStyleBackColor = false;
            this.nextItemBtn.Click += new System.EventHandler(this.nextItemBtn_Click);
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
            this.quantityInput.TabIndex = 29;
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
            this.label7.TabIndex = 26;
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
            this.productInput.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(321, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 41);
            this.label8.TabIndex = 28;
            this.label8.Text = "Quantity:";
            // 
            // orderView
            // 
            this.orderView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.orderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.orderView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderView.Location = new System.Drawing.Point(0, 0);
            this.orderView.Name = "orderView";
            this.orderView.RowTemplate.Height = 25;
            this.orderView.Size = new System.Drawing.Size(663, 402);
            this.orderView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product Sku";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Product Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Single Price";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.qst);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.gst);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.grandTotal);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.subTotal);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(663, 179);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(397, 402);
            this.panel4.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::POS_System.Properties.Resources.circle_dashed_4_512;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // qst
            // 
            this.qst.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.qst.Location = new System.Drawing.Point(85, 335);
            this.qst.Name = "qst";
            this.qst.Size = new System.Drawing.Size(304, 23);
            this.qst.TabIndex = 17;
            this.qst.Text = "0.00";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(-2, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "QST (9.9%):";
            // 
            // gst
            // 
            this.gst.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gst.Location = new System.Drawing.Point(85, 314);
            this.gst.Name = "gst";
            this.gst.Size = new System.Drawing.Size(304, 23);
            this.gst.TabIndex = 15;
            this.gst.Text = "0.00";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(11, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "GST (5%):";
            // 
            // grandTotal
            // 
            this.grandTotal.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grandTotal.ForeColor = System.Drawing.Color.Green;
            this.grandTotal.Location = new System.Drawing.Point(222, 358);
            this.grandTotal.Name = "grandTotal";
            this.grandTotal.Size = new System.Drawing.Size(167, 41);
            this.grandTotal.TabIndex = 13;
            this.grandTotal.Text = "0.00$";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(-2, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 41);
            this.label2.TabIndex = 12;
            this.label2.Text = "Grand Total:";
            // 
            // subTotal
            // 
            this.subTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subTotal.Location = new System.Drawing.Point(85, 291);
            this.subTotal.Name = "subTotal";
            this.subTotal.Size = new System.Drawing.Size(304, 23);
            this.subTotal.TabIndex = 11;
            this.subTotal.Text = "0.00";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sub-Total:";
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 693);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuBar);
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.menuBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchInput)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quantityInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderView)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel menuBar;
        private FontAwesome.Sharp.IconButton completeOrder;
        private FontAwesome.Sharp.IconButton deleteItem;
        private FontAwesome.Sharp.IconButton quantityChange;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private DataGridView orderView;
        private Panel panel5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label qst;
        private Label label6;
        private Label gst;
        private Label label4;
        private Label grandTotal;
        private Label label2;
        private Label subTotal;
        private Label label1;
        private PictureBox pictureBox1;
        private NumericUpDown quantityInput;
        private Label label7;
        private NumericUpDown productInput;
        private Label label8;
        private Label label3;
        private Button nextItemBtn;
        private NumericUpDown searchInput;
        private Button searchBtn;
        private FontAwesome.Sharp.IconButton viewOrder;
        private ComboBox orderType;
        private Label label20;
        private Label Email;
        private Label Telephone;
        private Label Address;
        private Label Company;
        private Label FirstName;
        private Label LastName;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label5;
        private Label label14;
    }
}