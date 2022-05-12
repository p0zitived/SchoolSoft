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
            this.SuspendLayout();
            // 
            // tv_school
            // 
            this.tv_school.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.fl_Disciplines.Size = new System.Drawing.Size(617, 153);
            this.fl_Disciplines.TabIndex = 6;
            // 
            // l_Title
            // 
            this.l_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.l_Title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_Title.Location = new System.Drawing.Point(2, 0);
            this.l_Title.Name = "l_Title";
            this.l_Title.Size = new System.Drawing.Size(927, 43);
            this.l_Title.TabIndex = 7;
            this.l_Title.Text = "Catalog";
            this.l_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rt_Marks
            // 
            this.rt_Marks.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rt_Marks.Location = new System.Drawing.Point(312, 205);
            this.rt_Marks.Name = "rt_Marks";
            this.rt_Marks.Size = new System.Drawing.Size(617, 250);
            this.rt_Marks.TabIndex = 8;
            this.rt_Marks.Text = "";
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.rt_Marks);
            this.Controls.Add(this.l_Title);
            this.Controls.Add(this.fl_Disciplines);
            this.Controls.Add(this.tv_school);
            this.Name = "CatalogForm";
            this.Text = "CatalogForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tv_school;
        private System.Windows.Forms.FlowLayoutPanel fl_Disciplines;
        private System.Windows.Forms.Label l_Title;
        private System.Windows.Forms.RichTextBox rt_Marks;
    }
}