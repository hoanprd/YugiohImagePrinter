
namespace YugiohImagePrinter
{
    partial class frmEditExportFile
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
            this.cbbFileExtend = new System.Windows.Forms.ComboBox();
            this.rbtTwoSide = new System.Windows.Forms.RadioButton();
            this.rbtOneSide = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbPageSize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            ".docx",
            ".pdf"});
            this.cbbFileExtend.Location = new System.Drawing.Point(184, 49);
            this.cbbFileExtend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbFileExtend.Name = "cbbFileExtend";
            this.cbbFileExtend.Size = new System.Drawing.Size(459, 37);
            this.cbbFileExtend.TabIndex = 26;
            this.cbbFileExtend.SelectedValueChanged += new System.EventHandler(this.cbbFileExtend_SelectedValueChanged);
            // 
            // rbtTwoSide
            // 
            this.rbtTwoSide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtTwoSide.AutoSize = true;
            this.rbtTwoSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTwoSide.Location = new System.Drawing.Point(325, 203);
            this.rbtTwoSide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtTwoSide.Name = "rbtTwoSide";
            this.rbtTwoSide.Size = new System.Drawing.Size(81, 29);
            this.rbtTwoSide.TabIndex = 25;
            this.rbtTwoSide.Text = "2 mặt";
            this.rbtTwoSide.UseVisualStyleBackColor = true;
            this.rbtTwoSide.CheckedChanged += new System.EventHandler(this.rbtTwoSide_CheckedChanged);
            // 
            // rbtOneSide
            // 
            this.rbtOneSide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtOneSide.AutoSize = true;
            this.rbtOneSide.Checked = true;
            this.rbtOneSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtOneSide.Location = new System.Drawing.Point(184, 203);
            this.rbtOneSide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtOneSide.Name = "rbtOneSide";
            this.rbtOneSide.Size = new System.Drawing.Size(81, 29);
            this.rbtOneSide.TabIndex = 24;
            this.rbtOneSide.TabStop = true;
            this.rbtOneSide.Text = "1 mặt";
            this.rbtOneSide.UseVisualStyleBackColor = true;
            this.rbtOneSide.Click += new System.EventHandler(this.rbtOneSide_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(17, 206);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 24);
            this.label7.TabIndex = 23;
            this.label7.Text = "Mặt in:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Định dạng file:";
            // 
            // cbbPageSize
            // 
            this.cbbPageSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbPageSize.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbPageSize.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPageSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPageSize.FormattingEnabled = true;
            this.cbbPageSize.Items.AddRange(new object[] {
            "A4",
            "A3"});
            this.cbbPageSize.Location = new System.Drawing.Point(184, 127);
            this.cbbPageSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbPageSize.Name = "cbbPageSize";
            this.cbbPageSize.Size = new System.Drawing.Size(459, 37);
            this.cbbPageSize.TabIndex = 28;
            this.cbbPageSize.SelectedValueChanged += new System.EventHandler(this.cbbPageSize_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Khổ giấy:";
            // 
            // frmEditExportFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(659, 314);
            this.Controls.Add(this.cbbPageSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbFileExtend);
            this.Controls.Add(this.rbtTwoSide);
            this.Controls.Add(this.rbtOneSide);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEditExportFile";
            this.Text = "Chỉnh sửa file xuất";
            this.Load += new System.EventHandler(this.frmEditExportFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbFileExtend;
        private System.Windows.Forms.RadioButton rbtTwoSide;
        private System.Windows.Forms.RadioButton rbtOneSide;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbPageSize;
        private System.Windows.Forms.Label label1;
    }
}