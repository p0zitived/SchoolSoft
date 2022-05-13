namespace SchoolSoft
{
    partial class StudentStats
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
            this.fl_restantieri = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fl_eminenti = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.fl_medie = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.fl_grupe = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // fl_restantieri
            // 
            this.fl_restantieri.AutoScroll = true;
            this.fl_restantieri.Location = new System.Drawing.Point(2, 41);
            this.fl_restantieri.Name = "fl_restantieri";
            this.fl_restantieri.Size = new System.Drawing.Size(315, 695);
            this.fl_restantieri.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Top Restantieri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label2.Location = new System.Drawing.Point(389, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Top Eminenti";
            // 
            // fl_eminenti
            // 
            this.fl_eminenti.AutoScroll = true;
            this.fl_eminenti.Location = new System.Drawing.Point(323, 41);
            this.fl_eminenti.Name = "fl_eminenti";
            this.fl_eminenti.Size = new System.Drawing.Size(313, 695);
            this.fl_eminenti.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label3.Location = new System.Drawing.Point(645, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Medie > 8.5 , Absente < 40";
            // 
            // fl_medie
            // 
            this.fl_medie.AutoScroll = true;
            this.fl_medie.Location = new System.Drawing.Point(641, 41);
            this.fl_medie.Name = "fl_medie";
            this.fl_medie.Size = new System.Drawing.Size(317, 695);
            this.fl_medie.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label4.Location = new System.Drawing.Point(998, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Top Grupe (Absente)";
            // 
            // fl_grupe
            // 
            this.fl_grupe.AutoScroll = true;
            this.fl_grupe.Location = new System.Drawing.Point(959, 41);
            this.fl_grupe.Name = "fl_grupe";
            this.fl_grupe.Size = new System.Drawing.Size(317, 695);
            this.fl_grupe.TabIndex = 6;
            // 
            // StudentStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 810);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fl_grupe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fl_medie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fl_eminenti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fl_restantieri);
            this.Name = "StudentStats";
            this.Text = "StudentStats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fl_restantieri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel fl_eminenti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel fl_medie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel fl_grupe;
    }
}