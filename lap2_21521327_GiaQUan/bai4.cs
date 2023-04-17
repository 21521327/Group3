using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lap2_21521327_GiaQUan
{
    public partial class bai4 : Form
    {
        List<string> list = new List<string>();
        int dem = 0;
        public bai4()
        {
            InitializeComponent();
        }

        void nhap(BinaryWriter br, List<string> list)
        {

            //br.Write(Encoding.UTF8.GetBytes("\n"));
            float avg = ((float.Parse(txt_1.Text) + float.Parse(txt_2.Text) + float.Parse(txt_3.Text))) / 3.0f;

            list.Add(txt_name.Text);
            list.Add(txt_id.Text);
            list.Add(txt_phone.Text);
            list.Add(float.Parse(txt_1.Text).ToString());
            list.Add(float.Parse(txt_2.Text).ToString());
            list.Add(float.Parse(txt_3.Text).ToString());
            list.Add(avg.ToString());

            for (int i = 0; i < list.Count; i++)
            {
                br.Write(Encoding.UTF8.GetBytes(list[i]));
                br.Write(Encoding.UTF8.GetBytes("\n"));
            }
            //br.Write(Encoding.UTF8.GetBytes("******* \n"));
        }
        private void bt_add_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("input4.txt", FileMode.Append, FileAccess.Write);

            BinaryWriter br = new BinaryWriter(fs);

            nhap(br, list);
            fs.Close();
        }

        private void bt_read_Click(object sender, EventArgs e)
        {

            FileStream fs = new FileStream("input4.txt", FileMode.Open, FileAccess.Read);

            BinaryReader br1 = new BinaryReader(fs);


            byte[] data = br1.ReadBytes((int)fs.Length);

            string str = Encoding.UTF8.GetString(data);

            richTextBox1.Text = str;

            string[] arr = str.Split('\n');

            txt_name1.Text = arr[0];
            txt_id1.Text = arr[1];
            txt_phone1.Text = arr[2];
            txt_11.Text = arr[3];
            txt_21.Text = arr[4];
            txt_31.Text = arr[5];
            txt_avg.Text = arr[6];

            fs.Close();
        }

        private void bt_next_Click(object sender, EventArgs e)
        {
            dem += 1;
            FileStream fs = new FileStream("input4.txt", FileMode.Open, FileAccess.Read);

            BinaryReader br1 = new BinaryReader(fs);


            byte[] data = br1.ReadBytes((int)fs.Length);

            string str = Encoding.UTF8.GetString(data);

            List<int> list1 = new List<int>();

            string[] arr = str.Split('\n');
            for (int i = 0; i < arr.Length; i += 7)
            {
                if (i % 7 == 0) list1.Add(i);
            }

            if (dem < list1.Count - 1)
            {
                txt_name1.Text = arr[0 + list1[dem]];
                txt_id1.Text = arr[1 + list1[dem]];
                txt_phone1.Text = arr[2 + list1[dem]];
                txt_11.Text = arr[3 + list1[dem]];
                txt_21.Text = arr[4 + list1[dem]];
                txt_31.Text = arr[5 + list1[dem]];
                txt_avg.Text = arr[6 + list1[dem]];
                lb_int.Text = dem.ToString();
            }
            else MessageBox.Show("Đã ở trang cuối!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            fs.Close();
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            dem -= 1;
            FileStream fs = new FileStream("input4.txt", FileMode.Open, FileAccess.Read);

            BinaryReader br1 = new BinaryReader(fs);

            byte[] data = br1.ReadBytes((int)fs.Length);

            string str = Encoding.UTF8.GetString(data);

            List<int> list1 = new List<int>();

            string[] arr = str.Split('\n');
            for (int i = 0; i < arr.Length; i += 7)
            {
                if (i % 7 == 0) list1.Add(i);
            }

            if (dem >= 0)
            {
                txt_name1.Text = arr[0 + list1[dem]];
                txt_id1.Text = arr[1 + list1[dem]];
                txt_phone1.Text = arr[2 + list1[dem]];
                txt_11.Text = arr[3 + list1[dem]];
                txt_21.Text = arr[4 + list1[dem]];
                txt_31.Text = arr[5 + list1[dem]];
                txt_avg.Text = arr[6 + list1[dem]];
                lb_int.Text = dem.ToString();
            }
            else MessageBox.Show("Không còn trang ở sau nữa!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);


            fs.Close();
        }

        private void bai4_Load(object sender, EventArgs e)
        {

        }

        private void txt_11_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_21_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_31_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_avg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_int_Click(object sender, EventArgs e)
        {
            
        }
    }
}
