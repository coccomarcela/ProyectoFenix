namespace NameStartup.Vistas
{
    partial class Form_Bienvenida
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
            this.components = new System.ComponentModel.Container();
            this.txt_NameProyect = new System.Windows.Forms.TextBox();
            this.projectxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.list_ProyectosExistentes = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel_progressBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectxBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_progressBar
            // 
            this.panel_progressBar.Location = new System.Drawing.Point(8, 522);
            this.panel_progressBar.Size = new System.Drawing.Size(956, 26);
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(446, 0);
            this.ProgressBar1.SeparatorGradientPercentage1 = 0.4F;
            this.ProgressBar1.SeparatorGradientPercentage2 = 0.6F;
            this.ProgressBar1.StepWidth = 14;
            // 
            // label_progress
            // 
            this.label_progress.Size = new System.Drawing.Size(446, 26);
            // 
            // txt_NameProyect
            // 
            this.txt_NameProyect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_NameProyect.Location = new System.Drawing.Point(742, 337);
            this.txt_NameProyect.Name = "txt_NameProyect";
            this.txt_NameProyect.Size = new System.Drawing.Size(217, 27);
            this.txt_NameProyect.TabIndex = 1;
            this.txt_NameProyect.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_NameProyect_KeyDown);
            // 
            // projectxBindingSource
            // 
            this.projectxBindingSource.DataSource = typeof(NameStartup.Datos.Projectx);
            // 
            // list_ProyectosExistentes
            // 
            this.list_ProyectosExistentes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.list_ProyectosExistentes.BackColor = System.Drawing.Color.Azure;
            this.list_ProyectosExistentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_ProyectosExistentes.DataSource = this.projectxBindingSource;
            this.list_ProyectosExistentes.DisplayMember = "Name";
            this.list_ProyectosExistentes.FormattingEnabled = true;
            this.list_ProyectosExistentes.ItemHeight = 19;
            this.list_ProyectosExistentes.Location = new System.Drawing.Point(742, 59);
            this.list_ProyectosExistentes.Name = "list_ProyectosExistentes";
            this.list_ProyectosExistentes.Size = new System.Drawing.Size(217, 209);
            this.list_ProyectosExistentes.TabIndex = 3;
            this.list_ProyectosExistentes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_ProyectosExistentes_MouseClick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(740, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 63);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingrese el Nombre para un Proyecto nuevo (Luego presione Enter)";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(742, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 43);
            this.label3.TabIndex = 8;
            this.label3.Text = "Seleccione Un proyecto existente";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form_Bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 556);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.list_ProyectosExistentes);
            this.Controls.Add(this.txt_NameProyect);
            this.Name = "Form_Bienvenida";
            this.Text = "Form_Bienvenida";
            this.Load += new System.EventHandler(this.Form_Bienvenida_Load);
            this.Controls.SetChildIndex(this.txt_NameProyect, 0);
            this.Controls.SetChildIndex(this.list_ProyectosExistentes, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.panel_progressBar, 0);
            this.panel_progressBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectxBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NameProyect;
        private System.Windows.Forms.BindingSource projectxBindingSource;
        private System.Windows.Forms.ListBox list_ProyectosExistentes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}