namespace SchoolSoft
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.b_SituatiaCurenta = new System.Windows.Forms.Button();
            this.b_Events = new System.Windows.Forms.Button();
            this.b_Catalog = new System.Windows.Forms.Button();
            this.b_Editare = new System.Windows.Forms.Button();
            this.b_Stats = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.b_SwipeToRight = new System.Windows.Forms.Button();
            this.b_SwipeToLeft = new System.Windows.Forms.Button();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(18)))), ((int)(((byte)(109)))));
            this.buttonsPanel.Controls.Add(this.b_SituatiaCurenta);
            this.buttonsPanel.Controls.Add(this.b_Events);
            this.buttonsPanel.Controls.Add(this.b_Catalog);
            this.buttonsPanel.Controls.Add(this.b_Editare);
            this.buttonsPanel.Controls.Add(this.b_Stats);
            this.buttonsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.buttonsPanel.Location = new System.Drawing.Point(200, 50);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(6000, 471);
            this.buttonsPanel.TabIndex = 0;
            // 
            // b_SituatiaCurenta
            // 
            this.b_SituatiaCurenta.BackgroundImage = global::SchoolSoft.Properties.Resources.SituatiaCurenta;
            this.b_SituatiaCurenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_SituatiaCurenta.Location = new System.Drawing.Point(3, 3);
            this.b_SituatiaCurenta.Name = "b_SituatiaCurenta";
            this.b_SituatiaCurenta.Size = new System.Drawing.Size(400, 400);
            this.b_SituatiaCurenta.TabIndex = 0;
            this.b_SituatiaCurenta.UseVisualStyleBackColor = true;
            this.b_SituatiaCurenta.Click += new System.EventHandler(this.b_SituatiaCurenta_Click);
            // 
            // b_Events
            // 
            this.b_Events.BackgroundImage = global::SchoolSoft.Properties.Resources.Orar;
            this.b_Events.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_Events.Location = new System.Drawing.Point(409, 3);
            this.b_Events.Name = "b_Events";
            this.b_Events.Size = new System.Drawing.Size(400, 400);
            this.b_Events.TabIndex = 1;
            this.b_Events.UseVisualStyleBackColor = true;
            // 
            // b_Catalog
            // 
            this.b_Catalog.BackgroundImage = global::SchoolSoft.Properties.Resources.Catalog;
            this.b_Catalog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_Catalog.Location = new System.Drawing.Point(815, 3);
            this.b_Catalog.Name = "b_Catalog";
            this.b_Catalog.Size = new System.Drawing.Size(400, 400);
            this.b_Catalog.TabIndex = 2;
            this.b_Catalog.UseVisualStyleBackColor = true;
            this.b_Catalog.Click += new System.EventHandler(this.b_Catalog_Click);
            // 
            // b_Editare
            // 
            this.b_Editare.BackgroundImage = global::SchoolSoft.Properties.Resources.EditeazaElevi;
            this.b_Editare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_Editare.Location = new System.Drawing.Point(1221, 3);
            this.b_Editare.Name = "b_Editare";
            this.b_Editare.Size = new System.Drawing.Size(400, 400);
            this.b_Editare.TabIndex = 3;
            this.b_Editare.UseVisualStyleBackColor = true;
            this.b_Editare.Click += new System.EventHandler(this.b_Editare_Click);
            // 
            // b_Stats
            // 
            this.b_Stats.BackgroundImage = global::SchoolSoft.Properties.Resources.TopButton;
            this.b_Stats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_Stats.Location = new System.Drawing.Point(1627, 3);
            this.b_Stats.Name = "b_Stats";
            this.b_Stats.Size = new System.Drawing.Size(400, 400);
            this.b_Stats.TabIndex = 4;
            this.b_Stats.UseVisualStyleBackColor = true;
            this.b_Stats.Click += new System.EventHandler(this.b_Stats_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // b_SwipeToRight
            // 
            this.b_SwipeToRight.BackgroundImage = global::SchoolSoft.Properties.Resources.ArrowRight;
            this.b_SwipeToRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_SwipeToRight.Location = new System.Drawing.Point(623, 164);
            this.b_SwipeToRight.Name = "b_SwipeToRight";
            this.b_SwipeToRight.Size = new System.Drawing.Size(120, 200);
            this.b_SwipeToRight.TabIndex = 1;
            this.b_SwipeToRight.UseVisualStyleBackColor = true;
            this.b_SwipeToRight.Click += new System.EventHandler(this.b_SwipeToRight_Click);
            // 
            // b_SwipeToLeft
            // 
            this.b_SwipeToLeft.BackgroundImage = global::SchoolSoft.Properties.Resources.ArrowLeft;
            this.b_SwipeToLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_SwipeToLeft.Location = new System.Drawing.Point(65, 164);
            this.b_SwipeToLeft.Name = "b_SwipeToLeft";
            this.b_SwipeToLeft.Size = new System.Drawing.Size(120, 200);
            this.b_SwipeToLeft.TabIndex = 2;
            this.b_SwipeToLeft.UseVisualStyleBackColor = true;
            this.b_SwipeToLeft.Click += new System.EventHandler(this.b_SwipeToLeft_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(18)))), ((int)(((byte)(109)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.b_SwipeToRight);
            this.Controls.Add(this.b_SwipeToLeft);
            this.Controls.Add(this.buttonsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuForm_FormClosing);
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel buttonsPanel;
        private System.Windows.Forms.Button b_SituatiaCurenta;
        private System.Windows.Forms.Button b_SwipeToRight;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button b_SwipeToLeft;
        private System.Windows.Forms.Button b_Events;
        private System.Windows.Forms.Button b_Catalog;
        private System.Windows.Forms.Button b_Editare;
        private System.Windows.Forms.Button b_Stats;
    }
}

