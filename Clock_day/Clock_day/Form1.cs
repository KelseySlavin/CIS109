using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock_day
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hourMinute.Text = DateTime.Now.ToString("HH:mm");
            secondLabel.Text = DateTime.Now.ToString("ss");
            DateLabel.Text = DateTime.Now.ToString("MMM:dd:yyyy");
            WeekdayLabel.Text = DateTime.Now.ToString("dddd");


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
