using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueLine
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Cmbo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                webBrowser1.Navigate(Cmbo.Text);
            }
        }

        private void BtnBck_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void BtnFwrd_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Cmbo.Text);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Text = "BlueLine-" + webBrowser1.Document.Title;
        }
    }
}
