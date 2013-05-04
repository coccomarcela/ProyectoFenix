namespace PracticosLogMat.Vistas
{
    partial class Form_UnII_TP4_A_EJ_2C
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
            this.cbo_op1_tipoOP = new System.Windows.Forms.ComboBox();
            this.cbo_igualdad = new System.Windows.Forms.ComboBox();
            this.txt_expresion1 = new System.Windows.Forms.TextBox();
            this.pic_op = new System.Windows.Forms.PictureBox();
            this.txt_expresion2 = new System.Windows.Forms.TextBox();
            this.btn_aplicar = new System.Windows.Forms.Button();
            this.lbl_Ind1 = new System.Windows.Forms.Label();
            this.lbl_Ind2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_Ind3 = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_N = new System.Windows.Forms.NumericUpDown();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_B_N1 = new System.Windows.Forms.Label();
            this.lbl_A_N1 = new System.Windows.Forms.Label();
            this.lbl_B_N = new System.Windows.Forms.Label();
            this.lbl_A_N = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_help = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_op)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_N)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1049, 106);
            this.label1.TabIndex = 3;
            this.label1.Text = "Induccion Completa - Proposiciones";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbo_op1_tipoOP
            // 
            this.cbo_op1_tipoOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_op1_tipoOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_op1_tipoOP.ForeColor = System.Drawing.Color.Blue;
            this.cbo_op1_tipoOP.FormattingEnabled = true;
            this.cbo_op1_tipoOP.Items.AddRange(new object[] {
            "∑-Sumatoria",
            "π -Productoria",
            "->Simple"});
            this.cbo_op1_tipoOP.Location = new System.Drawing.Point(3, 107);
            this.cbo_op1_tipoOP.Name = "cbo_op1_tipoOP";
            this.cbo_op1_tipoOP.Size = new System.Drawing.Size(190, 24);
            this.cbo_op1_tipoOP.TabIndex = 4;
            this.cbo_op1_tipoOP.SelectedIndexChanged += new System.EventHandler(this.cbo_op1_tipoOP_SelectedIndexChanged);
            // 
            // cbo_igualdad
            // 
            this.cbo_igualdad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_igualdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_igualdad.ForeColor = System.Drawing.Color.Blue;
            this.cbo_igualdad.FormattingEnabled = true;
            this.cbo_igualdad.Items.AddRange(new object[] {
            "=",
            ">",
            "<",
            ">=",
            "<="});
            this.cbo_igualdad.Location = new System.Drawing.Point(406, 105);
            this.cbo_igualdad.Name = "cbo_igualdad";
            this.cbo_igualdad.Size = new System.Drawing.Size(46, 24);
            this.cbo_igualdad.TabIndex = 5;
            // 
            // txt_expresion1
            // 
            this.txt_expresion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_expresion1.Location = new System.Drawing.Point(199, 105);
            this.txt_expresion1.Name = "txt_expresion1";
            this.txt_expresion1.Size = new System.Drawing.Size(201, 26);
            this.txt_expresion1.TabIndex = 6;
            // 
            // pic_op
            // 
            this.pic_op.BackColor = System.Drawing.Color.Transparent;
            this.pic_op.Image = global::PracticosLogMat.Properties.Resources.productoria;
            this.pic_op.Location = new System.Drawing.Point(3, 0);
            this.pic_op.Name = "pic_op";
            this.pic_op.Size = new System.Drawing.Size(190, 101);
            this.pic_op.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_op.TabIndex = 8;
            this.pic_op.TabStop = false;
            // 
            // txt_expresion2
            // 
            this.txt_expresion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_expresion2.Location = new System.Drawing.Point(458, 103);
            this.txt_expresion2.Name = "txt_expresion2";
            this.txt_expresion2.Size = new System.Drawing.Size(217, 26);
            this.txt_expresion2.TabIndex = 9;
            // 
            // btn_aplicar
            // 
            this.btn_aplicar.BackColor = System.Drawing.Color.Transparent;
            this.btn_aplicar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_aplicar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_aplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aplicar.Location = new System.Drawing.Point(683, 105);
            this.btn_aplicar.Name = "btn_aplicar";
            this.btn_aplicar.Size = new System.Drawing.Size(74, 23);
            this.btn_aplicar.TabIndex = 10;
            this.btn_aplicar.Text = "Desarrollar";
            this.btn_aplicar.UseVisualStyleBackColor = false;
            this.btn_aplicar.Click += new System.EventHandler(this.btn_aplicar_Click);
            // 
            // lbl_Ind1
            // 
            this.lbl_Ind1.AutoSize = true;
            this.lbl_Ind1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Ind1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ind1.Location = new System.Drawing.Point(3, 0);
            this.lbl_Ind1.Name = "lbl_Ind1";
            this.lbl_Ind1.Size = new System.Drawing.Size(26, 16);
            this.lbl_Ind1.TabIndex = 11;
            this.lbl_Ind1.Text = "(1)";
            // 
            // lbl_Ind2
            // 
            this.lbl_Ind2.AutoSize = true;
            this.lbl_Ind2.BackColor = System.Drawing.Color.Yellow;
            this.lbl_Ind2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ind2.ForeColor = System.Drawing.Color.Black;
            this.lbl_Ind2.Location = new System.Drawing.Point(35, 0);
            this.lbl_Ind2.Name = "lbl_Ind2";
            this.lbl_Ind2.Size = new System.Drawing.Size(26, 16);
            this.lbl_Ind2.TabIndex = 12;
            this.lbl_Ind2.Text = "(2)";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.lbl_Ind1);
            this.flowLayoutPanel1.Controls.Add(this.lbl_Ind2);
            this.flowLayoutPanel1.Controls.Add(this.lbl_Ind3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 38);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(585, 222);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // lbl_Ind3
            // 
            this.lbl_Ind3.AutoSize = true;
            this.lbl_Ind3.BackColor = System.Drawing.Color.Lime;
            this.lbl_Ind3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ind3.ForeColor = System.Drawing.Color.Black;
            this.lbl_Ind3.Location = new System.Drawing.Point(67, 0);
            this.lbl_Ind3.Name = "lbl_Ind3";
            this.lbl_Ind3.Size = new System.Drawing.Size(26, 16);
            this.lbl_Ind3.TabIndex = 13;
            this.lbl_Ind3.Text = "(3)";
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.Color.Transparent;
            this.btn_calcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_calcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calcular.Location = new System.Drawing.Point(982, 106);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(55, 23);
            this.btn_calcular.TabIndex = 14;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(763, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Probar para n=";
            // 
            // txt_N
            // 
            this.txt_N.Location = new System.Drawing.Point(900, 106);
            this.txt_N.Maximum = new decimal(new int[] {
            -1304428544,
            434162106,
            542,
            0});
            this.txt_N.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_N.Name = "txt_N";
            this.txt_N.Size = new System.Drawing.Size(76, 20);
            this.txt_N.TabIndex = 18;
            this.txt_N.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 170);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbl_B_N1);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_A_N1);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_B_N);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_A_N);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Size = new System.Drawing.Size(1034, 260);
            this.splitContainer1.SplitterDistance = 585;
            this.splitContainer1.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Maroon;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(585, 38);
            this.label7.TabIndex = 17;
            this.label7.Text = "Demostraciones";
            // 
            // lbl_B_N1
            // 
            this.lbl_B_N1.AutoSize = true;
            this.lbl_B_N1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_B_N1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_B_N1.Location = new System.Drawing.Point(2, 202);
            this.lbl_B_N1.Name = "lbl_B_N1";
            this.lbl_B_N1.Size = new System.Drawing.Size(33, 20);
            this.lbl_B_N1.TabIndex = 26;
            this.lbl_B_N1.Text = "{B}";
            this.lbl_B_N1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_A_N1
            // 
            this.lbl_A_N1.AutoSize = true;
            this.lbl_A_N1.BackColor = System.Drawing.Color.Purple;
            this.lbl_A_N1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_A_N1.Location = new System.Drawing.Point(2, 165);
            this.lbl_A_N1.Name = "lbl_A_N1";
            this.lbl_A_N1.Size = new System.Drawing.Size(33, 20);
            this.lbl_A_N1.TabIndex = 25;
            this.lbl_A_N1.Text = "{A}";
            this.lbl_A_N1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_B_N
            // 
            this.lbl_B_N.AutoSize = true;
            this.lbl_B_N.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_B_N.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_B_N.Location = new System.Drawing.Point(3, 93);
            this.lbl_B_N.Name = "lbl_B_N";
            this.lbl_B_N.Size = new System.Drawing.Size(33, 20);
            this.lbl_B_N.TabIndex = 24;
            this.lbl_B_N.Text = "{B}";
            this.lbl_B_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_A_N
            // 
            this.lbl_A_N.AutoSize = true;
            this.lbl_A_N.BackColor = System.Drawing.Color.Purple;
            this.lbl_A_N.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_A_N.Location = new System.Drawing.Point(3, 56);
            this.lbl_A_N.Name = "lbl_A_N";
            this.lbl_A_N.Size = new System.Drawing.Size(33, 20);
            this.lbl_A_N.TabIndex = 23;
            this.lbl_A_N.Text = "{A}";
            this.lbl_A_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Green;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(445, 38);
            this.label9.TabIndex = 18;
            this.label9.Text = "Probando  para n:";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Purple;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(395, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "{A}   Utilizar parametro [k]";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(458, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(217, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "{B}  Utilizar parametro [n]";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_help
            // 
            this.btn_help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_help.AutoSize = true;
            this.btn_help.BackColor = System.Drawing.Color.Transparent;
            this.btn_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help.Location = new System.Drawing.Point(870, 147);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(167, 20);
            this.btn_help.TabIndex = 23;
            this.btn_help.TabStop = true;
            this.btn_help.Text = "Ver Documentacion";
            this.btn_help.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form_UnII_TP4_A_EJ_2C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 431);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.txt_N);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.btn_aplicar);
            this.Controls.Add(this.txt_expresion2);
            this.Controls.Add(this.pic_op);
            this.Controls.Add(this.txt_expresion1);
            this.Controls.Add(this.cbo_igualdad);
            this.Controls.Add(this.cbo_op1_tipoOP);
            this.Controls.Add(this.label1);
            this.Name = "Form_UnII_TP4_A_EJ_2C";
            this.Text = "Form_UnII_TP4_A_EJ_2C";
            this.Load += new System.EventHandler(this.Form_UnII_TP4_A_EJ_2C_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_op)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_N)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_op1_tipoOP;
        private System.Windows.Forms.ComboBox cbo_igualdad;
        private System.Windows.Forms.TextBox txt_expresion1;
        private System.Windows.Forms.PictureBox pic_op;
        private System.Windows.Forms.TextBox txt_expresion2;
        private System.Windows.Forms.Button btn_aplicar;
        private System.Windows.Forms.Label lbl_Ind1;
        private System.Windows.Forms.Label lbl_Ind2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbl_Ind3;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txt_N;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_B_N;
        private System.Windows.Forms.Label lbl_A_N;
        private System.Windows.Forms.Label lbl_B_N1;
        private System.Windows.Forms.Label lbl_A_N1;
        private System.Windows.Forms.LinkLabel btn_help;

    }
}