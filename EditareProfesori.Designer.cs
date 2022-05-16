namespace SchoolSoft
{
    partial class EditareProfesori
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
            this.l_Nume = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Surname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_Salary = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Discipline = new System.Windows.Forms.ComboBox();
            this.b_Add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_Profesori = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.b_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Salary)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_Nume
            // 
            this.l_Nume.AutoSize = true;
            this.l_Nume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.l_Nume.Location = new System.Drawing.Point(52, 12);
            this.l_Nume.Name = "l_Nume";
            this.l_Nume.Size = new System.Drawing.Size(72, 24);
            this.l_Nume.TabIndex = 0;
            this.l_Nume.Text = "Nume :";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tb_Name.Location = new System.Drawing.Point(121, 12);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(265, 29);
            this.tb_Name.TabIndex = 1;
            // 
            // tb_Surname
            // 
            this.tb_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tb_Surname.Location = new System.Drawing.Point(121, 47);
            this.tb_Surname.Name = "tb_Surname";
            this.tb_Surname.Size = new System.Drawing.Size(265, 29);
            this.tb_Surname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(26, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prenume :";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.dtp_Date.Location = new System.Drawing.Point(121, 84);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(265, 27);
            this.dtp_Date.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(2, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 39);
            this.label4.TabIndex = 13;
            this.label4.Text = "Data nasterii :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(47, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Salariu :";
            // 
            // nud_Salary
            // 
            this.nud_Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.nud_Salary.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nud_Salary.Location = new System.Drawing.Point(121, 121);
            this.nud_Salary.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_Salary.Name = "nud_Salary";
            this.nud_Salary.Size = new System.Drawing.Size(265, 29);
            this.nud_Salary.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(24, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Disciplina :";
            // 
            // cb_Discipline
            // 
            this.cb_Discipline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Discipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cb_Discipline.FormattingEnabled = true;
            this.cb_Discipline.Location = new System.Drawing.Point(121, 156);
            this.cb_Discipline.Name = "cb_Discipline";
            this.cb_Discipline.Size = new System.Drawing.Size(144, 28);
            this.cb_Discipline.TabIndex = 18;
            // 
            // b_Add
            // 
            this.b_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.b_Add.Location = new System.Drawing.Point(12, 190);
            this.b_Add.Name = "b_Add";
            this.b_Add.Size = new System.Drawing.Size(188, 28);
            this.b_Add.TabIndex = 19;
            this.b_Add.Text = "Adauga Profesorul";
            this.b_Add.UseVisualStyleBackColor = true;
            this.b_Add.Click += new System.EventHandler(this.b_Add_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.b_Delete);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cb_Profesori);
            this.panel1.Location = new System.Drawing.Point(12, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 47);
            this.panel1.TabIndex = 20;
            // 
            // cb_Profesori
            // 
            this.cb_Profesori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Profesori.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cb_Profesori.FormattingEnabled = true;
            this.cb_Profesori.Location = new System.Drawing.Point(99, 8);
            this.cb_Profesori.Name = "cb_Profesori";
            this.cb_Profesori.Size = new System.Drawing.Size(144, 28);
            this.cb_Profesori.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(3, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Profesor :";
            // 
            // b_Delete
            // 
            this.b_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.b_Delete.Location = new System.Drawing.Point(249, 8);
            this.b_Delete.Name = "b_Delete";
            this.b_Delete.Size = new System.Drawing.Size(179, 28);
            this.b_Delete.TabIndex = 21;
            this.b_Delete.Text = "Sterge Profesorul";
            this.b_Delete.UseVisualStyleBackColor = true;
            this.b_Delete.Click += new System.EventHandler(this.b_Delete_Click);
            // 
            // EditareProfesori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 345);
            this.Controls.Add(this.b_Add);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cb_Discipline);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nud_Salary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Surname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.l_Nume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EditareProfesori";
            this.Text = "EditareProfesori";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditareProfesori_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Salary)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_Nume;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Surname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_Salary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_Discipline;
        private System.Windows.Forms.Button b_Add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_Delete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_Profesori;
    }
}