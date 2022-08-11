namespace POS_System.Forms
{
    partial class CreateClient
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.telephoneInput = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.companyInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstnameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lastnameInput = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneInput)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.createBtn);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 500);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.telephoneInput);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.emailInput);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.addressInput);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.companyInput);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.firstnameInput);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lastnameInput);
            this.panel2.Location = new System.Drawing.Point(12, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 394);
            this.panel2.TabIndex = 9;
            // 
            // telephoneInput
            // 
            this.telephoneInput.InterceptArrowKeys = false;
            this.telephoneInput.Location = new System.Drawing.Point(106, 125);
            this.telephoneInput.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.telephoneInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.telephoneInput.Name = "telephoneInput";
            this.telephoneInput.Size = new System.Drawing.Size(256, 23);
            this.telephoneInput.TabIndex = 20;
            this.telephoneInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(44, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Email";
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(105, 153);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(257, 23);
            this.emailInput.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(7, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Telephone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Address";
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(105, 95);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(257, 23);
            this.addressInput.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(7, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Company";
            // 
            // companyInput
            // 
            this.companyInput.Location = new System.Drawing.Point(105, 67);
            this.companyInput.Name = "companyInput";
            this.companyInput.Size = new System.Drawing.Size(257, 23);
            this.companyInput.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name";
            // 
            // firstnameInput
            // 
            this.firstnameInput.Location = new System.Drawing.Point(105, 38);
            this.firstnameInput.Name = "firstnameInput";
            this.firstnameInput.Size = new System.Drawing.Size(257, 23);
            this.firstnameInput.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Last Name";
            // 
            // lastnameInput
            // 
            this.lastnameInput.Location = new System.Drawing.Point(105, 9);
            this.lastnameInput.Name = "lastnameInput";
            this.lastnameInput.Size = new System.Drawing.Size(257, 23);
            this.lastnameInput.TabIndex = 0;
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
            // CreateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(409, 500);
            this.Name = "CreateClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateClient";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button createBtn;
        private Button backBtn;
        private Panel panel2;
        private Label label1;
        private TextBox lastnameInput;
        private Label label6;
        private TextBox emailInput;
        private Label label5;
        private Label label4;
        private TextBox addressInput;
        private Label label3;
        private TextBox companyInput;
        private Label label2;
        private TextBox firstnameInput;
        private NumericUpDown telephoneInput;
    }
}