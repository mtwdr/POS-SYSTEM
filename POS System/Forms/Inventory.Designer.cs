namespace POS_System.Forms
{
    partial class Inventory
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
            FontAwesome.Sharp.IconButton deleteProductBtn;
            FontAwesome.Sharp.IconButton updateProductBtn;
            this.panel1 = new System.Windows.Forms.Panel();
            this.inventoryView = new System.Windows.Forms.DataGridView();
            this.menuBar = new System.Windows.Forms.Panel();
            this.searchProductBtn = new FontAwesome.Sharp.IconButton();
            this.createProductBtn = new FontAwesome.Sharp.IconButton();
            deleteProductBtn = new FontAwesome.Sharp.IconButton();
            updateProductBtn = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryView)).BeginInit();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteProductBtn
            // 
            deleteProductBtn.Dock = System.Windows.Forms.DockStyle.Left;
            deleteProductBtn.FlatAppearance.BorderSize = 0;
            deleteProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            deleteProductBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            deleteProductBtn.ForeColor = System.Drawing.Color.White;
            deleteProductBtn.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            deleteProductBtn.IconColor = System.Drawing.Color.White;
            deleteProductBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteProductBtn.Location = new System.Drawing.Point(285, 0);
            deleteProductBtn.Name = "deleteProductBtn";
            deleteProductBtn.Size = new System.Drawing.Size(95, 112);
            deleteProductBtn.TabIndex = 3;
            deleteProductBtn.Text = "Delete Product";
            deleteProductBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            deleteProductBtn.UseVisualStyleBackColor = true;
            deleteProductBtn.Click += new System.EventHandler(this.deleteProductBtn_Click);
            // 
            // updateProductBtn
            // 
            updateProductBtn.Dock = System.Windows.Forms.DockStyle.Left;
            updateProductBtn.FlatAppearance.BorderSize = 0;
            updateProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            updateProductBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            updateProductBtn.ForeColor = System.Drawing.Color.White;
            updateProductBtn.IconChar = FontAwesome.Sharp.IconChar.Pen;
            updateProductBtn.IconColor = System.Drawing.Color.White;
            updateProductBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            updateProductBtn.Location = new System.Drawing.Point(190, 0);
            updateProductBtn.Name = "updateProductBtn";
            updateProductBtn.Size = new System.Drawing.Size(95, 112);
            updateProductBtn.TabIndex = 2;
            updateProductBtn.Text = "Update Product";
            updateProductBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            updateProductBtn.UseVisualStyleBackColor = true;
            updateProductBtn.Click += new System.EventHandler(this.updateProductBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.inventoryView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1044, 542);
            this.panel1.TabIndex = 6;
            // 
            // inventoryView
            // 
            this.inventoryView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventoryView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.inventoryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryView.Location = new System.Drawing.Point(10, 10);
            this.inventoryView.Name = "inventoryView";
            this.inventoryView.RowTemplate.Height = 25;
            this.inventoryView.Size = new System.Drawing.Size(1024, 522);
            this.inventoryView.TabIndex = 0;
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(79)))));
            this.menuBar.Controls.Add(deleteProductBtn);
            this.menuBar.Controls.Add(updateProductBtn);
            this.menuBar.Controls.Add(this.searchProductBtn);
            this.menuBar.Controls.Add(this.createProductBtn);
            this.menuBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuBar.Location = new System.Drawing.Point(0, 542);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(1044, 112);
            this.menuBar.TabIndex = 5;
            // 
            // searchProductBtn
            // 
            this.searchProductBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchProductBtn.FlatAppearance.BorderSize = 0;
            this.searchProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchProductBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchProductBtn.ForeColor = System.Drawing.Color.White;
            this.searchProductBtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.searchProductBtn.IconColor = System.Drawing.Color.White;
            this.searchProductBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchProductBtn.Location = new System.Drawing.Point(95, 0);
            this.searchProductBtn.Name = "searchProductBtn";
            this.searchProductBtn.Size = new System.Drawing.Size(95, 112);
            this.searchProductBtn.TabIndex = 1;
            this.searchProductBtn.Text = "Search Product";
            this.searchProductBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.searchProductBtn.UseVisualStyleBackColor = true;
            this.searchProductBtn.Click += new System.EventHandler(this.searchProductBtn_Click);
            // 
            // createProductBtn
            // 
            this.createProductBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.createProductBtn.FlatAppearance.BorderSize = 0;
            this.createProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createProductBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createProductBtn.ForeColor = System.Drawing.Color.White;
            this.createProductBtn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.createProductBtn.IconColor = System.Drawing.Color.White;
            this.createProductBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.createProductBtn.Location = new System.Drawing.Point(0, 0);
            this.createProductBtn.Name = "createProductBtn";
            this.createProductBtn.Size = new System.Drawing.Size(95, 112);
            this.createProductBtn.TabIndex = 0;
            this.createProductBtn.Text = "Add Product";
            this.createProductBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.createProductBtn.UseVisualStyleBackColor = true;
            this.createProductBtn.Click += new System.EventHandler(this.createProductBtn_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 654);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuBar);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryView)).EndInit();
            this.menuBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel menuBar;
        private FontAwesome.Sharp.IconButton searchProductBtn;
        private FontAwesome.Sharp.IconButton createProductBtn;
        private DataGridView inventoryView;
    }
}