namespace Timer
{
    partial class TimeAnalogClock
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Start_Buttn = new System.Windows.Forms.Button();
            this.Stop_Buttn = new System.Windows.Forms.Button();
            this.Clock_PictBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TimerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Clock_PictBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Start_Buttn
            // 
            this.Start_Buttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Start_Buttn.ForeColor = System.Drawing.Color.White;
            this.Start_Buttn.Location = new System.Drawing.Point(12, 315);
            this.Start_Buttn.Name = "Start_Buttn";
            this.Start_Buttn.Size = new System.Drawing.Size(75, 23);
            this.Start_Buttn.TabIndex = 0;
            this.Start_Buttn.Text = "Start";
            this.Start_Buttn.UseVisualStyleBackColor = false;
            this.Start_Buttn.Click += new System.EventHandler(this.Start_Buttn_Click);
            // 
            // Stop_Buttn
            // 
            this.Stop_Buttn.BackColor = System.Drawing.Color.SaddleBrown;
            this.Stop_Buttn.ForeColor = System.Drawing.Color.White;
            this.Stop_Buttn.Location = new System.Drawing.Point(219, 315);
            this.Stop_Buttn.Name = "Stop_Buttn";
            this.Stop_Buttn.Size = new System.Drawing.Size(75, 23);
            this.Stop_Buttn.TabIndex = 1;
            this.Stop_Buttn.Text = "Stop";
            this.Stop_Buttn.UseVisualStyleBackColor = false;
            this.Stop_Buttn.Click += new System.EventHandler(this.Stop_Buttn_Click);
            // 
            // Clock_PictBox
            // 
            this.Clock_PictBox.Location = new System.Drawing.Point(0, 0);
            this.Clock_PictBox.Name = "Clock_PictBox";
            this.Clock_PictBox.Size = new System.Drawing.Size(300, 300);
            this.Clock_PictBox.TabIndex = 2;
            this.Clock_PictBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(118, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Restart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TimerButton
            // 
            this.TimerButton.Location = new System.Drawing.Point(256, 0);
            this.TimerButton.Name = "TimerButton";
            this.TimerButton.Size = new System.Drawing.Size(44, 25);
            this.TimerButton.TabIndex = 4;
            this.TimerButton.Text = "TimerButton";
            this.TimerButton.UseVisualStyleBackColor = true;
            this.TimerButton.Click += new System.EventHandler(this.TimerButton_Click);
            // 
            // TimeAnalogClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 346);
            this.Controls.Add(this.TimerButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Clock_PictBox);
            this.Controls.Add(this.Stop_Buttn);
            this.Controls.Add(this.Start_Buttn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TimeAnalogClock";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Clock_PictBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Start_Buttn;
        private System.Windows.Forms.Button Stop_Buttn;
        private System.Windows.Forms.PictureBox Clock_PictBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button TimerButton;
    }
}

