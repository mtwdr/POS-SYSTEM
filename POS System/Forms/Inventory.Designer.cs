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
            FontAwesome.Sharp.IconButton deleteClientBtn;
            FontAwesome.Sharp.IconButton updateClientBtn;
            this.panel1 = new System.Windows.Forms.Panel();
            this.inventoryListBox = new System.Windows.Forms.ListBox();
            this.menuBar = new System.Windows.Forms.Panel();
            this.searchClientBtn = new FontAwesome.Sharp.IconButton();
            this.createClientBtn = new FontAwesome.Sharp.IconButton();
            deleteClientBtn = new FontAwesome.Sharp.IconButton();
            updateClientBtn = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.inventoryListBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1044, 542);
            this.panel1.TabIndex = 6;
            // 
            // inventoryListBox
            // 
            this.inventoryListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryListBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inventoryListBox.FormattingEnabled = true;
            this.inventoryListBox.ItemHeight = 24;
            this.inventoryListBox.Location = new System.Drawing.Point(10, 10);
            this.inventoryListBox.Name = "inventoryListBox";
            this.inventoryListBox.Size = new System.Drawing.Size(1024, 522);
            this.inventoryListBox.TabIndex = 0;
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(79)))));
            this.menuBar.Controls.Add(deleteClientBtn);
            this.menuBar.Controls.Add(updateClientBtn);
            this.menuBar.Controls.Add(this.searchClientBtn);
            this.menuBar.Controls.Add(this.createClientBtn);
            this.menuBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuBar.Location = new System.Drawing.Point(0, 542);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(1044, 112);
            this.menuBar.TabIndex = 5;
            // 
            // deleteClientBtn
            // 
            deleteClientBtn.Dock = System.Windows.Forms.DockStyle.Left;
            deleteClientBtn.FlatAppearance.BorderSize = 0;
            deleteClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            deleteClientBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            deleteClientBtn.ForeColor = System.Drawing.Color.White;
            deleteClientBtn.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            deleteClientBtn.IconColor = System.Drawing.Color.White;
            deleteClientBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteClientBtn.Location = new System.Drawing.Point(285, 0);
            deleteClientBtn.Name = "deleteClientBtn";
            deleteClientBtn.Size = new System.Drawing.Size(95, 112);
            deleteClientBtn.TabIndex = 3;
            deleteClientBtn.Text = "Delete Product";
            deleteClientBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            deleteClientBtn.UseVisualStyleBackColor = true;
            // 
            // updateClientBtn
            // 
            updateClientBtn.Dock = System.Windows.Forms.DockStyle.Left;
            updateClientBtn.FlatAppearance.BorderSize = 0;
            updateClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            updateClientBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            updateClientBtn.ForeColor = System.Drawing.Color.White;
            updateClientBtn.IconChar = FontAwesome.Sharp.IconChar.Pen;
            updateClientBtn.IconColor = System.Drawing.Color.White;
            updateClientBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            updateClientBtn.Location = new System.Drawing.Point(190, 0);
            updateClientBtn.Name = "updateClientBtn";
            updateClientBtn.Size = new System.Drawing.Size(95, 112);
            updateClientBtn.TabIndex = 2;
            updateClientBtn.Text = "Update Product";
            updateClientBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            updateClientBtn.UseVisualStyleBackColor = true;
            // 
            // searchClientBtn
            // 
            this.searchClientBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchClientBtn.FlatAppearance.BorderSize = 0;
            this.searchClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchClientBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchClientBtn.ForeColor = System.Drawing.Color.White;
            this.searchClientBtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.searchClientBtn.IconColor = System.Drawing.Color.White;
            this.searchClientBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchClientBtn.Location = new System.Drawing.Point(95, 0);
            this.searchClientBtn.Name = "searchClientBtn";
            this.searchClientBtn.Size = new System.Drawing.Size(95, 112);
            this.searchClientBtn.TabIndex = 1;
            this.searchClientBtn.Text = "Search Product";
            this.searchClientBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.searchClientBtn.UseVisualStyleBackColor = true;
            // 
            // createClientBtn
            // 
            this.createClientBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.createClientBtn.FlatAppearance.BorderSize = 0;
            this.createClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createClientBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createClientBtn.ForeColor = System.Drawing.Color.White;
            this.createClientBtn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.createClientBtn.IconColor = System.Drawing.Color.White;
            this.createClientBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.createClientBtn.Location = new System.Drawing.Point(0, 0);
            this.createClientBtn.Name = "createClientBtn";
            this.createClientBtn.Size = new System.Drawing.Size(95, 112);
            this.createClientBtn.TabIndex = 0;
            this.createClientBtn.Text = "Add Product";
            this.createClientBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.createClientBtn.UseVisualStyleBackColor = true;
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
            this.menuBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private ListBox inventoryListBox;
        private Panel menuBar;
        private FontAwesome.Sharp.IconButton searchClientBtn;
        private FontAwesome.Sharp.IconButton createClientBtn;
    }
}