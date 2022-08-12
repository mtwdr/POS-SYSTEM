namespace POS_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.languageSelect = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.outcomeLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.password_Input = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.username_Input = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.close_Btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Name = "label4";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS_System.Properties.Resources.circle_dashed_4_512;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.languageSelect);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.outcomeLabel);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.close_Btn);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // languageSelect
            // 
            this.languageSelect.FormattingEnabled = true;
            this.languageSelect.Items.AddRange(new object[] {
            resources.GetString("languageSelect.Items"),
            resources.GetString("languageSelect.Items1")});
            resources.ApplyResources(this.languageSelect, "languageSelect");
            this.languageSelect.Name = "languageSelect";
            this.languageSelect.SelectedIndexChanged += new System.EventHandler(this.languageSelect_SelectedIndexChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // outcomeLabel
            // 
            resources.ApplyResources(this.outcomeLabel, "outcomeLabel");
            this.outcomeLabel.ForeColor = System.Drawing.Color.Red;
            this.outcomeLabel.Name = "outcomeLabel";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.login_Btn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.password_Input);
            this.panel4.Controls.Add(this.pictureBox3);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // password_Input
            // 
            this.password_Input.BackColor = System.Drawing.SystemColors.Window;
            this.password_Input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.password_Input, "password_Input");
            this.password_Input.Name = "password_Input";
            this.password_Input.UseSystemPasswordChar = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::POS_System.Properties.Resources.e374aca61d88b5b794d4a0e2417a0254__1_;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.username_Input);
            this.panel3.Controls.Add(this.pictureBox2);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // username_Input
            // 
            this.username_Input.BackColor = System.Drawing.SystemColors.Window;
            this.username_Input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.username_Input, "username_Input");
            this.username_Input.Name = "username_Input";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::POS_System.Properties.Resources.Sample_User_Icon;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // close_Btn
            // 
            this.close_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_Btn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.close_Btn, "close_Btn");
            this.close_Btn.Name = "close_Btn";
            this.close_Btn.UseVisualStyleBackColor = true;
            this.close_Btn.Click += new System.EventHandler(this.close_Btn_Click);
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label4;
        private Label label2;
        private Button close_Btn;
        private Panel panel4;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox2;
        private Button button1;
        private TextBox password_Input;
        private PictureBox pictureBox3;
        private TextBox username_Input;
        private Label label3;
        private Label outcomeLabel;
        private Label label5;
        private ComboBox languageSelect;
    }
}