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

namespace YugiohImagePrinter
{
    public partial class frmChangeDir : Form
    {
        private string dirOnlinePath, dirOfflinePath, duongdanDoc, settingPath1, settingPath2;

        public frmChangeDir()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDirOnline_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                dirOnlinePath = fbd.SelectedPath;
                txtDirOnline.Text = dirOnlinePath;

                File.WriteAllText(settingPath1, dirOnlinePath);
            }
        }

        private void btnDirOffline_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                dirOfflinePath = fbd.SelectedPath;
                txtDirOffline.Text = dirOfflinePath;

                File.WriteAllText(settingPath2, dirOfflinePath);
            }
        }

        private void frmChangeDir_Load(object sender, EventArgs e)
        {
            duongdanDoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            settingPath1 = duongdanDoc + @"\YugiohPrinterSetting\SettingValue1.txt";
            settingPath2 = duongdanDoc + @"\YugiohPrinterSetting\SettingValue2.txt";

            string readFile1 = File.ReadAllText(settingPath1);
            string readFile2 = File.ReadAllText(settingPath2);

            txtDirOnline.Text = readFile1;
            txtDirOffline.Text = readFile2;
        }
    }
}
