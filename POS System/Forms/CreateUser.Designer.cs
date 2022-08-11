namespace POS_System.Forms
{
    partial class CreateUser
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.IDInput = new System.Windows.Forms.NumericUpDown();
            this.outcomeLabel = new System.Windows.Forms.Label();
            this.usertypeInput = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.firstnameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastnameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.createBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDInput)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.IDInput);
            this.panel2.Controls.Add(this.outcomeLabel);
            this.panel2.Controls.Add(this.usertypeInput);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.passwordInput);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.firstnameInput);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lastnameInput);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 394);
            this.panel2.TabIndex = 9;
            // 
            // IDInput
            // 
            this.IDInput.InterceptArrowKeys = false;
            this.IDInput.Location = new System.Drawing.Point(117, 9);
            this.IDInput.Maximum = new decimal(new int[] {
            599,
            0,
            0,
            0});
            this.IDInput.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.IDInput.Name = "IDInput";
            this.IDInput.Size = new System.Drawing.Size(256, 23);
            this.IDInput.TabIndex = 19;
            this.IDInput.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // outcomeLabel
            // 
            this.outcomeLabel.AutoSize = true;
            this.outcomeLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.outcomeLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outcomeLabel.ForeColor = System.Drawing.Color.Red;
            this.outcomeLabel.Location = new System.Drawing.Point(0, 377);
            this.outcomeLabel.Name = "outcomeLabel";
            this.outcomeLabel.Size = new System.Drawing.Size(0, 17);
            this.outcomeLabel.TabIndex = 18;
            // 
            // usertypeInput
            // 
            this.usertypeInput.DisplayMember = "Manager";
            this.usertypeInput.FormattingEnabled = true;
            this.usertypeInput.Items.AddRange(new object[] {
            "Manager",
            "Customer Service",
            "Cashier",
            "Clerk"});
            this.usertypeInput.Location = new System.Drawing.Point(116, 125);
            this.usertypeInput.Name = "usertypeInput";
            this.usertypeInput.Size = new System.Drawing.Size(257, 23);
            this.usertypeInput.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(32, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "User Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(34, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Password";
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(117, 95);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(257, 23);
            this.passwordInput.TabIndex = 11;
            this.passwordInput.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "First Name";
            // 
            // firstnameInput
            // 
            this.firstnameInput.Location = new System.Drawing.Point(117, 67);
            this.firstnameInput.Name = "firstnameInput";
            this.firstnameInput.Size = new System.Drawing.Size(257, 23);
            this.firstnameInput.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name";
            // 
            // lastnameInput
            // 
            this.lastnameInput.Location = new System.Drawing.Point(117, 38);
            this.lastnameInput.Name = "lastnameInput";
            this.lastnameInput.Size = new System.Drawing.Size(257, 23);
            this.lastnameInput.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.createBtn);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 496);
            this.panel1.TabIndex = 4;
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.createBtn.Location = new System.Drawing.Point(293, 453);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(95, 35);
            this.createBtn.TabIndex = 8;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(95, 35);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(409, 500);
            this.Name = "CreateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateUser";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDInput)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Label label6;
        private Label label4;
        private TextBox passwordInput;
        private Label label3;
        private TextBox firstnameInput;
        private Label label2;
        private TextBox lastnameInput;
        private Label label1;
        private Panel panel1;
        private Button createBtn;
        private Button backBtn;
        private ComboBox usertypeInput;
        private Label outcomeLabel;
        private NumericUpDown IDInput;
    }
}