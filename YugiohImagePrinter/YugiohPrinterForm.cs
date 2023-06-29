using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AltoHttp;
using Newtonsoft.Json;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;

namespace YugiohImagePrinter
{
    public partial class YugiohPrinterForm : Form
    {
        public static string decklistPath, dataPicPath, exportFileName, usingData;
        public static float x = -35f, y = -50f, width = 81.9899944414f, height = 243.764172336f;

        int horizontalIndex = 0, verticalIndex = 0;
        float horizontalValue = 180, verticalValue = 250;
        string userPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string[] tempArray;
        int[] downArray;
        string[] imageUrl = new string[20000];
        bool OnlineMode;

        HttpDownloader httpDownloader;

        private void YugiohPrinterForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            ControlBox = false;
            ExportButton.Enabled = false;
            label4.Hide();
            DataPicPathTextBox.Hide();
            AddDataPicPathButton.Hide();
            exportFileName = ExportFileNameTextBox.Text + ".docx";

            string jsonUrl = "https://db.ygoprodeck.com/api/v7/cardinfo.php";

            Directory.CreateDirectory($"{Application.StartupPath}\\{"JsonData"}");

            httpDownloader = new HttpDownloader(jsonUrl, $"{Application.StartupPath}\\{"JsonData"}\\{Path.GetFileName(jsonUrl) + ".json"}");
            httpDownloader.Start();
        }

        private void UsingDataComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            usingData = UsingDataComboBox.Text;
            if (usingData == "Online data")
            {
                OnlineMode = true;
                label4.Hide();
                DataPicPathTextBox.Hide();
                AddDataPicPathButton.Hide();
            }
            else if (usingData == "Offline data")
            {
                OnlineMode = false;
                label4.Show();
                DataPicPathTextBox.Show();
                AddDataPicPathButton.Show();
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (DecklistPathTextBox.Text == "" || DecklistPathTextBox.Text == null || UsingDataComboBox.Text == "" || UsingDataComboBox.Text == null)
            {
                MessageBox.Show("Decklist path and using data cannot be null or empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                var lines = File.ReadLines(decklistPath).Skip(1).ToArray();
                tempArray = new string[100];
                downArray = new int[100];
                int f = 0;

                ConfirmButton.Enabled = false;
                AddPathButton.Enabled = false;
                AddDataPicPathButton.Enabled = false;

                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i] != "#main" && lines[i] != "#extra" && lines[i] != "!side" && lines[i] != "" && lines != null)
                    {
                        tempArray[i] = lines[i];
                    }
                }

                List<string> list = new List<string>(tempArray);
                list.RemoveAll(string.IsNullOrEmpty);
                tempArray = list.ToArray();

                if (OnlineMode)
                {
                    try
                    {
                        imageUrl = new string[20000];
                        int i = 0;

                        using (StreamReader r = new StreamReader($"{Application.StartupPath}\\{"JsonData"}\\{"cardinfo.php.json"}"))
                        {
                            string json = r.ReadToEnd();
                            var test1 = JsonConvert.DeserializeObject<Root>(json);

                            foreach (Datum ci in test1.data)
                            {
                                foreach (CardImage cardImage in ci.card_images)
                                {
                                    imageUrl[i] = cardImage.image_url;
                                    i++;
                                }
                            }
                        }

                        List<string> list2 = new List<string>(imageUrl);
                        list2.RemoveAll(string.IsNullOrEmpty);
                        imageUrl = list2.ToArray();

                        if (!Directory.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\{"CardImageData"}"))
                        {
                            Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\{"CardImageData"}");
                        }

                        for (int j = 0; j < imageUrl.Length; j++)
                        {
                            for (int j2 = 0; j2 < tempArray.Length; j2++)
                            {
                                if (Path.GetFileName(imageUrl[j]) == (tempArray[j2] + ".jpg"))
                                {
                                    if (!File.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\{"CardImageData"}\\{Path.GetFileName(imageUrl[j])}"))
                                    {
                                        downArray[f] = j;
                                        f++;
                                    }
                                }
                            }
                        }

                        for (int h = 0; h < downArray.Length; h++)
                        {
                            if (!File.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\{"CardImageData"}\\{Path.GetFileName(imageUrl[downArray[h]])}"))
                            {
                                Thread.Sleep(1300);
                                httpDownloader = new HttpDownloader(imageUrl[downArray[h]], $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\{"CardImageData"}\\{Path.GetFileName(imageUrl[downArray[h]])}");
                                httpDownloader.Start();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }

                    ExportButton.Enabled = true;
                }
                else
                {
                    if (DataPicPathTextBox.Text == "" || DataPicPathTextBox.Text == null)
                    {
                        MessageBox.Show("Picture data path cannot be null or empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        ConfirmButton.Enabled = true;
                        AddPathButton.Enabled = true;
                        AddDataPicPathButton.Enabled = true;
                    }
                    else
                    {
                        ExportButton.Enabled = true;
                    }
                }
            }
        }

        private void AddDataPicPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                dataPicPath = fbd.SelectedPath;
                DataPicPathTextBox.Text = dataPicPath;
            }
        }

        public YugiohPrinterForm()
        {
            InitializeComponent();
        }

        private void AddPathButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Title = "Select File";
            openFileDialog1.InitialDirectory = @"C:\";//--"C:\\";
            openFileDialog1.Filter = "All files (*.*)|*.*|Yugioh Decklist File (*.ydk)|*.ydk";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                decklistPath = openFileDialog1.FileName;
                DecklistPathTextBox.Text = decklistPath;
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            horizontalIndex = 0;
            verticalIndex = 0;
            ExportButton.Enabled = false;
            ConfirmButton.Enabled = true;
            AddPathButton.Enabled = true;
            AddDataPicPathButton.Enabled = true;

            try
            {
                Document document = new Document();
                document.LoadFromFile("Doc1.docx");

                if (OnlineMode)
                {
                    foreach (Section section in document.Sections)
                    {
                        section.PageSetup.PageSize = PageSize.A4;
                    }

                    for (int i = 0; i < tempArray.Length; i++)
                    {
                        Section section = document.Sections[0];

                        if ((i == 9 || i == 18 || i == 27 || i == 36 || i == 45 || i == 54 || i == 63 || i == 72 || i == 81) && i != 0)
                        {
                            Paragraph paragraph = section.Paragraphs[0];
                            paragraph.AppendBreak(BreakType.PageBreak);
                            verticalIndex = 0;
                        }

                        DocPicture picture = section.Paragraphs[0].AppendPicture(Image.FromFile($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\{"CardImageData"}\\{tempArray[i] + ".jpg"}"));
                        picture.HorizontalPosition = x + (horizontalValue * horizontalIndex);
                        picture.VerticalPosition = y + (verticalValue * verticalIndex);

                        horizontalIndex += 1;

                        if (horizontalIndex > 2)
                        {
                            horizontalIndex = 0;
                            verticalIndex += 1;
                        }

                        picture.Width = width;
                        picture.Height = height;

                        picture.TextWrappingStyle = TextWrappingStyle.InFrontOfText;
                    }

                    document.SaveToFile(userPath + "\\" + exportFileName, FileFormat.Docx);
                    Console.WriteLine("Done!");
                    MessageBox.Show("Export success!\nFile location at" + userPath + "\\" + exportFileName, "Title");
                }
                else
                {
                    foreach (Section section in document.Sections)
                    {
                        section.PageSetup.PageSize = PageSize.A4;
                    }

                    for (int i = 0; i < tempArray.Length; i++)
                    {
                        Section section = document.Sections[0];

                        if ((i == 9 || i == 18 || i == 27 || i == 36 || i == 45 || i == 54 || i == 63 || i == 72 || i == 81) && i != 0)
                        {
                            Paragraph paragraph = section.Paragraphs[0];
                            paragraph.AppendBreak(BreakType.PageBreak);
                            verticalIndex = 0;
                        }

                        DocPicture picture = section.Paragraphs[0].AppendPicture(Image.FromFile(dataPicPath + "\\" + tempArray[i] + ".jpg"));
                        picture.HorizontalPosition = x + (horizontalValue * horizontalIndex);
                        picture.VerticalPosition = y + (verticalValue * verticalIndex);

                        horizontalIndex += 1;

                        if (horizontalIndex > 2)
                        {
                            horizontalIndex = 0;
                            verticalIndex += 1;
                        }

                        picture.Width = width;
                        picture.Height = height;

                        picture.TextWrappingStyle = TextWrappingStyle.InFrontOfText;
                    }

                    document.SaveToFile(userPath + "\\" + exportFileName, FileFormat.Docx);

                    MessageBox.Show("Export success!\nFile location at" + userPath + "\\" + exportFileName, "Title");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            MainMenuForm mm = new MainMenuForm();
            mm.Show();
            this.Close();
        }

        private void ExportFileNameTextBox_TextChanged(object sender, EventArgs e)
        {
            exportFileName = ExportFileNameTextBox.Text + ".docx";
        }
    }
}
