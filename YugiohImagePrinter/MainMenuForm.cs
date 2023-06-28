using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YugiohImagePrinter
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            YugiohPrinterForm sgm = new YugiohPrinterForm();
            sgm.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            ControlBox = false;
        }

        private void DownloadCardImageButton_Click(object sender, EventArgs e)
        {
            DownloadImageForm dif = new DownloadImageForm();
            dif.Show();
        }
    }
}
