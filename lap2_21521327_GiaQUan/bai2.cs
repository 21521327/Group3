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
    public partial class bai2 : Form
    {
        public bai2()
        {
            InitializeComponent();
        }

        private void bt_read_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
            StreamReader read = new StreamReader(fs);
            string str = read.ReadToEnd();
            rtb_mess.Text += str;
            fs.Flush();
            fs.Close();

            txt_name.Text = ofd.FileName;
            txt_url.Text = ofd.SafeFileName;

            int count = str.Length;
            txt_tu.Text = count.ToString();

            string[] line = str.Split('\n');
            int num_line = line.Length;
            txt_dong.Text = num_line.ToString();

            string[] sourse = str.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int num_word = sourse.Length;
            txt_word.Text = num_word.ToString();
        }
    }
}
