
namespace YugiohImagePrinter
{
    partial class frmPlayMusic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlayMusic));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.ltbListMusic = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListOn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(365, 274);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // ltbListMusic
            // 
            this.ltbListMusic.FormattingEnabled = true;
            this.ltbListMusic.Location = new System.Drawing.Point(383, 43);
            this.ltbListMusic.Name = "ltbListMusic";
            this.ltbListMusic.Size = new System.Drawing.Size(274, 212);
            this.ltbListMusic.TabIndex = 1;
            this.ltbListMusic.DoubleClick += new System.EventHandler(this.ltbListMusic_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách bài hát";
            // 
            // btnListOn
            // 
            this.btnListOn.Location = new System.Drawing.Point(559, 263);
            this.btnListOn.Name = "btnListOn";
            this.btnListOn.Size = new System.Drawing.Size(98, 23);
            this.btnListOn.TabIndex = 3;
            this.btnListOn.Text = "Chọn danh sách";
            this.btnListOn.UseVisualStyleBackColor = true;
            this.btnListOn.Click += new System.EventHandler(this.btnListOn_Click);
            // 
            // frmPlayMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 298);
            this.Controls.Add(this.btnListOn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ltbListMusic);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPlayMusic";
            this.Text = "Trình phát nhạc";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox ltbListMusic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListOn;
    }
}