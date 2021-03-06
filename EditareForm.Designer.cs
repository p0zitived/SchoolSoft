namespace SchoolSoft
{
    partial class EditareForm
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
            this.l_title = new System.Windows.Forms.Label();
            this.tv_school = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Surname = new System.Windows.Forms.TextBox();
            this.cb_Grupa = new System.Windows.Forms.ComboBox();
            this.b_Exmatriculeaza = new System.Windows.Forms.Button();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.b_Save = new System.Windows.Forms.Button();
            this.l_SelectedStud = new System.Windows.Forms.Label();
            this.b_Deselect = new System.Windows.Forms.Button();
            this.b_Add = new System.Windows.Forms.Button();
            this.b_CreateGroup = new System.Windows.Forms.Button();
            this.cb_Letter = new System.Windows.Forms.ComboBox();
            this.l_Letter = new System.Windows.Forms.Label();
            this.cb_Year = new System.Windows.Forms.ComboBox();
            this.l_Year = new System.Windows.Forms.Label();
            this.b_Create = new System.Windows.Forms.Button();
            this.cb_Teachers = new System.Windows.Forms.ComboBox();
            this.l_Teacher = new System.Windows.Forms.Label();
            this.b_Profesori = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_DeleteGroup = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_GroupToDelete = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_title
            // 
            this.l_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.l_title.ForeColor = System.Drawing.Color.White;
            this.l_title.Location = new System.Drawing.Point(-1, -2);
            this.l_title.Name = "l_title";
            this.l_title.Size = new System.Drawing.Size(912, 39);
            this.l_title.TabIndex = 0;
            this.l_title.Text = "Editare Date Elevi";
            this.l_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tv_school
            // 
            this.tv_school.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tv_school.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(118)))), ((int)(((byte)(53)))));
            this.tv_school.ForeColor = System.Drawing.Color.White;
            this.tv_school.Location = new System.Drawing.Point(-4, 34);
            this.tv_school.Name = "tv_school";
            this.tv_school.Size = new System.Drawing.Size(309, 462);
            this.tv_school.TabIndex = 1;
            this.tv_school.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_school_AfterSelect);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nume";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prenume";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data nasterii :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 39);
            this.label4.TabIndex = 5;
            this.label4.Text = "Grupa";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tb_Name.Location = new System.Drawing.Point(136, 23);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(132, 27);
            this.tb_Name.TabIndex = 6;
            // 
            // tb_Surname
            // 
            this.tb_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tb_Surname.Location = new System.Drawing.Point(136, 56);
            this.tb_Surname.Name = "tb_Surname";
            this.tb_Surname.Size = new System.Drawing.Size(132, 27);
            this.tb_Surname.TabIndex = 7;
            // 
            // cb_Grupa
            // 
            this.cb_Grupa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Grupa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cb_Grupa.FormattingEnabled = true;
            this.cb_Grupa.Location = new System.Drawing.Point(136, 122);
            this.cb_Grupa.Name = "cb_Grupa";
            this.cb_Grupa.Size = new System.Drawing.Size(132, 28);
            this.cb_Grupa.TabIndex = 9;
            // 
            // b_Exmatriculeaza
            // 
            this.b_Exmatriculeaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.b_Exmatriculeaza.Location = new System.Drawing.Point(752, 456);
            this.b_Exmatriculeaza.Name = "b_Exmatriculeaza";
            this.b_Exmatriculeaza.Size = new System.Drawing.Size(143, 28);
            this.b_Exmatriculeaza.TabIndex = 11;
            this.b_Exmatriculeaza.Text = "Exmatriculeaza";
            this.b_Exmatriculeaza.UseVisualStyleBackColor = true;
            this.b_Exmatriculeaza.Click += new System.EventHandler(this.b_Exmatriculeaza_Click);
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.dtp_Date.Location = new System.Drawing.Point(136, 89);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(281, 27);
            this.dtp_Date.TabIndex = 12;
            // 
            // b_Save
            // 
            this.b_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.b_Save.Location = new System.Drawing.Point(316, 456);
            this.b_Save.Name = "b_Save";
            this.b_Save.Size = new System.Drawing.Size(143, 28);
            this.b_Save.TabIndex = 13;
            this.b_Save.Text = "Salveaza";
            this.b_Save.UseVisualStyleBackColor = true;
            this.b_Save.Click += new System.EventHandler(this.b_Save_Click);
            // 
            // l_SelectedStud
            // 
            this.l_SelectedStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.l_SelectedStud.Location = new System.Drawing.Point(316, 40);
            this.l_SelectedStud.Name = "l_SelectedStud";
            this.l_SelectedStud.Size = new System.Drawing.Size(579, 39);
            this.l_SelectedStud.TabIndex = 14;
            this.l_SelectedStud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_Deselect
            // 
            this.b_Deselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.b_Deselect.Location = new System.Drawing.Point(752, 40);
            this.b_Deselect.Name = "b_Deselect";
            this.b_Deselect.Size = new System.Drawing.Size(143, 28);
            this.b_Deselect.TabIndex = 15;
            this.b_Deselect.Text = "Deselecteaza";
            this.b_Deselect.UseVisualStyleBackColor = true;
            this.b_Deselect.Click += new System.EventHandler(this.b_Deselect_Click);
            // 
            // b_Add
            // 
            this.b_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.b_Add.Location = new System.Drawing.Point(752, 74);
            this.b_Add.Name = "b_Add";
            this.b_Add.Size = new System.Drawing.Size(143, 28);
            this.b_Add.TabIndex = 16;
            this.b_Add.Text = "Adauga Elev Nou";
            this.b_Add.UseVisualStyleBackColor = true;
            this.b_Add.Click += new System.EventHandler(this.b_Add_Click);
            // 
            // b_CreateGroup
            // 
            this.b_CreateGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.b_CreateGroup.Location = new System.Drawing.Point(274, 122);
            this.b_CreateGroup.Name = "b_CreateGroup";
            this.b_CreateGroup.Size = new System.Drawing.Size(143, 28);
            this.b_CreateGroup.TabIndex = 17;
            this.b_CreateGroup.Text = "Creaza una noua";
            this.b_CreateGroup.UseVisualStyleBackColor = true;
            this.b_CreateGroup.Click += new System.EventHandler(this.b_CreateGroup_Click);
            // 
            // cb_Letter
            // 
            this.cb_Letter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Letter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cb_Letter.FormattingEnabled = true;
            this.cb_Letter.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "I",
            "U",
            "V",
            "W",
            "X",
            "Y"});
            this.cb_Letter.Location = new System.Drawing.Point(689, 249);
            this.cb_Letter.Name = "cb_Letter";
            this.cb_Letter.Size = new System.Drawing.Size(139, 28);
            this.cb_Letter.TabIndex = 21;
            // 
            // l_Letter
            // 
            this.l_Letter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.l_Letter.ForeColor = System.Drawing.Color.White;
            this.l_Letter.Location = new System.Drawing.Point(609, 249);
            this.l_Letter.Name = "l_Letter";
            this.l_Letter.Size = new System.Drawing.Size(74, 28);
            this.l_Letter.TabIndex = 20;
            this.l_Letter.Text = "Litera :";
            // 
            // cb_Year
            // 
            this.cb_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cb_Year.FormattingEnabled = true;
            this.cb_Year.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cb_Year.Location = new System.Drawing.Point(689, 215);
            this.cb_Year.Name = "cb_Year";
            this.cb_Year.Size = new System.Drawing.Size(139, 28);
            this.cb_Year.TabIndex = 19;
            // 
            // l_Year
            // 
            this.l_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.l_Year.ForeColor = System.Drawing.Color.White;
            this.l_Year.Location = new System.Drawing.Point(618, 215);
            this.l_Year.Name = "l_Year";
            this.l_Year.Size = new System.Drawing.Size(65, 31);
            this.l_Year.TabIndex = 18;
            this.l_Year.Text = "Anul :";
            // 
            // b_Create
            // 
            this.b_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.b_Create.Location = new System.Drawing.Point(689, 315);
            this.b_Create.Name = "b_Create";
            this.b_Create.Size = new System.Drawing.Size(139, 28);
            this.b_Create.TabIndex = 22;
            this.b_Create.Text = "Creaza";
            this.b_Create.UseVisualStyleBackColor = true;
            this.b_Create.Click += new System.EventHandler(this.b_Create_Click);
            // 
            // cb_Teachers
            // 
            this.cb_Teachers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Teachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cb_Teachers.FormattingEnabled = true;
            this.cb_Teachers.Location = new System.Drawing.Point(689, 281);
            this.cb_Teachers.Name = "cb_Teachers";
            this.cb_Teachers.Size = new System.Drawing.Size(139, 28);
            this.cb_Teachers.TabIndex = 24;
            // 
            // l_Teacher
            // 
            this.l_Teacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.l_Teacher.ForeColor = System.Drawing.Color.White;
            this.l_Teacher.Location = new System.Drawing.Point(584, 281);
            this.l_Teacher.Name = "l_Teacher";
            this.l_Teacher.Size = new System.Drawing.Size(108, 28);
            this.l_Teacher.TabIndex = 23;
            this.l_Teacher.Text = "Profesor :";
            // 
            // b_Profesori
            // 
            this.b_Profesori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.b_Profesori.Location = new System.Drawing.Point(316, 422);
            this.b_Profesori.Name = "b_Profesori";
            this.b_Profesori.Size = new System.Drawing.Size(143, 28);
            this.b_Profesori.TabIndex = 25;
            this.b_Profesori.Text = "Profesori";
            this.b_Profesori.UseVisualStyleBackColor = true;
            this.b_Profesori.Click += new System.EventHandler(this.b_Profesori_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(118)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.b_DeleteGroup);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cb_GroupToDelete);
            this.panel1.Location = new System.Drawing.Point(316, 369);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 47);
            this.panel1.TabIndex = 26;
            // 
            // b_DeleteGroup
            // 
            this.b_DeleteGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.b_DeleteGroup.Location = new System.Drawing.Point(249, 8);
            this.b_DeleteGroup.Name = "b_DeleteGroup";
            this.b_DeleteGroup.Size = new System.Drawing.Size(179, 28);
            this.b_DeleteGroup.TabIndex = 21;
            this.b_DeleteGroup.Text = "Sterge Grupa";
            this.b_DeleteGroup.UseVisualStyleBackColor = true;
            this.b_DeleteGroup.Click += new System.EventHandler(this.b_DeleteGroup_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Grupa :";
            // 
            // cb_GroupToDelete
            // 
            this.cb_GroupToDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_GroupToDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cb_GroupToDelete.FormattingEnabled = true;
            this.cb_GroupToDelete.Location = new System.Drawing.Point(81, 8);
            this.cb_GroupToDelete.Name = "cb_GroupToDelete";
            this.cb_GroupToDelete.Size = new System.Drawing.Size(162, 28);
            this.cb_GroupToDelete.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(118)))), ((int)(((byte)(53)))));
            this.panel2.Controls.Add(this.tb_Name);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tb_Surname);
            this.panel2.Controls.Add(this.cb_Grupa);
            this.panel2.Controls.Add(this.dtp_Date);
            this.panel2.Controls.Add(this.b_CreateGroup);
            this.panel2.Location = new System.Drawing.Point(316, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 170);
            this.panel2.TabIndex = 27;
            // 
            // EditareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(137)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(907, 496);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.b_Profesori);
            this.Controls.Add(this.cb_Teachers);
            this.Controls.Add(this.l_Teacher);
            this.Controls.Add(this.b_Create);
            this.Controls.Add(this.cb_Letter);
            this.Controls.Add(this.l_Letter);
            this.Controls.Add(this.cb_Year);
            this.Controls.Add(this.l_Year);
            this.Controls.Add(this.b_Add);
            this.Controls.Add(this.b_Deselect);
            this.Controls.Add(this.l_SelectedStud);
            this.Controls.Add(this.b_Save);
            this.Controls.Add(this.b_Exmatriculeaza);
            this.Controls.Add(this.tv_school);
            this.Controls.Add(this.l_title);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EditareForm";
            this.Text = "EditareForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditareForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label l_title;
        private System.Windows.Forms.TreeView tv_school;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Surname;
        private System.Windows.Forms.ComboBox cb_Grupa;
        private System.Windows.Forms.Button b_Exmatriculeaza;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Button b_Save;
        private System.Windows.Forms.Label l_SelectedStud;
        private System.Windows.Forms.Button b_Deselect;
        private System.Windows.Forms.Button b_Add;
        private System.Windows.Forms.Button b_CreateGroup;
        private System.Windows.Forms.ComboBox cb_Letter;
        private System.Windows.Forms.Label l_Letter;
        private System.Windows.Forms.ComboBox cb_Year;
        private System.Windows.Forms.Label l_Year;
        private System.Windows.Forms.Button b_Create;
        private System.Windows.Forms.ComboBox cb_Teachers;
        private System.Windows.Forms.Label l_Teacher;
        private System.Windows.Forms.Button b_Profesori;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_DeleteGroup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_GroupToDelete;
        private System.Windows.Forms.Panel panel2;
    }
}