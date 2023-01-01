using System;
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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            PhieuNhap newPN = new PhieuNhap();
            newPN.Show();
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            NSXMoi newNSXM = new NSXMoi();
            newNSXM.Show();
        }
    }
}
