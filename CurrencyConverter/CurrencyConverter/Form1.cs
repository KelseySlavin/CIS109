﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class CurrencyConvert : Form
    {
        public CurrencyConvert()
        {
            InitializeComponent();
        }

        private void BtnCntrtr_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.foreignexchangeresource.com/currency-converter.php?c=CAD&a=USD&amt=1&panel=1&button=2");
        }
    }
}
