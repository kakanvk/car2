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
    public partial class Login : Form
    {
        public static string ID_LEVEL = "";
        public static string ID_STAFF = "";
        public Login()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu newTrangChu = new TrangChu();
            newTrangChu.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
