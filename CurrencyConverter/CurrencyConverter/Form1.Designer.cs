namespace CurrencyConverter
{
    partial class CurrencyConvert
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
            this.BtnCnvrtr = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // BtnCnvrtr
            // 
            this.BtnCnvrtr.BackColor = System.Drawing.Color.Teal;
            this.BtnCnvrtr.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCnvrtr.Location = new System.Drawing.Point(12, 3);
            this.BtnCnvrtr.Name = "BtnCnvrtr";
            this.BtnCnvrtr.Size = new System.Drawing.Size(609, 52);
            this.BtnCnvrtr.TabIndex = 0;
            this.BtnCnvrtr.Text = "Currency Converter";
            this.BtnCnvrtr.UseVisualStyleBackColor = false;
            this.BtnCnvrtr.Click += new System.EventHandler(this.BtnCntrtr_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 61);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(618, 307);
            this.webBrowser1.TabIndex = 1;
            // 
            // CurrencyConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 380);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.BtnCnvrtr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CurrencyConvert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "World Curency Converter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCnvrtr;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

