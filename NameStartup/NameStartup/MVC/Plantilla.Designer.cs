namespace NameStartup.MVC
{
    partial class Plantilla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plantilla));
            this.panel_progressBar = new System.Windows.Forms.Panel();
            this.ProgressBar1 = new Telerik.WinControls.UI.RadProgressBar();
            this.label_progress = new System.Windows.Forms.Label();
            this.panel_progressBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_progressBar
            // 
            this.panel_progressBar.BackColor = System.Drawing.Color.Transparent;
            this.panel_progressBar.Controls.Add(this.label_progress);
            this.panel_progressBar.Controls.Add(this.ProgressBar1);
            this.panel_progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_progressBar.Location = new System.Drawing.Point(8, 716);
            this.panel_progressBar.Name = "panel_progressBar";
            this.panel_progressBar.Size = new System.Drawing.Size(1354, 26);
            this.panel_progressBar.TabIndex = 0;
            this.panel_progressBar.Visible = false;
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.ProgressBar1.ImageIndex = -1;
            this.ProgressBar1.ImageKey = "";
            this.ProgressBar1.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ProgressBar1.Location = new System.Drawing.Point(844, 0);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.SeparatorColor1 = System.Drawing.Color.White;
            this.ProgressBar1.SeparatorColor2 = System.Drawing.Color.White;
            this.ProgressBar1.SeparatorColor3 = System.Drawing.Color.White;
            this.ProgressBar1.SeparatorColor4 = System.Drawing.Color.White;
            this.ProgressBar1.Size = new System.Drawing.Size(510, 26);
            this.ProgressBar1.TabIndex = 0;
            this.ProgressBar1.Text = "radProgressBar1";
            // 
            // label_progress
            // 
            this.label_progress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_progress.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_progress.Location = new System.Drawing.Point(0, 0);
            this.label_progress.Name = "label_progress";
            this.label_progress.Size = new System.Drawing.Size(844, 26);
            this.label_progress.TabIndex = 1;
            this.label_progress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_progress.Visible = false;
            // 
            // Plantilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImage = global::NameStartup.Properties.Resources.myfenixCocco1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.panel_progressBar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Plantilla";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "Plantilla";
            this.panel_progressBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel_progressBar;
        public Telerik.WinControls.UI.RadProgressBar ProgressBar1;
        public System.Windows.Forms.Label label_progress;
    }
}