namespace clock
{
    partial class Form1
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
            this.dayofweek = new System.Windows.Forms.Label();
            this.seconds = new System.Windows.Forms.Label();
            this.hourMin = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dayofweek
            // 
            this.dayofweek.AutoSize = true;
            this.dayofweek.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dayofweek.Font = new System.Drawing.Font("Old English Text MT", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayofweek.Location = new System.Drawing.Point(19, 184);
            this.dayofweek.Name = "dayofweek";
            this.dayofweek.Size = new System.Drawing.Size(138, 53);
            this.dayofweek.TabIndex = 4;
            this.dayofweek.Text = "22222";
            // 
            // seconds
            // 
            this.seconds.AutoSize = true;
            this.seconds.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.seconds.Font = new System.Drawing.Font("Old English Text MT", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seconds.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.seconds.Location = new System.Drawing.Point(240, 68);
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(60, 45);
            this.seconds.TabIndex = 2;
            this.seconds.Text = "20";
            this.seconds.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.seconds.Click += new System.EventHandler(this.seconds_Click);
            // 
            // hourMin
            // 
            this.hourMin.AutoSize = true;
            this.hourMin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hourMin.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.hourMin.Font = new System.Drawing.Font("Old English Text MT", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourMin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hourMin.Location = new System.Drawing.Point(12, 18);
            this.hourMin.Name = "hourMin";
            this.hourMin.Size = new System.Drawing.Size(231, 95);
            this.hourMin.TabIndex = 0;
            this.hourMin.Text = "22:22";
            this.hourMin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hourMin.Click += new System.EventHandler(this.label1_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.date.Font = new System.Drawing.Font("Old English Text MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(12, 113);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(190, 71);
            this.date.TabIndex = 3;
            this.date.Text = "22222";
            this.date.Click += new System.EventHandler(this.date_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.dayofweek);
            this.Controls.Add(this.date);
            this.Controls.Add(this.seconds);
            this.Controls.Add(this.hourMin);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label dayofweek;
        private System.Windows.Forms.Label seconds;
        private System.Windows.Forms.Label hourMin;
        private System.Windows.Forms.Label date;
    }
}

