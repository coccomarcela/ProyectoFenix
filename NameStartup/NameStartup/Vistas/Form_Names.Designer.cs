namespace NameStartup.Vistas
{
    partial class Form_Names
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
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor1 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor3 = new Telerik.WinControls.Data.SortDescriptor();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.windows7Theme1 = new Telerik.WinControls.Themes.Windows7Theme();
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            this.lbl_Proyecto = new System.Windows.Forms.Label();
            this.radGridView2 = new Telerik.WinControls.UI.RadGridView();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.nameGxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameGxBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Names";
            this.bindingSource1.DataSource = this.nameGxBindingSource;
            // 
            // lbl_Proyecto
            // 
            this.lbl_Proyecto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Proyecto.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Proyecto.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Proyecto.ForeColor = System.Drawing.Color.White;
            this.lbl_Proyecto.Location = new System.Drawing.Point(8, 8);
            this.lbl_Proyecto.Name = "lbl_Proyecto";
            this.lbl_Proyecto.Size = new System.Drawing.Size(768, 23);
            this.lbl_Proyecto.TabIndex = 13;
            this.lbl_Proyecto.Text = "Categorias Disponibles";
            this.lbl_Proyecto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radGridView2
            // 
            this.radGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGridView2.BackColor = System.Drawing.Color.Azure;
            this.radGridView2.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView2.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.radGridView2.ForeColor = System.Drawing.Color.Navy;
            this.radGridView2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView2.Location = new System.Drawing.Point(315, 172);
            // 
            // radGridView2
            // 
            this.radGridView2.MasterTemplate.AllowAddNewRow = false;
            this.radGridView2.MasterTemplate.AutoGenerateColumns = false;
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.FieldName = "MeGusta";
            gridViewCheckBoxColumn1.HeaderText = "Me-Gusta";
            gridViewCheckBoxColumn1.IsAutoGenerated = true;
            gridViewCheckBoxColumn1.MinWidth = 20;
            gridViewCheckBoxColumn1.Name = "MeGusta";
            gridViewCheckBoxColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewCheckBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCheckBoxColumn1.Width = 115;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Name";
            gridViewTextBoxColumn1.HeaderText = "Name";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Name";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 382;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "LongitudPalabra";
            gridViewDecimalColumn1.HeaderText = "L";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "LongitudPalabra";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewDecimalColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;
            gridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn1.Width = 58;
            this.radGridView2.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCheckBoxColumn1,
            gridViewTextBoxColumn1,
            gridViewDecimalColumn1});
            this.radGridView2.MasterTemplate.DataSource = this.bindingSource1;
            this.radGridView2.MasterTemplate.EnableAlternatingRowColor = true;
            this.radGridView2.MasterTemplate.EnableFiltering = true;
            this.radGridView2.MasterTemplate.ShowFilteringRow = false;
            this.radGridView2.MasterTemplate.ShowHeaderCellButtons = true;
            sortDescriptor1.PropertyName = "MeGusta";
            sortDescriptor2.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor2.PropertyName = "LongitudPalabra";
            this.radGridView2.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1,
            sortDescriptor2});
            this.radGridView2.Name = "radGridView2";
            this.radGridView2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // 
            // 
            this.radGridView2.RootElement.ForeColor = System.Drawing.Color.Navy;
            this.radGridView2.ShowHeaderCellButtons = true;
            this.radGridView2.Size = new System.Drawing.Size(463, 268);
            this.radGridView2.TabIndex = 12;
            this.radGridView2.Text = "radGridView2";
            // 
            // radGridView1
            // 
            this.radGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.radGridView1.AutoSizeRows = true;
            this.radGridView1.BackColor = System.Drawing.Color.Azure;
            this.radGridView1.BeginEditMode = Telerik.WinControls.RadGridViewBeginEditMode.BeginEditOnF2;
            this.radGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGridView1.ForeColor = System.Drawing.Color.Navy;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(11, 100);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Palabras";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Palabras";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Palabras";
            gridViewTextBoxColumn2.Width = 275;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Categorias";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Categorias";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "Categorias";
            gridViewTextBoxColumn3.Width = 244;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.radGridView1.MasterTemplate.DataSource = this.nameGxBindingSource;
            this.radGridView1.MasterTemplate.EnableAlternatingRowColor = true;
            this.radGridView1.MasterTemplate.EnableFiltering = true;
            sortDescriptor3.PropertyName = "Categorias";
            groupDescriptor1.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor3});
            this.radGridView1.MasterTemplate.GroupDescriptors.AddRange(new Telerik.WinControls.Data.GroupDescriptor[] {
            groupDescriptor1});
            this.radGridView1.MasterTemplate.ShowFilteringRow = false;
            this.radGridView1.MasterTemplate.ShowHeaderCellButtons = true;
            this.radGridView1.MasterTemplate.ShowRowHeaderColumn = false;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // 
            // 
            this.radGridView1.RootElement.ForeColor = System.Drawing.Color.Navy;
            this.radGridView1.ShowHeaderCellButtons = true;
            this.radGridView1.Size = new System.Drawing.Size(297, 368);
            this.radGridView1.TabIndex = 2;
            this.radGridView1.Text = "radGridView1";
            // 
            // nameGxBindingSource
            // 
            this.nameGxBindingSource.DataSource = typeof(NameStartup.Datos.NameGx);
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Name", true));
            this.lbl_Name.Font = new System.Drawing.Font("Tahoma", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.White;
            this.lbl_Name.Image = global::NameStartup.Properties.Resources.ksplash;
            this.lbl_Name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Name.Location = new System.Drawing.Point(309, 33);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(465, 65);
            this.lbl_Name.TabIndex = 11;
            this.lbl_Name.Text = "Seleccione Un proyecto existente";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nameGxBindingSource, "Palabras", true));
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(318, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 43);
            this.label1.TabIndex = 10;
            this.label1.Text = "Seleccione Un proyecto existente";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Navy;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nameGxBindingSource, "Categorias", true));
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(319, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(459, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Seleccione Un proyecto existente";
            // 
            // Form_Names
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(784, 479);
            this.Controls.Add(this.lbl_Proyecto);
            this.Controls.Add(this.radGridView2);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "Form_Names";
            this.Text = "Form_Names";
            this.Load += new System.EventHandler(this.Form_Names_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameGxBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource nameGxBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.Themes.Windows7Theme windows7Theme1;
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Name;
        private Telerik.WinControls.UI.RadGridView radGridView2;
        private System.Windows.Forms.Label lbl_Proyecto;

    }
}