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
    public partial class frmDefault : Form
    {
        private string duongdanDoc, settingPath1;

        public frmDefault()
        {
            InitializeComponent();
        }

        private void frmDefault_Load(object sender, EventArgs e)
        {
            duongdanDoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            settingPath1 = duongdanDoc + @"\YugiohPrinterSetting\SettingValue6.txt";

            string readFile1 = File.ReadAllText(settingPath1);

            Image image = Image.FromFile(readFile1);
            pbxMain.Image = image;
        }
    }
}
