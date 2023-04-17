using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lap2_21521327_GiaQUan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_b1_Click(object sender, EventArgs e)
        {
            bai1 bai1 = new bai1();
            bai1.Show();
        }

        private void bt_bai2_Click(object sender, EventArgs e)
        {
            bai2 bai2 = new bai2();
            bai2.Show();    
        }

        private void bt_bai3_Click(object sender, EventArgs e)
        {
            bai3 bai3 = new bai3();
            bai3.Show();
        }

        private void bt_bai6_Click(object sender, EventArgs e)
        {
            bai5 bai5   = new bai5();
            bai5.Show();
        }

        private void bt_bai4_Click(object sender, EventArgs e)
        {
            bai4 bai4  = new bai4();
            bai4.Show();
        }
    }
}
