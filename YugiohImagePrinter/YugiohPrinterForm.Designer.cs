
namespace YugiohImagePrinter
{
    partial class YugiohPrinterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YugiohPrinterForm));
            this.ExportButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DecklistPathTextBox = new System.Windows.Forms.TextBox();
            this.ExportFileNameTextBox = new System.Windows.Forms.TextBox();
            this.AddPathButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AddDataPicPathButton = new System.Windows.Forms.Button();
            this.DataPicPathTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.UsingDataComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ExportButton
            // 
            this.ExportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportButton.Location = new System.Drawing.Point(484, 261);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(128, 64);
            this.ExportButton.TabIndex = 0;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.Red;
            this.ExitButton.Location = new System.Drawing.Point(16, 262);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(128, 64);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Decklist path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Export file name:";
            // 
            // DecklistPathTextBox
            // 
            this.DecklistPathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecklistPathTextBox.Location = new System.Drawing.Point(217, 17);
            this.DecklistPathTextBox.Name = "DecklistPathTextBox";
            this.DecklistPathTextBox.ReadOnly = true;
            this.DecklistPathTextBox.Size = new System.Drawing.Size(276, 29);
            this.DecklistPathTextBox.TabIndex = 4;
            // 
            // ExportFileNameTextBox
            // 
            this.ExportFileNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportFileNameTextBox.Location = new System.Drawing.Point(217, 65);
            this.ExportFileNameTextBox.Name = "ExportFileNameTextBox";
            this.ExportFileNameTextBox.Size = new System.Drawing.Size(276, 29);
            this.ExportFileNameTextBox.TabIndex = 5;
            this.ExportFileNameTextBox.Text = "PRD";
            this.ExportFileNameTextBox.TextChanged += new System.EventHandler(this.ExportFileNameTextBox_TextChanged);
            // 
            // AddPathButton
            // 
            this.AddPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPathButton.Location = new System.Drawing.Point(510, 17);
            this.AddPathButton.Name = "AddPathButton";
            this.AddPathButton.Size = new System.Drawing.Size(102, 29);
            this.AddPathButton.TabIndex = 6;
            this.AddPathButton.Text = "Add";
            this.AddPathButton.UseVisualStyleBackColor = true;
            this.AddPathButton.Click += new System.EventHandler(this.AddPathButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(505, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = ".docx";
            // 
            // AddDataPicPathButton
            // 
            this.AddDataPicPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDataPicPathButton.Location = new System.Drawing.Point(510, 117);
            this.AddDataPicPathButton.Name = "AddDataPicPathButton";
            this.AddDataPicPathButton.Size = new System.Drawing.Size(102, 29);
            this.AddDataPicPathButton.TabIndex = 10;
            this.AddDataPicPathButton.Text = "Add";
            this.AddDataPicPathButton.UseVisualStyleBackColor = true;
            this.AddDataPicPathButton.Click += new System.EventHandler(this.AddDataPicPathButton_Click);
            // 
            // DataPicPathTextBox
            // 
            this.DataPicPathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataPicPathTextBox.Location = new System.Drawing.Point(217, 117);
            this.DataPicPathTextBox.Name = "DataPicPathTextBox";
            this.DataPicPathTextBox.ReadOnly = true;
            this.DataPicPathTextBox.Size = new System.Drawing.Size(276, 29);
            this.DataPicPathTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Picture data path:";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.Location = new System.Drawing.Point(255, 261);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(128, 64);
            this.ConfirmButton.TabIndex = 11;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Using data:";
            // 
            // UsingDataComboBox
            // 
            this.UsingDataComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.UsingDataComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.UsingDataComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UsingDataComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsingDataComboBox.FormattingEnabled = true;
            this.UsingDataComboBox.Items.AddRange(new object[] {
            "Online data",
            "Offline data"});
            this.UsingDataComboBox.Location = new System.Drawing.Point(217, 171);
            this.UsingDataComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UsingDataComboBox.Name = "UsingDataComboBox";
            this.UsingDataComboBox.Size = new System.Drawing.Size(276, 30);
            this.UsingDataComboBox.TabIndex = 13;
            this.UsingDataComboBox.SelectedIndexChanged += new System.EventHandler(this.UsingDataComboBox_SelectedIndexChanged);
            // 
            // YugiohPrinterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 336);
            this.Controls.Add(this.UsingDataComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.AddDataPicPathButton);
            this.Controls.Add(this.DataPicPathTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddPathButton);
            this.Controls.Add(this.ExportFileNameTextBox);
            this.Controls.Add(this.DecklistPathTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ExportButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "YugiohPrinterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yugioh Printer";
            this.Load += new System.EventHandler(this.YugiohPrinterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DecklistPathTextBox;
        private System.Windows.Forms.TextBox ExportFileNameTextBox;
        private System.Windows.Forms.Button AddPathButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddDataPicPathButton;
        private System.Windows.Forms.TextBox DataPicPathTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox UsingDataComboBox;
    }
}

