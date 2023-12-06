
namespace YugiohImagePrinter
{
    partial class frmChangeDir
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDirOnline = new System.Windows.Forms.TextBox();
            this.txtDirOffline = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDirOffline = new System.Windows.Forms.Button();
            this.btnDirOnline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đường dẫn tải ảnh (Online)";
            // 
            // txtDirOnline
            // 
            this.txtDirOnline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDirOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirOnline.Location = new System.Drawing.Point(324, 50);
            this.txtDirOnline.Name = "txtDirOnline";
            this.txtDirOnline.ReadOnly = true;
            this.txtDirOnline.Size = new System.Drawing.Size(322, 34);
            this.txtDirOnline.TabIndex = 1;
            // 
            // txtDirOffline
            // 
            this.txtDirOffline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDirOffline.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirOffline.Location = new System.Drawing.Point(324, 176);
            this.txtDirOffline.Name = "txtDirOffline";
            this.txtDirOffline.ReadOnly = true;
            this.txtDirOffline.Size = new System.Drawing.Size(322, 34);
            this.txtDirOffline.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đường dẫn ảnh (Offline)";
            // 
            // btnDirOffline
            // 
            this.btnDirOffline.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDirOffline.Image = global::YugiohImagePrinter.Properties.Resources.Gakuseisean_Ivista_2_Misc_New_Database;
            this.btnDirOffline.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDirOffline.Location = new System.Drawing.Point(526, 214);
            this.btnDirOffline.Name = "btnDirOffline";
            this.btnDirOffline.Size = new System.Drawing.Size(120, 60);
            this.btnDirOffline.TabIndex = 6;
            this.btnDirOffline.Text = "Browser";
            this.btnDirOffline.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDirOffline.UseVisualStyleBackColor = true;
            this.btnDirOffline.Click += new System.EventHandler(this.btnDirOffline_Click);
            // 
            // btnDirOnline
            // 
            this.btnDirOnline.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDirOnline.Image = global::YugiohImagePrinter.Properties.Resources.Gakuseisean_Ivista_2_Misc_New_Database;
            this.btnDirOnline.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDirOnline.Location = new System.Drawing.Point(526, 88);
            this.btnDirOnline.Name = "btnDirOnline";
            this.btnDirOnline.Size = new System.Drawing.Size(120, 60);
            this.btnDirOnline.TabIndex = 5;
            this.btnDirOnline.Text = "Browser";
            this.btnDirOnline.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDirOnline.UseVisualStyleBackColor = true;
            this.btnDirOnline.Click += new System.EventHandler(this.btnDirOnline_Click);
            // 
            // frmChangeDir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(658, 314);
            this.Controls.Add(this.btnDirOffline);
            this.Controls.Add(this.btnDirOnline);
            this.Controls.Add(this.txtDirOffline);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDirOnline);
            this.Controls.Add(this.label1);
            this.Name = "frmChangeDir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay đổi đường dẫn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDirOnline;
        private System.Windows.Forms.TextBox txtDirOffline;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDirOnline;
        private System.Windows.Forms.Button btnDirOffline;
    }
}