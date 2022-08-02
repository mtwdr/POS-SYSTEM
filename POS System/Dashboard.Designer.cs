namespace POS_System
{
    partial class Dashboard
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
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.logoutBtn = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.usersBtn = new FontAwesome.Sharp.IconButton();
            this.inventoryBtn = new FontAwesome.Sharp.IconButton();
            this.orderBtn = new FontAwesome.Sharp.IconButton();
            this.cashBtn = new FontAwesome.Sharp.IconButton();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.imgHome = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.closeForm = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.PanelMenu.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.PanelMenu.Controls.Add(this.logoutBtn);
            this.PanelMenu.Controls.Add(this.iconButton1);
            this.PanelMenu.Controls.Add(this.usersBtn);
            this.PanelMenu.Controls.Add(this.inventoryBtn);
            this.PanelMenu.Controls.Add(this.orderBtn);
            this.PanelMenu.Controls.Add(this.cashBtn);
            this.PanelMenu.Controls.Add(this.PanelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(220, 720);
            this.PanelMenu.TabIndex = 0;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.logoutBtn.IconColor = System.Drawing.Color.White;
            this.logoutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logoutBtn.IconSize = 52;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(0, 440);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.logoutBtn.Size = new System.Drawing.Size(220, 60);
            this.logoutBtn.TabIndex = 6;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 52;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 380);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(220, 60);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Users";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.usersBtn_Click);
            // 
            // usersBtn
            // 
            this.usersBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersBtn.FlatAppearance.BorderSize = 0;
            this.usersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usersBtn.ForeColor = System.Drawing.Color.White;
            this.usersBtn.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.usersBtn.IconColor = System.Drawing.Color.White;
            this.usersBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.usersBtn.IconSize = 52;
            this.usersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersBtn.Location = new System.Drawing.Point(0, 320);
            this.usersBtn.Name = "usersBtn";
            this.usersBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.usersBtn.Size = new System.Drawing.Size(220, 60);
            this.usersBtn.TabIndex = 4;
            this.usersBtn.Text = "Inventory";
            this.usersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.usersBtn.UseVisualStyleBackColor = true;
            this.usersBtn.Click += new System.EventHandler(this.inventoryBtn_Click);
            // 
            // inventoryBtn
            // 
            this.inventoryBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.inventoryBtn.FlatAppearance.BorderSize = 0;
            this.inventoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inventoryBtn.ForeColor = System.Drawing.Color.White;
            this.inventoryBtn.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.inventoryBtn.IconColor = System.Drawing.Color.White;
            this.inventoryBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.inventoryBtn.IconSize = 52;
            this.inventoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventoryBtn.Location = new System.Drawing.Point(0, 260);
            this.inventoryBtn.Name = "inventoryBtn";
            this.inventoryBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.inventoryBtn.Size = new System.Drawing.Size(220, 60);
            this.inventoryBtn.TabIndex = 3;
            this.inventoryBtn.Text = "Orders";
            this.inventoryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventoryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.inventoryBtn.UseVisualStyleBackColor = true;
            this.inventoryBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderBtn.FlatAppearance.BorderSize = 0;
            this.orderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderBtn.ForeColor = System.Drawing.Color.White;
            this.orderBtn.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.orderBtn.IconColor = System.Drawing.Color.White;
            this.orderBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.orderBtn.IconSize = 52;
            this.orderBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orderBtn.Location = new System.Drawing.Point(0, 200);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.orderBtn.Size = new System.Drawing.Size(220, 60);
            this.orderBtn.TabIndex = 2;
            this.orderBtn.Text = "Clients";
            this.orderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orderBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.clientsBtn_Click);
            // 
            // cashBtn
            // 
            this.cashBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.cashBtn.FlatAppearance.BorderSize = 0;
            this.cashBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cashBtn.ForeColor = System.Drawing.Color.White;
            this.cashBtn.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.cashBtn.IconColor = System.Drawing.Color.White;
            this.cashBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cashBtn.IconSize = 52;
            this.cashBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cashBtn.Location = new System.Drawing.Point(0, 140);
            this.cashBtn.Name = "cashBtn";
            this.cashBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.cashBtn.Size = new System.Drawing.Size(220, 60);
            this.cashBtn.TabIndex = 1;
            this.cashBtn.Text = "Cash Register";
            this.cashBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cashBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cashBtn.UseVisualStyleBackColor = true;
            this.cashBtn.Click += new System.EventHandler(this.cashBtn_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.imgHome);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(220, 140);
            this.PanelLogo.TabIndex = 0;
            // 
            // imgHome
            // 
            this.imgHome.Image = global::POS_System.Properties.Resources.circle_dashed_4_512;
            this.imgHome.Location = new System.Drawing.Point(21, 12);
            this.imgHome.Name = "imgHome";
            this.imgHome.Size = new System.Drawing.Size(179, 112);
            this.imgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgHome.TabIndex = 0;
            this.imgHome.TabStop = false;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitle.Controls.Add(this.btnMinimize);
            this.panelTitle.Controls.Add(this.btnMaximize);
            this.panelTitle.Controls.Add(this.btnClose);
            this.panelTitle.Controls.Add(this.closeForm);
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1060, 27);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(973, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 23);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(1004, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(25, 23);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.Text = "O";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1035, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // closeForm
            // 
            this.closeForm.AutoSize = true;
            this.closeForm.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeForm.ForeColor = System.Drawing.Color.White;
            this.closeForm.Location = new System.Drawing.Point(6, 0);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(23, 24);
            this.closeForm.TabIndex = 0;
            this.closeForm.Text = "X";
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(480, 2);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(72, 24);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "HOME";
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(220, 27);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(1060, 693);
            this.panelDesktopPanel.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.PanelMenu);
            this.MinimumSize = new System.Drawing.Size(1296, 759);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.PanelMenu.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelMenu;
        private Panel PanelLogo;
        private PictureBox imgHome;
        private FontAwesome.Sharp.IconButton usersBtn;
        private FontAwesome.Sharp.IconButton inventoryBtn;
        private FontAwesome.Sharp.IconButton orderBtn;
        private FontAwesome.Sharp.IconButton cashBtn;
        private Panel panelTitle;
        private Label labelTitle;
        private Panel panelDesktopPanel;
        private Label closeForm;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton logoutBtn;
    }
}