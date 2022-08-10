namespace POS_System.Forms
{
    partial class Users
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
            FontAwesome.Sharp.IconButton deleteUserBtn;
            FontAwesome.Sharp.IconButton updateUserBtn;
            this.panel1 = new System.Windows.Forms.Panel();
            this.usersListBox = new System.Windows.Forms.ListBox();
            this.menuBar = new System.Windows.Forms.Panel();
            this.searchUserBtn = new FontAwesome.Sharp.IconButton();
            this.createUserBtn = new FontAwesome.Sharp.IconButton();
            deleteUserBtn = new FontAwesome.Sharp.IconButton();
            updateUserBtn = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteUserBtn
            // 
            deleteUserBtn.Dock = System.Windows.Forms.DockStyle.Left;
            deleteUserBtn.FlatAppearance.BorderSize = 0;
            deleteUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            deleteUserBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            deleteUserBtn.ForeColor = System.Drawing.Color.White;
            deleteUserBtn.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            deleteUserBtn.IconColor = System.Drawing.Color.White;
            deleteUserBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteUserBtn.Location = new System.Drawing.Point(285, 0);
            deleteUserBtn.Name = "deleteUserBtn";
            deleteUserBtn.Size = new System.Drawing.Size(95, 112);
            deleteUserBtn.TabIndex = 3;
            deleteUserBtn.Text = "Delete User";
            deleteUserBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            deleteUserBtn.UseVisualStyleBackColor = true;
            deleteUserBtn.Click += new System.EventHandler(this.deleteUserBtn_Click);
            // 
            // updateUserBtn
            // 
            updateUserBtn.Dock = System.Windows.Forms.DockStyle.Left;
            updateUserBtn.FlatAppearance.BorderSize = 0;
            updateUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            updateUserBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            updateUserBtn.ForeColor = System.Drawing.Color.White;
            updateUserBtn.IconChar = FontAwesome.Sharp.IconChar.Pen;
            updateUserBtn.IconColor = System.Drawing.Color.White;
            updateUserBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            updateUserBtn.Location = new System.Drawing.Point(190, 0);
            updateUserBtn.Name = "updateUserBtn";
            updateUserBtn.Size = new System.Drawing.Size(95, 112);
            updateUserBtn.TabIndex = 2;
            updateUserBtn.Text = "Update User";
            updateUserBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            updateUserBtn.UseVisualStyleBackColor = true;
            updateUserBtn.Click += new System.EventHandler(this.updateUserBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.usersListBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1044, 542);
            this.panel1.TabIndex = 6;
            // 
            // usersListBox
            // 
            this.usersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersListBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.ItemHeight = 24;
            this.usersListBox.Location = new System.Drawing.Point(10, 10);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.Size = new System.Drawing.Size(1024, 522);
            this.usersListBox.TabIndex = 0;
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(79)))));
            this.menuBar.Controls.Add(deleteUserBtn);
            this.menuBar.Controls.Add(updateUserBtn);
            this.menuBar.Controls.Add(this.searchUserBtn);
            this.menuBar.Controls.Add(this.createUserBtn);
            this.menuBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuBar.Location = new System.Drawing.Point(0, 542);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(1044, 112);
            this.menuBar.TabIndex = 5;
            // 
            // searchUserBtn
            // 
            this.searchUserBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchUserBtn.FlatAppearance.BorderSize = 0;
            this.searchUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchUserBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchUserBtn.ForeColor = System.Drawing.Color.White;
            this.searchUserBtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.searchUserBtn.IconColor = System.Drawing.Color.White;
            this.searchUserBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchUserBtn.Location = new System.Drawing.Point(95, 0);
            this.searchUserBtn.Name = "searchUserBtn";
            this.searchUserBtn.Size = new System.Drawing.Size(95, 112);
            this.searchUserBtn.TabIndex = 1;
            this.searchUserBtn.Text = "Search User";
            this.searchUserBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.searchUserBtn.UseVisualStyleBackColor = true;
            this.searchUserBtn.Click += new System.EventHandler(this.searchUserBtn_Click);
            // 
            // createUserBtn
            // 
            this.createUserBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.createUserBtn.FlatAppearance.BorderSize = 0;
            this.createUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createUserBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createUserBtn.ForeColor = System.Drawing.Color.White;
            this.createUserBtn.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.createUserBtn.IconColor = System.Drawing.Color.White;
            this.createUserBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.createUserBtn.Location = new System.Drawing.Point(0, 0);
            this.createUserBtn.Name = "createUserBtn";
            this.createUserBtn.Size = new System.Drawing.Size(95, 112);
            this.createUserBtn.TabIndex = 0;
            this.createUserBtn.Text = "Create New User";
            this.createUserBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.createUserBtn.UseVisualStyleBackColor = true;
            this.createUserBtn.Click += new System.EventHandler(this.createUserBtn_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 654);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuBar);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.panel1.ResumeLayout(false);
            this.menuBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private ListBox usersListBox;
        private Panel menuBar;
        private FontAwesome.Sharp.IconButton searchUserBtn;
        private FontAwesome.Sharp.IconButton createUserBtn;
    }
}