namespace SchoolSoft
{
    partial class CatalogForm
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
            this.tv_school = new System.Windows.Forms.TreeView();
            this.fl_Disciplines = new System.Windows.Forms.FlowLayoutPanel();
            this.l_Title = new System.Windows.Forms.Label();
            this.rt_Marks = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.l_Medie = new System.Windows.Forms.Label();
            this.l_Abs = new System.Windows.Forms.Label();
            this.l_MedieAfis = new System.Windows.Forms.Label();
            this.l_AbsAfis = new System.Windows.Forms.Label();
            this.b_Save = new System.Windows.Forms.Button();
            this.l_SelectedStud = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tv_school
            // 
            this.tv_school.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tv_school.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.tv_school.ForeColor = System.Drawing.SystemColors.Menu;
            this.tv_school.Location = new System.Drawing.Point(0, 46);
            this.tv_school.Name = "tv_school";
            this.tv_school.Size = new System.Drawing.Size(307, 473);
            this.tv_school.TabIndex = 0;
            this.tv_school.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_school_AfterSelect);
            // 
            // fl_Disciplines
            // 
            this.fl_Disciplines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fl_Disciplines.AutoScroll = true;
            this.fl_Disciplines.BackColor = System.Drawing.Color.Transparent;
            this.fl_Disciplines.Location = new System.Drawing.Point(312, 46);
            this.fl_Disciplines.Name = "fl_Disciplines";
            this.fl_Disciplines.Size = new System.Drawing.Size(617, 112);
            this.fl_Disciplines.TabIndex = 6;
            // 
            // l_Title
            // 
            this.l_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.l_Title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.l_Title.Location = new System.Drawing.Point(312, 0);
            this.l_Title.Name = "l_Title";
            this.l_Title.Size = new System.Drawing.Size(617, 43);
            this.l_Title.TabIndex = 7;
            this.l_Title.Text = "Catalog";
            this.l_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rt_Marks
            // 
            this.rt_Marks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.rt_Marks.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rt_Marks.ForeColor = System.Drawing.SystemColors.Menu;
            this.rt_Marks.Location = new System.Drawing.Point(312, 205);
            this.rt_Marks.Name = "rt_Marks";
            this.rt_Marks.Size = new System.Drawing.Size(617, 216);
            this.rt_Marks.TabIndex = 8;
            this.rt_Marks.Text = "";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 43);
            this.label1.TabIndex = 9;
            this.label1.Text = "Clasele";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_Medie
            // 
            this.l_Medie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_Medie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.l_Medie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.l_Medie.Location = new System.Drawing.Point(313, 424);
            this.l_Medie.Name = "l_Medie";
            this.l_Medie.Size = new System.Drawing.Size(133, 38);
            this.l_Medie.TabIndex = 10;
            this.l_Medie.Text = "Medie :";
            this.l_Medie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // l_Abs
            // 
            this.l_Abs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_Abs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.l_Abs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.l_Abs.Location = new System.Drawing.Point(313, 462);
            this.l_Abs.Name = "l_Abs";
            this.l_Abs.Size = new System.Drawing.Size(133, 38);
            this.l_Abs.TabIndex = 11;
            this.l_Abs.Text = "Absente :";
            this.l_Abs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // l_MedieAfis
            // 
            this.l_MedieAfis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_MedieAfis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.l_MedieAfis.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.l_MedieAfis.Location = new System.Drawing.Point(452, 424);
            this.l_MedieAfis.Name = "l_MedieAfis";
            this.l_MedieAfis.Size = new System.Drawing.Size(110, 38);
            this.l_MedieAfis.TabIndex = 12;
            this.l_MedieAfis.Text = "-";
            this.l_MedieAfis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // l_AbsAfis
            // 
            this.l_AbsAfis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_AbsAfis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.l_AbsAfis.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.l_AbsAfis.Location = new System.Drawing.Point(452, 462);
            this.l_AbsAfis.Name = "l_AbsAfis";
            this.l_AbsAfis.Size = new System.Drawing.Size(110, 38);
            this.l_AbsAfis.TabIndex = 13;
            this.l_AbsAfis.Text = "-";
            this.l_AbsAfis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // b_Save
            // 
            this.b_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.b_Save.Location = new System.Drawing.Point(771, 455);
            this.b_Save.Name = "b_Save";
            this.b_Save.Size = new System.Drawing.Size(158, 45);
            this.b_Save.TabIndex = 14;
            this.b_Save.Text = "Save";
            this.b_Save.UseVisualStyleBackColor = true;
            this.b_Save.Click += new System.EventHandler(this.b_Save_Click);
            // 
            // l_SelectedStud
            // 
            this.l_SelectedStud.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_SelectedStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.l_SelectedStud.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.l_SelectedStud.Location = new System.Drawing.Point(312, 161);
            this.l_SelectedStud.Name = "l_SelectedStud";
            this.l_SelectedStud.Size = new System.Drawing.Size(617, 43);
            this.l_SelectedStud.TabIndex = 15;
            this.l_SelectedStud.Text = "Selectati un Elev . . .";
            this.l_SelectedStud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.l_SelectedStud);
            this.Controls.Add(this.b_Save);
            this.Controls.Add(this.l_AbsAfis);
            this.Controls.Add(this.l_MedieAfis);
            this.Controls.Add(this.l_Abs);
            this.Controls.Add(this.l_Medie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rt_Marks);
            this.Controls.Add(this.l_Title);
            this.Controls.Add(this.fl_Disciplines);
            this.Controls.Add(this.tv_school);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CatalogForm";
            this.Text = "CatalogForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CatalogForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tv_school;
        private System.Windows.Forms.FlowLayoutPanel fl_Disciplines;
        private System.Windows.Forms.Label l_Title;
        private System.Windows.Forms.RichTextBox rt_Marks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_Medie;
        private System.Windows.Forms.Label l_Abs;
        private System.Windows.Forms.Label l_MedieAfis;
        private System.Windows.Forms.Label l_AbsAfis;
        private System.Windows.Forms.Button b_Save;
        private System.Windows.Forms.Label l_SelectedStud;
    }
}