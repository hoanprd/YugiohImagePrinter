
namespace YugiohImagePrinter
{
    partial class frmDefault
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.pbxMain = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.SystemColors.Control;
            this.panelMain.Controls.Add(this.pbxMain);
            this.panelMain.Location = new System.Drawing.Point(-1, -3);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(626, 340);
            this.panelMain.TabIndex = 7;
            // 
            // pbxMain
            // 
            this.pbxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxMain.Image = global::YugiohImagePrinter.Properties.Resources.Atelier_Resna_08_28_23;
            this.pbxMain.Location = new System.Drawing.Point(0, 2);
            this.pbxMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxMain.Name = "pbxMain";
            this.pbxMain.Size = new System.Drawing.Size(626, 338);
            this.pbxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMain.TabIndex = 0;
            this.pbxMain.TabStop = false;
            // 
            // frmDefault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 336);
            this.Controls.Add(this.panelMain);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDefault";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn hình chính";
            this.Load += new System.EventHandler(this.frmDefault_Load);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pbxMain;
    }
}