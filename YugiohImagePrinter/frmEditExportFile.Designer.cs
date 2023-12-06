
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
            this.cbbFileExtend.Location = new System.Drawing.Point(138, 57);
            this.cbbFileExtend.Margin = new System.Windows.Forms.Padding(2);
            this.cbbFileExtend.Name = "cbbFileExtend";
            this.cbbFileExtend.Size = new System.Drawing.Size(345, 30);
            this.cbbFileExtend.TabIndex = 26;
            this.cbbFileExtend.SelectedValueChanged += new System.EventHandler(this.cbbFileExtend_SelectedValueChanged);
            // 
            // rbtTwoSide
            // 
            this.rbtTwoSide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtTwoSide.AutoSize = true;
            this.rbtTwoSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTwoSide.Location = new System.Drawing.Point(243, 155);
            this.rbtTwoSide.Margin = new System.Windows.Forms.Padding(2);
            this.rbtTwoSide.Name = "rbtTwoSide";
            this.rbtTwoSide.Size = new System.Drawing.Size(67, 24);
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
            this.rbtOneSide.Location = new System.Drawing.Point(138, 155);
            this.rbtOneSide.Margin = new System.Windows.Forms.Padding(2);
            this.rbtOneSide.Name = "rbtOneSide";
            this.rbtOneSide.Size = new System.Drawing.Size(67, 24);
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
            this.label7.Location = new System.Drawing.Point(13, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Định dạng file:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Đuôi file:";
            // 
            // frmEditExportFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(494, 255);
            this.Controls.Add(this.cbbFileExtend);
            this.Controls.Add(this.rbtTwoSide);
            this.Controls.Add(this.rbtOneSide);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
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
    }
}