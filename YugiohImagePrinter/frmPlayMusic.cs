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
    public partial class frmPlayMusic : Form
    {
        OpenFileDialog openFileDialog;
        string[] filePaths, fileNames;

        public frmPlayMusic()
        {
            InitializeComponent();
        }

        private void btnListOn_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Mp3 files, mp4 files (*.mp3, *.mp4)|*.mp*";
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Chọn danh sách nhạc";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePaths = openFileDialog.FileNames;
                fileNames = openFileDialog.SafeFileNames;
                
                foreach (var item in fileNames)
                {
                    ltbListMusic.Items.Add(item);
                }
            }
        }

        private void ltbListMusic_DoubleClick(object sender, EventArgs e)
        {
            if (ltbListMusic.SelectedIndex != -1)
            {
                int choose = ltbListMusic.SelectedIndex;
                axWindowsMediaPlayer1.URL = filePaths[choose];
            }
        }
    }
}
