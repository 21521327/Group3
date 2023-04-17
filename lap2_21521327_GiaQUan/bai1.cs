using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lap2_21521327_GiaQUan
{
    public partial class bai1 : Form
    {
        public bai1()
        {
            InitializeComponent();
        }

        private void bt_read_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
            StreamReader read = new StreamReader(fs);
            var str = read.ReadToEnd();
            rtb_mess.Text += "/n" + str.ToUpper();
            bt_write.Enabled = false;
            fs.Flush();
            fs.Close();
        }

        private void bt_chuyen_Click(object sender, EventArgs e)
        {
            if (bt_write.Enabled == true)
            {
                bt_chuyen.Text = " Change Write ";
                bt_write.Enabled = false;
                bt_read.Enabled = true;
                rtb_mess.Text = "";
            }
            else
            {
                bt_chuyen.Text = " Change Read ";
                bt_write.Enabled = true;
                bt_read.Enabled = false;
                rtb_mess.Text = "";
            }
        }

        private void bt_write_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            StreamWriter write = new StreamWriter(ofd.FileName) ;
            write.Write(rtb_mess.Text);
            write.Close();
            bt_read.Enabled = false;
            rtb_mess.Text = "";
            MessageBox.Show("Đã Ghi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
