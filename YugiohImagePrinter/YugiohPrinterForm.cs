﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;

namespace YugiohImagePrinter
{
    public partial class YugiohPrinterForm : Form
    {
        public static string decklistPath, dataPicPath, exportFileName;
        public static float x = -35f, y = -50f, width = 81.9899944414f, height = 243.764172336f;

        int horizontalIndex = 0, verticalIndex = 0;
        float horizontalValue = 180, verticalValue = 250;
        string userPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public YugiohPrinterForm()
        {
            InitializeComponent();
            dataPicPath = "datapics";
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
            try
            {
                var lines = File.ReadLines(decklistPath).Skip(1).ToArray();

                Document document = new Document();

                document.LoadFromFile("Doc1.docx");

                foreach (Section section in document.Sections)
                {
                    section.PageSetup.PageSize = PageSize.A4;
                }

                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i] != "#main" && lines[i] != "#extra" && lines[i] != "!side" && lines[i] != "" && lines != null)
                    {
                        Section section = document.Sections[0];

                        if (i % 9 == 0 && i != 0)
                        {
                            Paragraph paragraph = section.Paragraphs[0];
                            paragraph.AppendBreak(BreakType.PageBreak);
                            verticalIndex = 0;
                        }

                        DocPicture picture = section.Paragraphs[0].AppendPicture(Image.FromFile(dataPicPath + "\\" + lines[i] + ".jpg"));
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

                document.SaveToFile(userPath + "\\" + exportFileName, FileFormat.Docx);
                Console.WriteLine("Done!");
            }
            catch
            {
                MessageBox.Show("Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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