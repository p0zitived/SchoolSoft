namespace SchoolSoft
{
    partial class RegisterForm
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
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Code = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.b_Register = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.tb_Password.Location = new System.Drawing.Point(63, 121);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(387, 35);
            this.tb_Password.TabIndex = 7;
            this.tb_Password.UseSystemPasswordChar = true;
            // 
            // tb_Login
            // 
            this.tb_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.tb_Login.Location = new System.Drawing.Point(63, 46);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(387, 35);
            this.tb_Login.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century", 17F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password :";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century", 17F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login :";
            // 
            // tb_Email
            // 
            this.tb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.tb_Email.Location = new System.Drawing.Point(63, 196);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(248, 35);
            this.tb_Email.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century", 17F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 34);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email :";
            // 
            // tb_Code
            // 
            this.tb_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.tb_Code.Location = new System.Drawing.Point(63, 271);
            this.tb_Code.Name = "tb_Code";
            this.tb_Code.Size = new System.Drawing.Size(238, 35);
            this.tb_Code.TabIndex = 11;
            this.tb_Code.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century", 17F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(13, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 34);
            this.label4.TabIndex = 10;
            this.label4.Text = "SecretCode :";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(317, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 34);
            this.label5.TabIndex = 12;
            this.label5.Text = "@gmail.com";
            // 
            // b_Register
            // 
            this.b_Register.Font = new System.Drawing.Font("Century", 17F, System.Drawing.FontStyle.Bold);
            this.b_Register.Location = new System.Drawing.Point(149, 324);
            this.b_Register.Name = "b_Register";
            this.b_Register.Size = new System.Drawing.Size(196, 57);
            this.b_Register.TabIndex = 13;
            this.b_Register.Text = "Register";
            this.b_Register.UseVisualStyleBackColor = true;
            this.b_Register.Click += new System.EventHandler(this.b_Register_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::SchoolSoft.Properties.Resources.EmailIconWhite;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(18, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(42, 36);
            this.panel2.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SchoolSoft.Properties.Resources.LockIconWhite;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(18, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(42, 36);
            this.panel1.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::SchoolSoft.Properties.Resources.UserIconWhite;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(18, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(42, 36);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::SchoolSoft.Properties.Resources.SecretCodeIcon;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(18, 270);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(42, 36);
            this.panel4.TabIndex = 17;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(495, 393);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.b_Register);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_Code);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Code;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button b_Register;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
    }
}