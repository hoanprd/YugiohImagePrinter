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

namespace YugiohImagePrinter
{
    public partial class frmMain : Form
    {
        private Form currentFormChild;

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
