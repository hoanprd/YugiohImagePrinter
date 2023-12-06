
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
            this.txtDecklistPath = new System.Windows.Forms.TextBox();
            this.ExportFileNameTextBox = new System.Windows.Forms.TextBox();
            this.AddPathButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbUsingData = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đường dẫn decklist:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên xuất file:";
            // 
            // txtDecklistPath
            // 
            this.txtDecklistPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDecklistPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecklistPath.Location = new System.Drawing.Point(213, 24);
            this.txtDecklistPath.Name = "txtDecklistPath";
            this.txtDecklistPath.ReadOnly = true;
            this.txtDecklistPath.Size = new System.Drawing.Size(332, 29);
            this.txtDecklistPath.TabIndex = 4;
            // 
            // ExportFileNameTextBox
            // 
            this.ExportFileNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportFileNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportFileNameTextBox.Location = new System.Drawing.Point(213, 97);
            this.ExportFileNameTextBox.Name = "ExportFileNameTextBox";
            this.ExportFileNameTextBox.Size = new System.Drawing.Size(332, 29);
            this.ExportFileNameTextBox.TabIndex = 5;
            this.ExportFileNameTextBox.Text = "PRD";
            this.ExportFileNameTextBox.TextChanged += new System.EventHandler(this.ExportFileNameTextBox_TextChanged);
            // 
            // AddPathButton
            // 
            this.AddPathButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AddPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPathButton.Location = new System.Drawing.Point(562, 24);
            this.AddPathButton.Name = "AddPathButton";
            this.AddPathButton.Size = new System.Drawing.Size(102, 29);
            this.AddPathButton.TabIndex = 6;
            this.AddPathButton.Text = "Add";
            this.AddPathButton.UseVisualStyleBackColor = true;
            this.AddPathButton.Click += new System.EventHandler(this.AddPathButton_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dữ liệu:";
            // 
            // cbbUsingData
            // 
            this.cbbUsingData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbUsingData.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbUsingData.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbUsingData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUsingData.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbUsingData.FormattingEnabled = true;
            this.cbbUsingData.Items.AddRange(new object[] {
            "Online data",
            "Offline data"});
            this.cbbUsingData.Location = new System.Drawing.Point(213, 173);
            this.cbbUsingData.Margin = new System.Windows.Forms.Padding(2);
            this.cbbUsingData.Name = "cbbUsingData";
            this.cbbUsingData.Size = new System.Drawing.Size(332, 30);
            this.cbbUsingData.TabIndex = 13;
            this.cbbUsingData.SelectedIndexChanged += new System.EventHandler(this.UsingDataComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(12, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(584, 15);
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
            this.ConfirmButton.Location = new System.Drawing.Point(405, 329);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(128, 57);
            this.ConfirmButton.TabIndex = 11;
            this.ConfirmButton.Text = "Xác nhận dữ liệu";
            this.ConfirmButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportButton.Image = global::YugiohImagePrinter.Properties.Resources.Aha_Soft_Universal_Shop_Print1;
            this.ExportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExportButton.Location = new System.Drawing.Point(538, 329);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(128, 57);
            this.ExportButton.TabIndex = 0;
            this.ExportButton.Text = "Xuất file in";
            this.ExportButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // frmYugiohPrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(676, 396);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbUsingData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.AddPathButton);
            this.Controls.Add(this.ExportFileNameTextBox);
            this.Controls.Add(this.txtDecklistPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExportButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDecklistPath;
        private System.Windows.Forms.TextBox ExportFileNameTextBox;
        private System.Windows.Forms.Button AddPathButton;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbUsingData;
        private System.Windows.Forms.Label label6;
    }
}

