using AltoHttp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YugiohImagePrinter
{
    public partial class frmDownloadImage : Form
    {
        private string offlinePath;
        private string duongdanDoc, settingPath1;

        public frmDownloadImage()
        {
            InitializeComponent();
        }

        HttpDownloader httpDownloader;

        private void DownloadCardImageButton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] imageUrl = new string[20000];
                int i = 0;

                if (string.IsNullOrEmpty(offlinePath))
                {
                    MessageBox.Show("Thư mục chứa ảnh offline không tồn tại\nVui lòng chọn đường dẫn trong cài đặt!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

                using (StreamReader r = new StreamReader($"{Application.StartupPath}\\{"JsonData"}\\{"cardinfo.php.json"}"))
                {
                    string json = r.ReadToEnd();
                    var test1 = JsonConvert.DeserializeObject<Root>(json);

                    foreach (Datum ci in test1.data)
                    {
                        foreach (CardImage cardImage in ci.card_images)
                        {
                            imageUrl[i] = cardImage.image_url;
                            //Console.WriteLine(imageUrl[i]);
                            i++;
                        }
                    }
                }

                List<string> list = new List<string>(imageUrl);
                list.RemoveAll(string.IsNullOrEmpty);
                imageUrl = list.ToArray();

                for (int j = 0; j < imageUrl.Length; j++)
                {
                    Thread.Sleep(100);
                    if (!File.Exists($"{offlinePath}\\{Path.GetFileName(imageUrl[j])}"))
                    {
                        httpDownloader = new HttpDownloader(imageUrl[j], $"{offlinePath}\\{Path.GetFileName(imageUrl[j])}");
                        //httpDownloader.DownloadCompleted += HttpDownloader_DownloadCompleted;
                        //httpDownloader.ProgressChanged += HttpDownloader_ProgressChanged;
                        httpDownloader.Start();
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void AgreeButton_Click(object sender, EventArgs e)
        {
            AgreeButton.Enabled = false;

            Thread.Sleep(5000);

            DownloadCardImageButton.Enabled = true;
        }

        private void DownloadImageForm_Load(object sender, EventArgs e)
        {
            duongdanDoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            settingPath1 = duongdanDoc + @"\YugiohPrinterSetting\SettingValue2.txt";

            string readFile1 = File.ReadAllText(settingPath1);

            offlinePath = readFile1;

            DownloadCardImageButton.Enabled = false;

            try
            {
                string jsonUrl = "https://db.ygoprodeck.com/api/v7/cardinfo.php";

                if (!Directory.Exists($"{Application.StartupPath}\\{"JsonData"}"))
                {
                    Directory.CreateDirectory($"{Application.StartupPath}\\{"JsonData"}");

                    httpDownloader = new HttpDownloader(jsonUrl, $"{Application.StartupPath}\\{"JsonData"}\\{Path.GetFileName(jsonUrl) + ".json"}");
                    //httpDownloader.DownloadCompleted += HttpDownloader_DownloadCompleted;
                    //httpDownloader.ProgressChanged += HttpDownloader_ProgressChanged;
                    httpDownloader.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void UseDriverLinkButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/drive/folders/1JXLhv2MFxmCRdCBqebnmnvB8Zw5MFl7Z?usp=sharing");
        }
    }
}
