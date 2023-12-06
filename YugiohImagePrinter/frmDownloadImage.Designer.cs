
namespace YugiohImagePrinter
{
    partial class frmDownloadImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDownloadImage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.UseDriverLinkButton = new System.Windows.Forms.Button();
            this.AgreeButton = new System.Windows.Forms.Button();
            this.DownloadCardImageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(119, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Warning: If you press the \"Download\" button that will download\r\nall the card imag" +
    "e from the url connect to ygoprodeck database.\r\nIt will take almost an hour to d" +
    "o this!!!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(119, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(563, 60);
            this.label2.TabIndex = 8;
            this.label2.Text = "Any trouble in the downloading process just press the \"Download\"\r\nuntil you get f" +
    "ull of the card database base on ygoprodeck.com\r\nOr you can get the driver link " +
    "downloaded here:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(16, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(800, 30);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "https://drive.google.com/drive/folders/1JXLhv2MFxmCRdCBqebnmnvB8Zw5MFl7Z?usp=shar" +
    "ing";
            // 
            // UseDriverLinkButton
            // 
            this.UseDriverLinkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UseDriverLinkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseDriverLinkButton.ForeColor = System.Drawing.Color.Navy;
            this.UseDriverLinkButton.Location = new System.Drawing.Point(335, 239);
            this.UseDriverLinkButton.Margin = new System.Windows.Forms.Padding(4);
            this.UseDriverLinkButton.Name = "UseDriverLinkButton";
            this.UseDriverLinkButton.Size = new System.Drawing.Size(171, 39);
            this.UseDriverLinkButton.TabIndex = 10;
            this.UseDriverLinkButton.Text = "Use driver link";
            this.UseDriverLinkButton.UseVisualStyleBackColor = true;
            this.UseDriverLinkButton.Click += new System.EventHandler(this.UseDriverLinkButton_Click);
            // 
            // AgreeButton
            // 
            this.AgreeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgreeButton.Image = global::YugiohImagePrinter.Properties.Resources.Iconshock_Cms_User_login;
            this.AgreeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgreeButton.Location = new System.Drawing.Point(335, 330);
            this.AgreeButton.Margin = new System.Windows.Forms.Padding(4);
            this.AgreeButton.Name = "AgreeButton";
            this.AgreeButton.Size = new System.Drawing.Size(170, 71);
            this.AgreeButton.TabIndex = 7;
            this.AgreeButton.Text = "Tôi đồng ý";
            this.AgreeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgreeButton.UseVisualStyleBackColor = true;
            this.AgreeButton.Click += new System.EventHandler(this.AgreeButton_Click);
            // 
            // DownloadCardImageButton
            // 
            this.DownloadCardImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadCardImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadCardImageButton.Image = global::YugiohImagePrinter.Properties.Resources.SAVEADD;
            this.DownloadCardImageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DownloadCardImageButton.Location = new System.Drawing.Point(645, 330);
            this.DownloadCardImageButton.Margin = new System.Windows.Forms.Padding(4);
            this.DownloadCardImageButton.Name = "DownloadCardImageButton";
            this.DownloadCardImageButton.Size = new System.Drawing.Size(171, 71);
            this.DownloadCardImageButton.TabIndex = 1;
            this.DownloadCardImageButton.Text = "Tải ảnh";
            this.DownloadCardImageButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DownloadCardImageButton.UseVisualStyleBackColor = true;
            this.DownloadCardImageButton.Click += new System.EventHandler(this.DownloadCardImageButton_Click);
            // 
            // frmDownloadImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(832, 414);
            this.Controls.Add(this.UseDriverLinkButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AgreeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DownloadCardImageButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDownloadImage";
            this.Text = "Tải ảnh";
            this.Load += new System.EventHandler(this.DownloadImageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DownloadCardImageButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AgreeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button UseDriverLinkButton;
    }
}