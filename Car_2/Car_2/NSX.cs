﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_2
{
    public partial class NSX : Form
    {
        public NSX()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            NSXMoi newNSXM = new NSXMoi();
            newNSXM.Show();
        }
    }
}
