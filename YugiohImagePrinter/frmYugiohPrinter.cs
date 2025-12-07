using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AltoHttp;
using Newtonsoft.Json;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using AltoHttp.NativeMessages;

namespace YugiohImagePrinter
{
    public partial class frmYugiohPrinter : Form
    {
        private string onlinePath, offlinePath, fileFormat, pageSize, pageSide;
        private string duongdanDoc, settingPath1, settingPath2, settingPath3, settingPath4, settingPath5;

        public static string decklistPath, dataPicPath, exportFileName, usingData;
        //public static float x = -35f, y = -50f, width = 81.9899944414f, height = 243.764172336f;
        //public static float x = -55f, y = -50f, width = 88.9382990551f, height = 257.936507937f;
        public static float x = -55f, y = -50f, width = 87.5486381323f, height = 255.10204081674f;

        int horizontalIndex = 0, verticalIndex = 0;
        //float horizontalValue = 180, verticalValue = 250;
        float horizontalValue = 190, verticalValue = 270;
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

            //exportFileName = ExportFileNameTextBox.Text + ".docx";
            duongdanDoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            settingPath1 = duongdanDoc + @"\YugiohPrinterSetting\SettingValue1.txt";
            settingPath2 = duongdanDoc + @"\YugiohPrinterSetting\SettingValue2.txt";
            settingPath3 = duongdanDoc + @"\YugiohPrinterSetting\SettingValue3.txt";
            settingPath4 = duongdanDoc + @"\YugiohPrinterSetting\SettingValue4.txt";
            settingPath5 = duongdanDoc + @"\YugiohPrinterSetting\SettingValue5.txt";

            string readFile1 = File.ReadAllText(settingPath1);
            string readFile2 = File.ReadAllText(settingPath2);
            string readFile3 = File.ReadAllText(settingPath3);
            string readFile4 = File.ReadAllText(settingPath4);
            string readFile5 = File.ReadAllText(settingPath5);

            onlinePath = readFile1;
            offlinePath = readFile2;
            fileFormat = readFile3;
            pageSize = readFile4;
            pageSide = readFile5;

            if (fileFormat == "0")
            {
                exportFileName = ExportFileNameTextBox.Text + ".docx";
            }
            else if (fileFormat == "1")
            {
                exportFileName = ExportFileNameTextBox.Text + ".pdf";
            }

            //string jsonUrl = "https://db.ygoprodeck.com/api/v7/cardinfo.php";

            if (!Directory.Exists($"{Application.StartupPath}\\{"JsonData"}"))
            {
                Directory.CreateDirectory($"{Application.StartupPath}\\{"JsonData"}");
            }

            //httpDownloader = new HttpDownloader(jsonUrl, $"{Application.StartupPath}\\{"JsonData"}\\{Path.GetFileName(jsonUrl) + ".json"}");
            //httpDownloader.Start();
        }

        private void UsingDataComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            usingData = cbbUsingData.Text;
            if (usingData == "Online data")
            {
                OnlineMode = true;
            }
            else if (usingData == "Offline data")
            {
                OnlineMode = false;
            }
        }

        private async void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDecklistPath.Text))
            {
                MessageBox.Show("Vui lòng thêm decklist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (string.IsNullOrEmpty(cbbUsingData.Text))
            {
                MessageBox.Show("Vui lòng chọn chế độ dữ liệu sử dụng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                string jsonUrl = "https://db.ygoprodeck.com/api/v7/cardinfo.php";

                httpDownloader = new HttpDownloader(jsonUrl, $"{Application.StartupPath}\\{"JsonData"}\\{Path.GetFileName(jsonUrl) + ".json"}");
                httpDownloader.Start();

                var lines = File.ReadLines(decklistPath).Skip(1).ToArray();
                tempArray = new string[100];
                downArray = new int[100];
                int f = 0;

                ConfirmButton.Enabled = false;
                AddPathButton.Enabled = false;

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

                        for (int j = 0; j < imageUrl.Length; j++)
                        {
                            for (int j2 = 0; j2 < tempArray.Length; j2++)
                            {
                                if (Path.GetFileName(imageUrl[j]) == (tempArray[j2] + ".jpg"))
                                {
                                    if (!File.Exists($"{onlinePath}\\{Path.GetFileName(imageUrl[j])}"))
                                    {
                                        downArray[f] = j;
                                        f++;
                                    }
                                }
                            }
                        }

                        for (int h = 0; h < downArray.Length; h++)
                        {
                            if (!File.Exists($"{onlinePath}\\{Path.GetFileName(imageUrl[downArray[h]])}"))
                            {
                                //Thread.Sleep(1300);
                                httpDownloader = new HttpDownloader(imageUrl[downArray[h]], $"{onlinePath}\\{Path.GetFileName(imageUrl[downArray[h]])}");
                                httpDownloader.Start();
                                await Task.Delay(1000);
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
                    if (string.IsNullOrEmpty(offlinePath))
                    {
                        MessageBox.Show("Thư mục chứa ảnh offline không tồn tại\nVui lòng chọn đường dẫn trong cài đặt!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        ConfirmButton.Enabled = true;
                        AddPathButton.Enabled = true;
                    }
                    else
                    {
                        ExportButton.Enabled = true;
                    }
                }
            }
        }

        public frmYugiohPrinter()
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
                txtDecklistPath.Text = decklistPath;
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            horizontalIndex = 0;
            verticalIndex = 0;
            ExportButton.Enabled = false;
            ConfirmButton.Enabled = true;
            AddPathButton.Enabled = true;
            bool a3PageColum = false, sideBackground = false;

            try
            {
                Document document = new Document();
                document.LoadFromFile("Doc1.docx");

                if (OnlineMode)
                {
                    foreach (Section section in document.Sections)
                    {
                        if (pageSize == "0")
                        {
                            section.PageSetup.PageSize = PageSize.A4;
                        }
                        else if (pageSize == "1")
                        {
                            section.PageSetup.PageSize = PageSize.A3;
                        }
                    }

                    for (int i = 0; i < tempArray.Length; i++)
                    {
                        Section section = document.Sections[0];

                        if (pageSize == "0")
                        {
                            if (pageSide == "0")
                            {
                                if ((i == 9 || i == 18 || i == 27 || i == 36 || i == 45 || i == 54 || i == 63 || i == 72 || i == 81) && i != 0)
                                {
                                    Paragraph paragraph = section.Paragraphs[0];
                                    paragraph.AppendBreak(BreakType.PageBreak);
                                    verticalIndex = 0;
                                }

                                DocPicture picture = section.Paragraphs[0].AppendPicture(Image.FromFile($"{onlinePath}\\{tempArray[i] + ".jpg"}"));
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
                            else if (pageSide == "1")
                            {
                                if ((i == 9 || i == 18 || i == 27 || i == 36 || i == 45 || i == 54 || i == 63 || i == 72 || i == 81) && i != 0)
                                {
                                    Paragraph paragraph = section.Paragraphs[0];
                                    paragraph.AppendBreak(BreakType.PageBreak);
                                    verticalIndex = 0;
                                    sideBackground = true;
                                }

                                if (sideBackground)
                                {
                                    for (int i2 = 0; i2 < 9; i2++)
                                    {
                                        DocPicture picture2 = section.Paragraphs[0].AppendPicture(Image.FromFile($"{Application.StartupPath}\\{"YgoBackCard.png"}"));
                                        picture2.HorizontalPosition = x + (horizontalValue * horizontalIndex);
                                        picture2.VerticalPosition = y + (verticalValue * verticalIndex);

                                        horizontalIndex += 1;

                                        if (horizontalIndex > 2)
                                        {
                                            horizontalIndex = 0;
                                            verticalIndex += 1;
                                        }

                                        picture2.Width = width;
                                        picture2.Height = height;

                                        picture2.TextWrappingStyle = TextWrappingStyle.InFrontOfText;
                                    }

                                    sideBackground = false;
                                    Paragraph paragraph2 = section.Paragraphs[0];
                                    paragraph2.AppendBreak(BreakType.PageBreak);
                                    horizontalIndex = 0;
                                    verticalIndex = 0;
                                }

                                DocPicture picture = section.Paragraphs[0].AppendPicture(Image.FromFile($"{onlinePath}\\{tempArray[i] + ".jpg"}"));
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
                        }
                        else if (pageSize == "1")
                        {
                            if (pageSide == "0")
                            {
                                if ((i == 18 || i == 36 || i == 54 || i == 72) && i != 0)
                                {
                                    Paragraph paragraph = section.Paragraphs[0];
                                    paragraph.AppendBreak(BreakType.PageBreak);
                                    horizontalIndex = 0;
                                    verticalIndex = 0;
                                    a3PageColum = false;
                                }

                                DocPicture picture = section.Paragraphs[0].AppendPicture(Image.FromFile($"{onlinePath}\\{tempArray[i] + ".jpg"}"));
                                picture.HorizontalPosition = x + (horizontalValue * horizontalIndex);
                                picture.VerticalPosition = y + 70 + (verticalValue * verticalIndex);

                                if (a3PageColum == true)
                                {
                                    picture.Rotation = 90;
                                    picture.HorizontalPosition += 32;
                                    picture.VerticalPosition = y + 8 + ((verticalValue - 75) * verticalIndex);
                                }

                                if (a3PageColum == false)
                                {
                                    horizontalIndex += 1;
                                }
                                else if (a3PageColum == true)
                                {
                                    verticalIndex += 1;
                                }

                                if (horizontalIndex == 3 && verticalIndex < 4 && a3PageColum == false)
                                {
                                    horizontalIndex = 0;
                                    verticalIndex += 1;
                                }

                                if (verticalIndex == 4 && a3PageColum == false)
                                {
                                    a3PageColum = true;
                                    verticalIndex = 0;
                                    horizontalIndex = 3;
                                }

                                picture.Width = width;
                                picture.Height = height;

                                picture.TextWrappingStyle = TextWrappingStyle.InFrontOfText;
                            }
                            else if (pageSide == "1")
                            {
                                if ((i == 18 || i == 36 || i == 54 || i == 72) && i != 0)
                                {
                                    Paragraph paragraph = section.Paragraphs[0];
                                    paragraph.AppendBreak(BreakType.PageBreak);
                                    horizontalIndex = 0;
                                    verticalIndex = 0;
                                    a3PageColum = false;
                                    sideBackground = true;
                                }

                                if (sideBackground)
                                {
                                    for (int i2 = 0; i2 < 18; i2++)
                                    {
                                        DocPicture picture2 = section.Paragraphs[0].AppendPicture(Image.FromFile($"{Application.StartupPath}\\{"YgoBackCard.png"}"));
                                        picture2.HorizontalPosition = x + (horizontalValue * horizontalIndex);
                                        picture2.VerticalPosition = y + 70 + (verticalValue * verticalIndex);

                                        if (a3PageColum == true)
                                        {
                                            picture2.Rotation = 90;
                                            picture2.HorizontalPosition += 32;
                                            picture2.VerticalPosition = y + 8 + ((verticalValue - 75) * verticalIndex);
                                        }

                                        if (a3PageColum == false)
                                        {
                                            horizontalIndex += 1;
                                        }
                                        else if (a3PageColum == true)
                                        {
                                            verticalIndex += 1;
                                        }

                                        if (horizontalIndex == 3 && verticalIndex < 4 && a3PageColum == false)
                                        {
                                            horizontalIndex = 0;
                                            verticalIndex += 1;
                                        }

                                        if (verticalIndex == 4 && a3PageColum == false)
                                        {
                                            a3PageColum = true;
                                            verticalIndex = 0;
                                            horizontalIndex = 3;
                                        }

                                        picture2.Width = width;
                                        picture2.Height = height;

                                        picture2.TextWrappingStyle = TextWrappingStyle.InFrontOfText;
                                    }

                                    sideBackground = false;
                                    a3PageColum = false;
                                    Paragraph paragraph2 = section.Paragraphs[0];
                                    paragraph2.AppendBreak(BreakType.PageBreak);
                                    horizontalIndex = 0;
                                    verticalIndex = 0;
                                }

                                DocPicture picture = section.Paragraphs[0].AppendPicture(Image.FromFile($"{onlinePath}\\{tempArray[i] + ".jpg"}"));
                                picture.HorizontalPosition = x + (horizontalValue * horizontalIndex);
                                picture.VerticalPosition = y + 70 + (verticalValue * verticalIndex);

                                if (a3PageColum == true)
                                {
                                    picture.Rotation = 90;
                                    picture.HorizontalPosition += 32;
                                    picture.VerticalPosition = y + 8 + ((verticalValue - 75) * verticalIndex);
                                }

                                if (a3PageColum == false)
                                {
                                    horizontalIndex += 1;
                                }
                                else if (a3PageColum == true)
                                {
                                    verticalIndex += 1;
                                }

                                if (horizontalIndex == 3 && verticalIndex < 4 && a3PageColum == false)
                                {
                                    horizontalIndex = 0;
                                    verticalIndex += 1;
                                }

                                if (verticalIndex == 4 && a3PageColum == false)
                                {
                                    a3PageColum = true;
                                    verticalIndex = 0;
                                    horizontalIndex = 3;
                                }

                                picture.Width = width;
                                picture.Height = height;

                                picture.TextWrappingStyle = TextWrappingStyle.InFrontOfText;
                            }
                        }
                    }

                    if (pageSize == "0")
                    {
                        if (pageSide == "1")
                        {
                            Section sectionLastPage = document.Sections[0];

                            Paragraph paragraphLastPage = sectionLastPage.Paragraphs[0];
                            paragraphLastPage.AppendBreak(BreakType.PageBreak);
                            verticalIndex = 0;
                            horizontalIndex = 0;
                            sideBackground = true;

                            for (int i2 = 0; i2 < 9; i2++)
                            {
                                DocPicture pictureLastPage = sectionLastPage.Paragraphs[0].AppendPicture(Image.FromFile($"{Application.StartupPath}\\{"YgoBackCard.png"}"));
                                pictureLastPage.HorizontalPosition = x + (horizontalValue * horizontalIndex);
                                pictureLastPage.VerticalPosition = y + (verticalValue * verticalIndex);

                                horizontalIndex += 1;

                                if (horizontalIndex > 2)
                                {
                                    horizontalIndex = 0;
                                    verticalIndex += 1;
                                }

                                pictureLastPage.Width = width;
                                pictureLastPage.Height = height;

                                pictureLastPage.TextWrappingStyle = TextWrappingStyle.InFrontOfText;
                            }

                            sideBackground = false;
                            horizontalIndex = 0;
                            verticalIndex = 0;
                        }
                    }
                    else if (pageSize == "1")
                    {
                        if (pageSide == "1")
                        {
                            Section sectionLastPage = document.Sections[0];

                            Paragraph paragraphLastPage = sectionLastPage.Paragraphs[0];
                            paragraphLastPage.AppendBreak(BreakType.PageBreak);
                            verticalIndex = 0;
                            horizontalIndex = 0;
                            sideBackground = true;
                            a3PageColum = false;

                            for (int i2 = 0; i2 < 18; i2++)
                            {
                                DocPicture pictureLastPage = sectionLastPage.Paragraphs[0].AppendPicture(Image.FromFile($"{Application.StartupPath}\\{"YgoBackCard.png"}"));
                                pictureLastPage.HorizontalPosition = x + (horizontalValue * horizontalIndex);
                                pictureLastPage.VerticalPosition = y + 70 + (verticalValue * verticalIndex);

                                if (a3PageColum == true)
                                {
                                    pictureLastPage.Rotation = 90;
                                    pictureLastPage.HorizontalPosition += 32;
                                    pictureLastPage.VerticalPosition = y + 8 + ((verticalValue - 75) * verticalIndex);
                                }

                                if (a3PageColum == false)
                                {
                                    horizontalIndex += 1;
                                }
                                else if (a3PageColum == true)
                                {
                                    verticalIndex += 1;
                                }

                                if (horizontalIndex == 3 && verticalIndex < 4 && a3PageColum == false)
                                {
                                    horizontalIndex = 0;
                                    verticalIndex += 1;
                                }

                                if (verticalIndex == 4 && a3PageColum == false)
                                {
                                    a3PageColum = true;
                                    verticalIndex = 0;
                                    horizontalIndex = 3;
                                }

                                pictureLastPage.Width = width;
                                pictureLastPage.Height = height;

                                pictureLastPage.TextWrappingStyle = TextWrappingStyle.InFrontOfText;
                            }

                            sideBackground = false;
                            a3PageColum = false;
                            horizontalIndex = 0;
                            verticalIndex = 0;
                        }
                    }

                    if (fileFormat == "0")
                    {
                        exportFileName = ExportFileNameTextBox.Text + ".docx";
                        document.SaveToFile(userPath + "\\" + exportFileName, FileFormat.Docx);
                    }
                    else if (fileFormat == "1")
                    {
                        exportFileName = ExportFileNameTextBox.Text + ".pdf";
                        document.SaveToFile(userPath + "\\" + exportFileName, FileFormat.PDF);
                    }

                    MessageBox.Show("Xuất file thành công!\nĐường dẫn file tại " + userPath + "\\" + exportFileName, "Thành công");
                }
                else
                {
                    foreach (Section section in document.Sections)
                    {
                        if (pageSize == "0")
                        {
                            section.PageSetup.PageSize = PageSize.A4;
                        }
                        else if (pageSize == "1")
                        {
                            section.PageSetup.PageSize = PageSize.A3;
                        }
                    }

                    for (int i = 0; i < tempArray.Length; i++)
                    {
                        Section section = document.Sections[0];

                        if (pageSize == "0")
                        {
                            if (pageSide == "0")
                            {
                                if ((i == 9 || i == 18 || i == 27 || i == 36 || i == 45 || i == 54 || i == 63 || i == 72 || i == 81) && i != 0)
                                {
                                    Paragraph paragraph = section.Paragraphs[0];
                                    paragraph.AppendBreak(BreakType.PageBreak);
                                    verticalIndex = 0;
                                }

                                DocPicture picture = section.Paragraphs[0].AppendPicture(Image.FromFile($"{offlinePath}\\{tempArray[i] + ".jpg"}"));
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
                            else if (pageSide == "1")
                            {
                                if ((i == 9 || i == 18 || i == 27 || i == 36 || i == 45 || i == 54 || i == 63 || i == 72 || i == 81) && i != 0)
                                {
                                    Paragraph paragraph = section.Paragraphs[0];
                                    paragraph.AppendBreak(BreakType.PageBreak);
                                    verticalIndex = 0;
                                    sideBackground = true;
                                }

                                if (sideBackground)
                                {
                                    for (int i2 = 0; i2 < 9; i2++)
                                    {
                                        DocPicture picture2 = section.Paragraphs[0].AppendPicture(Image.FromFile($"{Application.StartupPath}\\{"YgoBackCard.png"}"));
                                        picture2.HorizontalPosition = x + (horizontalValue * horizontalIndex);
                                        picture2.VerticalPosition = y + (verticalValue * verticalIndex);

                                        horizontalIndex += 1;

                                        if (horizontalIndex > 2)
                                        {
                                            horizontalIndex = 0;
                                            verticalIndex += 1;
                                        }

                                        picture2.Width = width;
                                        picture2.Height = height;

                                        picture2.TextWrappingStyle = TextWrappingStyle.InFrontOfText;
                                    }

                                    sideBackground = false;
                                    Paragraph paragraph2 = section.Paragraphs[0];
                                    paragraph2.AppendBreak(BreakType.PageBreak);
                                    horizontalIndex = 0;
                                    verticalIndex = 0;
                                }

                                DocPicture picture = section.Paragraphs[0].AppendPicture(Image.FromFile($"{offlinePath}\\{tempArray[i] + ".jpg"}"));
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
                        }
                        else if (pageSize == "1")
                        {
                            if (pageSide == "0")
                            {
                                if ((i == 18 || i == 36 || i == 54 || i == 72) && i != 0)
                                {
                                    Paragraph paragraph = section.Paragraphs[0];
                                    paragraph.AppendBreak(BreakType.PageBreak);
                                    horizontalIndex = 0;
                                    verticalIndex = 0;
                                    a3PageColum = false;
                                }

                                DocPicture picture = section.Paragraphs[0].AppendPicture(Image.FromFile($"{offlinePath}\\{tempArray[i] + ".jpg"}"));
                                picture.HorizontalPosition = x + (horizontalValue * horizontalIndex);
                                picture.VerticalPosition = y + 70 + (verticalValue * verticalIndex);

                                if (a3PageColum == true)
                                {
                                    picture.Rotation = 90;
                                    picture.HorizontalPosition += 32;
                                    picture.VerticalPosition = y + 8 + ((verticalValue - 75) * verticalIndex);
                                }

                                if (a3PageColum == false)
                                {
                                    horizontalIndex += 1;
                                }
                                else if (a3PageColum == true)
                                {
                                    verticalIndex += 1;
                                }

                                if (horizontalIndex == 3 && verticalIndex < 4 && a3PageColum == false)
                                {
                                    horizontalIndex = 0;
                                    verticalIndex += 1;
                                }

                                if (verticalIndex == 4 && a3PageColum == false)
                                {
                                    a3PageColum = true;
                                    verticalIndex = 0;
                                    horizontalIndex = 3;
                                }

                                picture.Width = width;
                                picture.Height = height;

                                picture.TextWrappingStyle = TextWrappingStyle.InFrontOfText;
                            }
                            else if (pageSide == "1")
                            {
                                if ((i == 18 || i == 36 || i == 54 || i == 72) && i != 0)
                                {
                                    Paragraph paragraph = section.Paragraphs[0];
                                    paragraph.AppendBreak(BreakType.PageBreak);
                                    horizontalIndex = 0;
                                    verticalIndex = 0;
                                    a3PageColum = false;
                                    sideBackground = true;
                                }

                                if (sideBackground)
                                {
                                    for (int i2 = 0; i2 < 18; i2++)
                                    {
                                        DocPicture picture2 = section.Paragraphs[0].AppendPicture(Image.FromFile($"{Application.StartupPath}\\{"YgoBackCard.png"}"));
                                        picture2.HorizontalPosition = x + (horizontalValue * horizontalIndex);
                                        picture2.VerticalPosition = y + 70 + (verticalValue * verticalIndex);

                                        if (a3PageColum == true)
                                        {
                                            picture2.Rotation = 90;
                                            picture2.HorizontalPosition += 32;
                                            picture2.VerticalPosition = y + 8 + ((verticalValue - 75) * verticalIndex);
                                        }

                                        if (a3PageColum == false)
                                        {
                                            horizontalIndex += 1;
                                        }
                                        else if (a3PageColum == true)
                                        {
                                            verticalIndex += 1;
                                        }

                                        if (horizontalIndex == 3 && verticalIndex < 4 && a3PageColum == false)
                                        {
                                            horizontalIndex = 0;
                                            verticalIndex += 1;
                                        }

                                        if (verticalIndex == 4 && a3PageColum == false)
                                        {
                                            a3PageColum = true;
                                            verticalIndex = 0;
                                            horizontalIndex = 3;
                                        }

                                        picture2.Width = width;
                                        picture2.Height = height;

                                        picture2.TextWrappingStyle = TextWrappingStyle.InFrontOfText;
                                    }

                                    sideBackground = false;
                                    a3PageColum = false;
                                    Paragraph paragraph2 = section.Paragraphs[0];
                                    paragraph2.AppendBreak(BreakType.PageBreak);
                                    horizontalIndex = 0;
                                    verticalIndex = 0;
                                }

                                DocPicture picture = section.Paragraphs[0].AppendPicture(Image.FromFile($"{offlinePath}\\{tempArray[i] + ".jpg"}"));
                                picture.HorizontalPosition = x + (horizontalValue * horizontalIndex);
                                picture.VerticalPosition = y + 70 + (verticalValue * verticalIndex);

                                if (a3PageColum == true)
                                {
                                    picture.Rotation = 90;
                                    picture.HorizontalPosition += 32;
                                    picture.VerticalPosition = y + 8 + ((verticalValue - 75) * verticalIndex);
                                }

                                if (a3PageColum == false)
                                {
                                    horizontalIndex += 1;
                                }
                                else if (a3PageColum == true)
                                {
                                    verticalIndex += 1;
                                }

                                if (horizontalIndex == 3 && verticalIndex < 4 && a3PageColum == false)
                                {
                                    horizontalIndex = 0;
                                    verticalIndex += 1;
                                }

                                if (verticalIndex == 4 && a3PageColum == false)
                                {
                                    a3PageColum = true;
                                    verticalIndex = 0;
                                    horizontalIndex = 3;
                                }

                                picture.Width = width;
                                picture.Height = height;

                                picture.TextWrappingStyle = TextWrappingStyle.InFrontOfText;
                            }
                        }
                    }

                    if (pageSize == "0")
                    {
                        if (pageSide == "1")
                        {
                            Section sectionLastPage = document.Sections[0];

                            Paragraph paragraphLastPage = sectionLastPage.Paragraphs[0];
                            paragraphLastPage.AppendBreak(BreakType.PageBreak);
                            verticalIndex = 0;
                            horizontalIndex = 0;
                            sideBackground = true;

                            for (int i2 = 0; i2 < 9; i2++)
                            {
                                DocPicture pictureLastPage = sectionLastPage.Paragraphs[0].AppendPicture(Image.FromFile($"{Application.StartupPath}\\{"YgoBackCard.png"}"));
                                pictureLastPage.HorizontalPosition = x + (horizontalValue * horizontalIndex);
                                pictureLastPage.VerticalPosition = y + (verticalValue * verticalIndex);

                                horizontalIndex += 1;

                                if (horizontalIndex > 2)
                                {
                                    horizontalIndex = 0;
                                    verticalIndex += 1;
                                }

                                pictureLastPage.Width = width;
                                pictureLastPage.Height = height;

                                pictureLastPage.TextWrappingStyle = TextWrappingStyle.InFrontOfText;
                            }

                            sideBackground = false;
                            horizontalIndex = 0;
                            verticalIndex = 0;
                        }
                    }
                    else if (pageSize == "1")
                    {
                        if (pageSide == "1")
                        {
                            Section sectionLastPage = document.Sections[0];

                            Paragraph paragraphLastPage = sectionLastPage.Paragraphs[0];
                            paragraphLastPage.AppendBreak(BreakType.PageBreak);
                            verticalIndex = 0;
                            horizontalIndex = 0;
                            sideBackground = true;
                            a3PageColum = false;

                            for (int i2 = 0; i2 < 18; i2++)
                            {
                                DocPicture pictureLastPage = sectionLastPage.Paragraphs[0].AppendPicture(Image.FromFile($"{Application.StartupPath}\\{"YgoBackCard.png"}"));
                                pictureLastPage.HorizontalPosition = x + (horizontalValue * horizontalIndex);
                                pictureLastPage.VerticalPosition = y + 70 + (verticalValue * verticalIndex);

                                if (a3PageColum == true)
                                {
                                    pictureLastPage.Rotation = 90;
                                    pictureLastPage.HorizontalPosition += 32;
                                    pictureLastPage.VerticalPosition = y + 8 + ((verticalValue - 75) * verticalIndex);
                                }

                                if (a3PageColum == false)
                                {
                                    horizontalIndex += 1;
                                }
                                else if (a3PageColum == true)
                                {
                                    verticalIndex += 1;
                                }

                                if (horizontalIndex == 3 && verticalIndex < 4 && a3PageColum == false)
                                {
                                    horizontalIndex = 0;
                                    verticalIndex += 1;
                                }

                                if (verticalIndex == 4 && a3PageColum == false)
                                {
                                    a3PageColum = true;
                                    verticalIndex = 0;
                                    horizontalIndex = 3;
                                }

                                pictureLastPage.Width = width;
                                pictureLastPage.Height = height;

                                pictureLastPage.TextWrappingStyle = TextWrappingStyle.InFrontOfText;
                            }

                            sideBackground = false;
                            a3PageColum = false;
                            horizontalIndex = 0;
                            verticalIndex = 0;
                        }
                    }

                    if (fileFormat == "0")
                    {
                        exportFileName = ExportFileNameTextBox.Text + ".docx";
                        document.SaveToFile(userPath + "\\" + exportFileName, FileFormat.Docx);
                    }
                    else if (fileFormat == "1")
                    {
                        exportFileName = ExportFileNameTextBox.Text + ".pdf";
                        document.SaveToFile(userPath + "\\" + exportFileName, FileFormat.PDF);
                    }

                    MessageBox.Show("Xuất file thành công!\nĐường dẫn file tại " + userPath + "\\" + exportFileName, "Thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
