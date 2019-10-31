namespace BlueLine
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.BtnBck = new System.Windows.Forms.ToolStripButton();
            this.BtnFwrd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Cmbo = new System.Windows.Forms.ToolStripComboBox();
            this.BtnGo = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnBck,
            this.BtnFwrd,
            this.toolStripSeparator1,
            this.Cmbo,
            this.BtnGo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(657, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 28);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(657, 379);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // BtnBck
            // 
            this.BtnBck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnBck.Image = ((System.Drawing.Image)(resources.GetObject("BtnBck.Image")));
            this.BtnBck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnBck.Name = "BtnBck";
            this.BtnBck.Size = new System.Drawing.Size(44, 25);
            this.BtnBck.Text = "Back";
            this.BtnBck.Click += new System.EventHandler(this.BtnBck_Click);
            // 
            // BtnFwrd
            // 
            this.BtnFwrd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnFwrd.Image = ((System.Drawing.Image)(resources.GetObject("BtnFwrd.Image")));
            this.BtnFwrd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnFwrd.Name = "BtnFwrd";
            this.BtnFwrd.Size = new System.Drawing.Size(67, 25);
            this.BtnFwrd.Text = "Forward";
            this.BtnFwrd.Click += new System.EventHandler(this.BtnFwrd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // Cmbo
            // 
            this.Cmbo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.Cmbo.Name = "Cmbo";
            this.Cmbo.Size = new System.Drawing.Size(121, 28);
            this.Cmbo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmbo_KeyDown);
            // 
            // BtnGo
            // 
            this.BtnGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnGo.Image = ((System.Drawing.Image)(resources.GetObject("BtnGo.Image")));
            this.BtnGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(32, 25);
            this.BtnGo.Text = "Go";
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 407);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmMain";
            this.Text = "Blue Line";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnBck;
        private System.Windows.Forms.ToolStripButton BtnFwrd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox Cmbo;
        private System.Windows.Forms.ToolStripButton BtnGo;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

