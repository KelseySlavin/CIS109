namespace Clock_day
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
            this.hourMinute = new System.Windows.Forms.Label();
            this.secondLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.WeekdayLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // hourMinute
            // 
            this.hourMinute.Font = new System.Drawing.Font("Segoe Print", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourMinute.ForeColor = System.Drawing.Color.Turquoise;
            this.hourMinute.Location = new System.Drawing.Point(25, 24);
            this.hourMinute.Name = "hourMinute";
            this.hourMinute.Size = new System.Drawing.Size(437, 197);
            this.hourMinute.TabIndex = 0;
            this.hourMinute.Text = "19:25";
            // 
            // secondLabel
            // 
            this.secondLabel.Font = new System.Drawing.Font("Segoe Print", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondLabel.ForeColor = System.Drawing.Color.Turquoise;
            this.secondLabel.Location = new System.Drawing.Point(377, 24);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(437, 197);
            this.secondLabel.TabIndex = 1;
            this.secondLabel.Text = "24";
            // 
            // DateLabel
            // 
            this.DateLabel.Font = new System.Drawing.Font("Segoe Print", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.Turquoise;
            this.DateLabel.Location = new System.Drawing.Point(25, 163);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(789, 158);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "Nov 6 2019";
            // 
            // WeekdayLabel
            // 
            this.WeekdayLabel.Font = new System.Drawing.Font("Segoe Print", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekdayLabel.ForeColor = System.Drawing.Color.Turquoise;
            this.WeekdayLabel.Location = new System.Drawing.Point(25, 321);
            this.WeekdayLabel.Name = "WeekdayLabel";
            this.WeekdayLabel.Size = new System.Drawing.Size(737, 158);
            this.WeekdayLabel.TabIndex = 3;
            this.WeekdayLabel.Text = "Wednesday";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(851, 516);
            this.Controls.Add(this.WeekdayLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.hourMinute);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label hourMinute;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label WeekdayLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

