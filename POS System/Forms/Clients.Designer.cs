namespace POS_System.Forms
{
    partial class Clients
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
            FontAwesome.Sharp.IconButton updateClientBtn;
            FontAwesome.Sharp.IconButton deleteClientBtn;
            this.menuBar = new System.Windows.Forms.Panel();
            this.searchClientBtn = new FontAwesome.Sharp.IconButton();
            this.createClientBtn = new FontAwesome.Sharp.IconButton();
            this.clientsPanel = new System.Windows.Forms.Panel();
            this.clientsView = new System.Windows.Forms.DataGridView();
            updateClientBtn = new FontAwesome.Sharp.IconButton();
            deleteClientBtn = new FontAwesome.Sharp.IconButton();
            this.menuBar.SuspendLayout();
            this.clientsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsView)).BeginInit();
            this.SuspendLayout();
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
            updateClientBtn.Text = "Update Client";
            updateClientBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            updateClientBtn.UseVisualStyleBackColor = true;
            updateClientBtn.Click += new System.EventHandler(this.updateClientBtn_Click);
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
            deleteClientBtn.Text = "Delete Client";
            deleteClientBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            deleteClientBtn.UseVisualStyleBackColor = true;
            deleteClientBtn.Click += new System.EventHandler(this.deleteClientBtn_Click);
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
            this.menuBar.TabIndex = 3;
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
            this.searchClientBtn.Text = "Search Client";
            this.searchClientBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.searchClientBtn.UseVisualStyleBackColor = true;
            this.searchClientBtn.Click += new System.EventHandler(this.searchClientBtn_Click);
            // 
            // createClientBtn
            // 
            this.createClientBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.createClientBtn.FlatAppearance.BorderSize = 0;
            this.createClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createClientBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createClientBtn.ForeColor = System.Drawing.Color.White;
            this.createClientBtn.IconChar = FontAwesome.Sharp.IconChar.PersonCirclePlus;
            this.createClientBtn.IconColor = System.Drawing.Color.White;
            this.createClientBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.createClientBtn.Location = new System.Drawing.Point(0, 0);
            this.createClientBtn.Name = "createClientBtn";
            this.createClientBtn.Size = new System.Drawing.Size(95, 112);
            this.createClientBtn.TabIndex = 0;
            this.createClientBtn.Text = "Create New Client";
            this.createClientBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.createClientBtn.UseVisualStyleBackColor = true;
            this.createClientBtn.Click += new System.EventHandler(this.createClientBtn_Click);
            // 
            // clientsPanel
            // 
            this.clientsPanel.Controls.Add(this.clientsView);
            this.clientsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientsPanel.Location = new System.Drawing.Point(0, 0);
            this.clientsPanel.Name = "clientsPanel";
            this.clientsPanel.Padding = new System.Windows.Forms.Padding(10);
            this.clientsPanel.Size = new System.Drawing.Size(1044, 542);
            this.clientsPanel.TabIndex = 4;
            // 
            // clientsView
            // 
            this.clientsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientsView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.clientsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientsView.Location = new System.Drawing.Point(10, 10);
            this.clientsView.Name = "clientsView";
            this.clientsView.RowTemplate.Height = 25;
            this.clientsView.Size = new System.Drawing.Size(1024, 522);
            this.clientsView.TabIndex = 0;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 654);
            this.Controls.Add(this.clientsPanel);
            this.Controls.Add(this.menuBar);
            this.Name = "Clients";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Clients_Load);
            this.menuBar.ResumeLayout(false);
            this.clientsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel menuBar;
        private FontAwesome.Sharp.IconButton createClientBtn;
        private FontAwesome.Sharp.IconButton searchClientBtn;
        private Panel clientsPanel;
        private DataGridView clientsView;
    }
}