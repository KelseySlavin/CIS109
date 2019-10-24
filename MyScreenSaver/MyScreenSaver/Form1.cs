using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyScreenSaver
{
    public partial class FormScreenSaver : Form
    {
        public FormScreenSaver()
        {
            InitializeComponent();
        }

        private void FormScreenSaver_Load(object sender, EventArgs e)
        {

        }

        private void FormScreenSaver_KeyDown(object sender, KeyEventArgs e)
        {
            Close();
        }
    }
}
