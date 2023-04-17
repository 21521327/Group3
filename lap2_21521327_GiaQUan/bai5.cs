using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using Ionic.Zip;
using System.IO;

namespace lap2_21521327_GiaQUan
{
    public partial class bai5 : Form
    {
        public bai5()
        {
            InitializeComponent();
        }

        private void bt_bai6_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "Text Files (*.txt)|*.txt";
            ofd1.Title = "Chọn tập tin đầu vào";
            if (ofd1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string inputFile = ofd1.FileName;

            // Hiển thị hộp thoại để chọn vị trí giải nén
            FolderBrowserDialog fbd1 = new FolderBrowserDialog();
            fbd1.Description = "Chọn vị trí giải nén";
            if (fbd1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string outputFolder = fbd1.SelectedPath;

            // Tên tập tin đầu ra
            string outputFile = Path.Combine(outputFolder, "output5.zip");

            // Nén tập tin
            using (ZipFile zip = new ZipFile())
            {
                zip.AddFile(inputFile);
                zip.Save(outputFile);
            }

            // Giải nén tập tin
            using (ZipFile zip = ZipFile.Read(outputFile))
            {
                ZipEntry entry = zip[Path.GetFileName(inputFile)];
                entry.Extract(outputFolder, ExtractExistingFileAction.OverwriteSilently);
            }

            MessageBox.Show("Đã Hoàn Tất", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
