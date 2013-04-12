namespace NameStartup.Vistas
{
    partial class Form_AboutMy
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
            this.webBrowser_Perfil = new System.Windows.Forms.WebBrowser();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser_Perfil
            // 
            this.webBrowser_Perfil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser_Perfil.Location = new System.Drawing.Point(381, 217);
            this.webBrowser_Perfil.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_Perfil.Name = "webBrowser_Perfil";
            this.webBrowser_Perfil.Size = new System.Drawing.Size(598, 462);
            this.webBrowser_Perfil.TabIndex = 5;
            this.webBrowser_Perfil.Url = new System.Uri("http://www.linkedin.com/pub/marcela-elizabet-cocco/18/1a7/819", System.UriKind.Absolute);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NameStartup.Properties.Resources.Perfil;
            this.pictureBox1.Location = new System.Drawing.Point(6, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.webBrowser1.Location = new System.Drawing.Point(6, 217);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(369, 459);
            this.webBrowser1.TabIndex = 6;
            this.webBrowser1.Url = new System.Uri("https://twitter.com/coccomarcela", System.UriKind.Absolute);
            // 
            // Form_AboutMy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 690);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.webBrowser_Perfil);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_AboutMy";
            this.Text = "Form_AboutMy";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser_Perfil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}