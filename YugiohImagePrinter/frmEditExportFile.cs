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
        private string duongdanDoc, settingPath1, settingPath2;

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
            File.WriteAllText(settingPath2, "0");
        }

        private void rbtTwoSide_CheckedChanged(object sender, EventArgs e)
        {
            File.WriteAllText(settingPath2, "1");
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

            string readFile1 = File.ReadAllText(settingPath1);
            string readFile2 = File.ReadAllText(settingPath2);

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
                rbtOneSide.Checked = true;
            }
            else if (readFile2 == "1")
            {
                rbtTwoSide.Checked = true;
            }
        }
    }
}
