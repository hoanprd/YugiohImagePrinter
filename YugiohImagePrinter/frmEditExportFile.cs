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
    public partial class frmEditExportFile : Form
    {
        private string duongdanDoc, settingPath1, settingPath2, settingPath3;

        private void cbbFileExtend_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbFileExtend.Text == ".docx")
            {
                File.WriteAllText(settingPath1, "0");
            }
            else if (cbbFileExtend.Text == ".pdf")
            {
                File.WriteAllText(settingPath1, "1");
            }
        }

        private void rbtOneSide_Click(object sender, EventArgs e)
        {
            File.WriteAllText(settingPath3, "0");
        }

        private void cbbPageSize_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbPageSize.Text == "A4")
            {
                File.WriteAllText(settingPath2, "0");
            }
            else if (cbbPageSize.Text == "A3")
            {
                File.WriteAllText(settingPath2, "1");
            }
        }

        private void rbtTwoSide_CheckedChanged(object sender, EventArgs e)
        {
            File.WriteAllText(settingPath3, "1");
        }

        public frmEditExportFile()
        {
            InitializeComponent();
        }

        private void frmEditExportFile_Load(object sender, EventArgs e)
        {
            duongdanDoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            settingPath1 = duongdanDoc + @"\YugiohPrinterSetting\SettingValue3.txt";
            settingPath2 = duongdanDoc + @"\YugiohPrinterSetting\SettingValue4.txt";
            settingPath3 = duongdanDoc + @"\YugiohPrinterSetting\SettingValue5.txt";

            string readFile1 = File.ReadAllText(settingPath1);
            string readFile2 = File.ReadAllText(settingPath2);
            string readFile3 = File.ReadAllText(settingPath3);

            if (readFile1 == "0")
            {
                cbbFileExtend.SelectedIndex = 0;
                cbbFileExtend.SelectedItem = ".docx";
            }
            else if(readFile1 == "1")
            {
                cbbFileExtend.SelectedIndex = 1;
                cbbFileExtend.SelectedItem = ".pdf";
            }

            if (readFile2 == "0")
            {
                cbbPageSize.SelectedIndex = 0;
                cbbPageSize.SelectedItem = "A4";
            }
            else if (readFile2 == "1")
            {
                cbbPageSize.SelectedIndex = 1;
                cbbPageSize.SelectedItem = "A3";
            }

            if (readFile3 == "0")
            {
                rbtOneSide.Checked = true;
            }
            else if (readFile3 == "1")
            {
                rbtTwoSide.Checked = true;
            }
        }
    }
}
