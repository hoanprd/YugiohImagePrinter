using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace YugiohImagePrinter
{
    public partial class frmMain : Form
    {
        private Form currentFormChild;
        private string duongdanDoc, settingPath1, settingPath2, settingPath3, settingPath4;
        public string onlinePath, offlinePath, fileFormatPath, pageSizePath;

        public frmMain()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            //ControlBox = false;
            duongdanDoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            settingPath1 = duongdanDoc + @"\YugiohPrinterSetting\SettingValue1.txt";
            settingPath2 = duongdanDoc + @"\YugiohPrinterSetting\SettingValue2.txt";
            settingPath3 = duongdanDoc + @"\YugiohPrinterSetting\SettingValue3.txt";
            settingPath4 = duongdanDoc + @"\YugiohPrinterSetting\SettingValue4.txt";

            if (!Directory.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\{"YugiohPrinterSetting"}"))
            {
                Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\{"YugiohPrinterSetting"}");
            }

            if (!File.Exists(settingPath1))
            {
                using (FileStream fs = File.Create(settingPath1))
                {
                    
                }
            }
            if (!File.Exists(settingPath2))
            {
                using (FileStream fs = File.Create(settingPath2))
                {

                }
            }
            if (!File.Exists(settingPath3))
            {
                using (FileStream fs = File.Create(settingPath3))
                {

                }
            }
            if (!File.Exists(settingPath4))
            {
                using (FileStream fs = File.Create(settingPath4))
                {

                }
            }

            string readFile1 = File.ReadAllText(settingPath1);
            string readFile2 = File.ReadAllText(settingPath2);
            string readFile3 = File.ReadAllText(settingPath3);
            string readFile4 = File.ReadAllText(settingPath4);

            if (string.IsNullOrEmpty(readFile1))
            {
                File.WriteAllText(settingPath1, $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\{"CardImageData"}");
            }
            else
            {
                onlinePath = readFile1;
            }

            offlinePath = readFile2;

            if (string.IsNullOrEmpty(readFile3))
            {
                File.WriteAllText(settingPath3, "0");
            }
            else
            {
                fileFormatPath = readFile3;
            }

            if (string.IsNullOrEmpty(readFile4))
            {
                File.WriteAllText(settingPath4, "0");
            }
            else
            {
                pageSizePath = readFile4;
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tảiHìnhẢnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDownloadImage());
        }

        private void tạoFileInCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmYugiohPrinter());
        }

        private void chỉnhSửaFileXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmEditExportFile());
        }

        private void thayĐổiĐườngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmChangeDir());
        }

        private void hỗTrợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/hoan.nguyenduy.7967");
        }

        private void mànHìnhChínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDefault());
        }
    }
}
