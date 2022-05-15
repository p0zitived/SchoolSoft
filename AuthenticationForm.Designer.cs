namespace SchoolSoft
{
    partial class AuthenticationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.b_Enter = new System.Windows.Forms.Button();
            this.b_Register = new System.Windows.Forms.Button();
            this.b_Forgot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(12, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(12, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // tb_Login
            // 
            this.tb_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.tb_Login.Location = new System.Drawing.Point(18, 210);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(432, 35);
            this.tb_Login.TabIndex = 2;
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.tb_Password.Location = new System.Drawing.Point(18, 285);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(432, 35);
            this.tb_Password.TabIndex = 3;
            this.tb_Password.UseSystemPasswordChar = true;
            // 
            // b_Enter
            // 
            this.b_Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.b_Enter.Location = new System.Drawing.Point(166, 326);
            this.b_Enter.Name = "b_Enter";
            this.b_Enter.Size = new System.Drawing.Size(136, 57);
            this.b_Enter.TabIndex = 4;
            this.b_Enter.Text = "Enter";
            this.b_Enter.UseVisualStyleBackColor = true;
            this.b_Enter.Click += new System.EventHandler(this.b_Enter_Click);
            // 
            // b_Register
            // 
            this.b_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.b_Register.Location = new System.Drawing.Point(308, 326);
            this.b_Register.Name = "b_Register";
            this.b_Register.Size = new System.Drawing.Size(142, 36);
            this.b_Register.TabIndex = 5;
            this.b_Register.Text = "Register";
            this.b_Register.UseVisualStyleBackColor = true;
            this.b_Register.Click += new System.EventHandler(this.b_Register_Click);
            // 
            // b_Forgot
            // 
            this.b_Forgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.b_Forgot.Location = new System.Drawing.Point(18, 326);
            this.b_Forgot.Name = "b_Forgot";
            this.b_Forgot.Size = new System.Drawing.Size(142, 36);
            this.b_Forgot.TabIndex = 6;
            this.b_Forgot.Text = "Forgot password";
            this.b_Forgot.UseVisualStyleBackColor = true;
            // 
            // AuthenticationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 399);
            this.Controls.Add(this.b_Forgot);
            this.Controls.Add(this.b_Register);
            this.Controls.Add(this.b_Enter);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AuthenticationForm";
            this.Text = "AuthenticationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Login;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button b_Enter;
        private System.Windows.Forms.Button b_Register;
        private System.Windows.Forms.Button b_Forgot;
    }
}