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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.b_SwipeToRight = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.b_SwipeToLeft = new System.Windows.Forms.Button();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.button1);
            this.buttonsPanel.Controls.Add(this.button2);
            this.buttonsPanel.Controls.Add(this.button3);
            this.buttonsPanel.Controls.Add(this.button4);
            this.buttonsPanel.Controls.Add(this.button5);
            this.buttonsPanel.Controls.Add(this.button6);
            this.buttonsPanel.Controls.Add(this.button7);
            this.buttonsPanel.Controls.Add(this.button8);
            this.buttonsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.buttonsPanel.Location = new System.Drawing.Point(200, 50);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(6000, 471);
            this.buttonsPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 400);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(409, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(400, 400);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(815, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(400, 400);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1221, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(400, 400);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1627, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(400, 400);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(2033, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(400, 400);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(2439, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(400, 400);
            this.button7.TabIndex = 6;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(2845, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(400, 400);
            this.button8.TabIndex = 7;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // b_SwipeToRight
            // 
            this.b_SwipeToRight.Location = new System.Drawing.Point(697, 12);
            this.b_SwipeToRight.Name = "b_SwipeToRight";
            this.b_SwipeToRight.Size = new System.Drawing.Size(75, 23);
            this.b_SwipeToRight.TabIndex = 1;
            this.b_SwipeToRight.Text = ">>>>";
            this.b_SwipeToRight.UseVisualStyleBackColor = true;
            this.b_SwipeToRight.Click += new System.EventHandler(this.b_SwipeToRight_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // b_SwipeToLeft
            // 
            this.b_SwipeToLeft.Location = new System.Drawing.Point(616, 12);
            this.b_SwipeToLeft.Name = "b_SwipeToLeft";
            this.b_SwipeToLeft.Size = new System.Drawing.Size(75, 23);
            this.b_SwipeToLeft.TabIndex = 2;
            this.b_SwipeToLeft.Text = "<<<<";
            this.b_SwipeToLeft.UseVisualStyleBackColor = true;
            this.b_SwipeToLeft.Click += new System.EventHandler(this.b_SwipeToLeft_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.b_SwipeToLeft);
            this.Controls.Add(this.b_SwipeToRight);
            this.Controls.Add(this.buttonsPanel);
            this.Name = "MainMenuForm";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel buttonsPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button b_SwipeToRight;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button b_SwipeToLeft;
    }
}

