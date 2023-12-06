
namespace YugiohImagePrinter
{
    partial class frmYugiohPrinter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYugiohPrinter));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DecklistPathTextBox = new System.Windows.Forms.TextBox();
            this.ExportFileNameTextBox = new System.Windows.Forms.TextBox();
            this.AddPathButton = new System.Windows.Forms.Button();
            this.AddDataPicPathButton = new System.Windows.Forms.Button();
            this.DataPicPathTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UsingDataComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbtTwoSide = new System.Windows.Forms.RadioButton();
            this.rbtOneSide = new System.Windows.Forms.RadioButton();
            this.cbbFileExtend = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đường dẫn decklist:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên xuất file:";
            // 
            // DecklistPathTextBox
            // 
            this.DecklistPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DecklistPathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecklistPathTextBox.Location = new System.Drawing.Point(267, 30);
            this.DecklistPathTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DecklistPathTextBox.Name = "DecklistPathTextBox";
            this.DecklistPathTextBox.ReadOnly = true;
            this.DecklistPathTextBox.Size = new System.Drawing.Size(459, 34);
            this.DecklistPathTextBox.TabIndex = 4;
            // 
            // ExportFileNameTextBox
            // 
            this.ExportFileNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportFileNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportFileNameTextBox.Location = new System.Drawing.Point(267, 89);
            this.ExportFileNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ExportFileNameTextBox.Name = "ExportFileNameTextBox";
            this.ExportFileNameTextBox.Size = new System.Drawing.Size(459, 34);
            this.ExportFileNameTextBox.TabIndex = 5;
            this.ExportFileNameTextBox.Text = "PRD";
            this.ExportFileNameTextBox.TextChanged += new System.EventHandler(this.ExportFileNameTextBox_TextChanged);
            // 
            // AddPathButton
            // 
            this.AddPathButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AddPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPathButton.Location = new System.Drawing.Point(750, 30);
            this.AddPathButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddPathButton.Name = "AddPathButton";
            this.AddPathButton.Size = new System.Drawing.Size(136, 36);
            this.AddPathButton.TabIndex = 6;
            this.AddPathButton.Text = "Add";
            this.AddPathButton.UseVisualStyleBackColor = true;
            this.AddPathButton.Click += new System.EventHandler(this.AddPathButton_Click);
            // 
            // AddDataPicPathButton
            // 
            this.AddDataPicPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDataPicPathButton.Location = new System.Drawing.Point(680, 369);
            this.AddDataPicPathButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddDataPicPathButton.Name = "AddDataPicPathButton";
            this.AddDataPicPathButton.Size = new System.Drawing.Size(136, 36);
            this.AddDataPicPathButton.TabIndex = 10;
            this.AddDataPicPathButton.Text = "Add";
            this.AddDataPicPathButton.UseVisualStyleBackColor = true;
            this.AddDataPicPathButton.Click += new System.EventHandler(this.AddDataPicPathButton_Click);
            // 
            // DataPicPathTextBox
            // 
            this.DataPicPathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataPicPathTextBox.Location = new System.Drawing.Point(289, 371);
            this.DataPicPathTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DataPicPathTextBox.Name = "DataPicPathTextBox";
            this.DataPicPathTextBox.ReadOnly = true;
            this.DataPicPathTextBox.Size = new System.Drawing.Size(367, 34);
            this.DataPicPathTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 373);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Picture data path:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dữ liệu:";
            // 
            // UsingDataComboBox
            // 
            this.UsingDataComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UsingDataComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.UsingDataComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.UsingDataComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UsingDataComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsingDataComboBox.FormattingEnabled = true;
            this.UsingDataComboBox.Items.AddRange(new object[] {
            "Online data",
            "Offline data"});
            this.UsingDataComboBox.Location = new System.Drawing.Point(267, 155);
            this.UsingDataComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsingDataComboBox.Name = "UsingDataComboBox";
            this.UsingDataComboBox.Size = new System.Drawing.Size(459, 37);
            this.UsingDataComboBox.TabIndex = 13;
            this.UsingDataComboBox.SelectedIndexChanged += new System.EventHandler(this.UsingDataComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(19, 349);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(677, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "*Note: The alternative art will not include and it will get error when you using " +
    "online data!!!";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.Image = global::YugiohImagePrinter.Properties.Resources.Hopstarter_Soft_Scraps_Text_Edit;
            this.ConfirmButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConfirmButton.Location = new System.Drawing.Point(540, 405);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(4);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(170, 70);
            this.ConfirmButton.TabIndex = 11;
            this.ConfirmButton.Text = "Xác nhận dữ liệu";
            this.ConfirmButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExitButton.Image = global::YugiohImagePrinter.Properties.Resources.Visualpharm_Must_Have_Log_Out;
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location = new System.Drawing.Point(22, 405);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(170, 70);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Màn hình chính";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportButton.Image = global::YugiohImagePrinter.Properties.Resources.Aha_Soft_Universal_Shop_Print1;
            this.ExportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExportButton.Location = new System.Drawing.Point(718, 405);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(171, 70);
            this.ExportButton.TabIndex = 0;
            this.ExportButton.Text = "Xuất file in";
            this.ExportButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Đuôi file:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 293);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "Định dạng file:";
            // 
            // rbtTwoSide
            // 
            this.rbtTwoSide.AutoSize = true;
            this.rbtTwoSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTwoSide.Location = new System.Drawing.Point(402, 294);
            this.rbtTwoSide.Name = "rbtTwoSide";
            this.rbtTwoSide.Size = new System.Drawing.Size(81, 29);
            this.rbtTwoSide.TabIndex = 20;
            this.rbtTwoSide.Text = "2 mặt";
            this.rbtTwoSide.UseVisualStyleBackColor = true;
            // 
            // rbtOneSide
            // 
            this.rbtOneSide.AutoSize = true;
            this.rbtOneSide.Checked = true;
            this.rbtOneSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtOneSide.Location = new System.Drawing.Point(267, 294);
            this.rbtOneSide.Name = "rbtOneSide";
            this.rbtOneSide.Size = new System.Drawing.Size(81, 29);
            this.rbtOneSide.TabIndex = 19;
            this.rbtOneSide.TabStop = true;
            this.rbtOneSide.Text = "1 mặt";
            this.rbtOneSide.UseVisualStyleBackColor = true;
            // 
            // cbbFileExtend
            // 
            this.cbbFileExtend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbFileExtend.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbFileExtend.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbFileExtend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFileExtend.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFileExtend.FormattingEnabled = true;
            this.cbbFileExtend.Items.AddRange(new object[] {
            "Online data",
            "Offline data"});
            this.cbbFileExtend.Location = new System.Drawing.Point(267, 225);
            this.cbbFileExtend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbFileExtend.Name = "cbbFileExtend";
            this.cbbFileExtend.Size = new System.Drawing.Size(459, 37);
            this.cbbFileExtend.TabIndex = 21;
            // 
            // frmYugiohPrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(902, 488);
            this.Controls.Add(this.cbbFileExtend);
            this.Controls.Add(this.rbtTwoSide);
            this.Controls.Add(this.rbtOneSide);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UsingDataComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.AddDataPicPathButton);
            this.Controls.Add(this.DataPicPathTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddPathButton);
            this.Controls.Add(this.ExportFileNameTextBox);
            this.Controls.Add(this.DecklistPathTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ExportButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmYugiohPrinter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In card";
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
        private System.Windows.Forms.Button AddDataPicPathButton;
        private System.Windows.Forms.TextBox DataPicPathTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox UsingDataComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbtTwoSide;
        private System.Windows.Forms.RadioButton rbtOneSide;
        private System.Windows.Forms.ComboBox cbbFileExtend;
    }
}

