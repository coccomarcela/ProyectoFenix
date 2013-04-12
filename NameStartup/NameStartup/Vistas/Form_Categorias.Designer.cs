namespace NameStartup.Vistas
{
    partial class Form_Categorias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.wordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listWordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_CrearProyecto = new System.Windows.Forms.Button();
            this.descripcionLabel1 = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Proyecto = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.UrlTextBox = new System.Windows.Forms.ComboBox();
            this.btn_GenerarNames = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listWordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wordDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.listWordsBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView2.Location = new System.Drawing.Point(9, 414);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Azure;
            this.dataGridView2.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy;
            this.dataGridView2.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Cyan;
            this.dataGridView2.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Navy;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(334, 325);
            this.dataGridView2.TabIndex = 10;
            // 
            // wordDataGridViewTextBoxColumn
            // 
            this.wordDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.wordDataGridViewTextBoxColumn.DataPropertyName = "Word";
            this.wordDataGridViewTextBoxColumn.HeaderText = "Palabras Asociadas a la Categoria";
            this.wordDataGridViewTextBoxColumn.Name = "wordDataGridViewTextBoxColumn";
            // 
            // listWordsBindingSource
            // 
            this.listWordsBindingSource.DataMember = "ListWords";
            this.listWordsBindingSource.DataSource = this.categoryBindingSource;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(NameStartup.Datos.Category);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Palabras Por Categoria";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.categoryBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(9, 126);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Azure;
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Cyan;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Navy;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(334, 181);
            this.dataGridView1.TabIndex = 7;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 91;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 115;
            // 
            // btn_CrearProyecto
            // 
            this.btn_CrearProyecto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CrearProyecto.BackColor = System.Drawing.Color.Transparent;
            this.btn_CrearProyecto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_CrearProyecto.FlatAppearance.BorderSize = 0;
            this.btn_CrearProyecto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Magenta;
            this.btn_CrearProyecto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.btn_CrearProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CrearProyecto.Image = global::NameStartup.Properties.Resources.katuberling;
            this.btn_CrearProyecto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CrearProyecto.Location = new System.Drawing.Point(1180, 696);
            this.btn_CrearProyecto.Name = "btn_CrearProyecto";
            this.btn_CrearProyecto.Size = new System.Drawing.Size(179, 43);
            this.btn_CrearProyecto.TabIndex = 6;
            this.btn_CrearProyecto.Text = "Guardar Cambios";
            this.btn_CrearProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CrearProyecto.UseVisualStyleBackColor = false;
            this.btn_CrearProyecto.Click += new System.EventHandler(this.btn_CrearProyecto_Click);
            // 
            // descripcionLabel1
            // 
            this.descripcionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoryBindingSource, "Descripcion", true));
            this.descripcionLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionLabel1.Location = new System.Drawing.Point(13, 362);
            this.descripcionLabel1.Name = "descripcionLabel1";
            this.descripcionLabel1.Size = new System.Drawing.Size(331, 49);
            this.descripcionLabel1.TabIndex = 3;
            this.descripcionLabel1.Text = "label1";
            this.descripcionLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoryBindingSource, "Name", true));
            this.nameLabel1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel1.Location = new System.Drawing.Point(12, 337);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(332, 23);
            this.nameLabel1.TabIndex = 2;
            this.nameLabel1.Text = "Name Category";
            this.nameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nameLabel1.Click += new System.EventHandler(this.nameLabel1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Categorias Disponibles";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Proyecto
            // 
            this.lbl_Proyecto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Proyecto.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Proyecto.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Proyecto.Location = new System.Drawing.Point(8, 8);
            this.lbl_Proyecto.Name = "lbl_Proyecto";
            this.lbl_Proyecto.Size = new System.Drawing.Size(1354, 23);
            this.lbl_Proyecto.TabIndex = 11;
            this.lbl_Proyecto.Text = "Categorias Disponibles";
            this.lbl_Proyecto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(352, 80);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1007, 610);
            this.webBrowser1.TabIndex = 12;
            this.webBrowser1.Url = new System.Uri("http://www.sinonimos.com/", System.UriKind.Absolute);
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UrlTextBox.FormattingEnabled = true;
            this.UrlTextBox.Items.AddRange(new object[] {
            "http://www.sinonimos.com/",
            "http://diccionario.reverso.net/ingles-espanol/",
            "http://www.google.com.ar/",
            "http://translate.google.com.ar/?hl=es-419&tab=wT"});
            this.UrlTextBox.Location = new System.Drawing.Point(400, 50);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(959, 27);
            this.UrlTextBox.TabIndex = 13;
            this.UrlTextBox.Text = "http://www.sinonimos.com/";
            this.UrlTextBox.SelectionChangeCommitted += new System.EventHandler(this.UrlTextBox_SelectionChangeCommitted);
            this.UrlTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UrlTextBox_KeyDown);
            // 
            // btn_GenerarNames
            // 
            this.btn_GenerarNames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_GenerarNames.BackColor = System.Drawing.Color.Transparent;
            this.btn_GenerarNames.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_GenerarNames.FlatAppearance.BorderSize = 0;
            this.btn_GenerarNames.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_GenerarNames.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_GenerarNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GenerarNames.Image = global::NameStartup.Properties.Resources.bookmark;
            this.btn_GenerarNames.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GenerarNames.Location = new System.Drawing.Point(995, 696);
            this.btn_GenerarNames.Name = "btn_GenerarNames";
            this.btn_GenerarNames.Size = new System.Drawing.Size(179, 43);
            this.btn_GenerarNames.TabIndex = 14;
            this.btn_GenerarNames.Text = "Generar Nombres";
            this.btn_GenerarNames.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_GenerarNames.UseVisualStyleBackColor = false;
            this.btn_GenerarNames.Click += new System.EventHandler(this.btn_GenerarNames_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::NameStartup.Properties.Resources.connect_to_network;
            this.pictureBox1.Location = new System.Drawing.Point(349, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_GenerarNames);
            this.Controls.Add(this.UrlTextBox);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.lbl_Proyecto);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_CrearProyecto);
            this.Controls.Add(this.descripcionLabel1);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(this.label1);
            this.Name = "Form_Categorias";
            this.Text = "Form_Categorias";
            this.Load += new System.EventHandler(this.Form_Categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listWordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label descripcionLabel1;
        private System.Windows.Forms.Button btn_CrearProyecto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource listWordsBindingSource;
        private System.Windows.Forms.Label lbl_Proyecto;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ComboBox UrlTextBox;
        private System.Windows.Forms.Button btn_GenerarNames;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}