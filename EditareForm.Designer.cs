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
            this.SuspendLayout();
            // 
            // l_title
            // 
            this.l_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
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
            this.tv_school.Location = new System.Drawing.Point(-4, 34);
            this.tv_school.Name = "tv_school";
            this.tv_school.Size = new System.Drawing.Size(309, 462);
            this.tv_school.TabIndex = 1;
            this.tv_school.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_school_AfterSelect);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(311, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nume";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(311, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prenume";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(311, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data nasterii :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(311, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 39);
            this.label4.TabIndex = 5;
            this.label4.Text = "Grupa";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tb_Name.Location = new System.Drawing.Point(437, 82);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(132, 27);
            this.tb_Name.TabIndex = 6;
            // 
            // tb_Surname
            // 
            this.tb_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tb_Surname.Location = new System.Drawing.Point(437, 115);
            this.tb_Surname.Name = "tb_Surname";
            this.tb_Surname.Size = new System.Drawing.Size(132, 27);
            this.tb_Surname.TabIndex = 7;
            // 
            // cb_Grupa
            // 
            this.cb_Grupa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Grupa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cb_Grupa.FormattingEnabled = true;
            this.cb_Grupa.Location = new System.Drawing.Point(437, 181);
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
            this.dtp_Date.Location = new System.Drawing.Point(437, 148);
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
            // EditareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 496);
            this.Controls.Add(this.b_Add);
            this.Controls.Add(this.b_Deselect);
            this.Controls.Add(this.l_SelectedStud);
            this.Controls.Add(this.b_Save);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.b_Exmatriculeaza);
            this.Controls.Add(this.cb_Grupa);
            this.Controls.Add(this.tb_Surname);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tv_school);
            this.Controls.Add(this.l_title);
            this.Name = "EditareForm";
            this.Text = "EditareForm";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}