using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PracticosLogMat.MVC;
using NCalc;
using PracticosLogMat.Entities;
using System.IO;

namespace PracticosLogMat.Vistas
{
    public partial class Form_UnII_TP4_A_EJ_2C : Plantilla
    {
        Class_UnII_TP4_EJ_A2C x=new Class_UnII_TP4_EJ_A2C();
        public Form_UnII_TP4_A_EJ_2C()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Expression o = new Expression("2 * [x] ^ 2 + 5 * [y]");

            Expression o = new Expression("[x] + [y]");
            o.Parameters["x"] = 5;
            o.Parameters["y"] = 1;

          //  textBox1.Text = o.Evaluate().ToString();
         
        }

        private void Form_UnII_TP4_A_EJ_2C_Load(object sender, EventArgs e)
        {
            this.cbo_op1_tipoOP.SelectedIndex = 1;
            this.cbo_igualdad.SelectedIndex=0;
            this.txt_expresion1.Text="[k]/([k]+1)";
            this.txt_expresion2.Text = "1/([n]+1)";
           // this.classUnIITP4EJA2CBindingSource.DataSource = x;
        }

        private void cbo_op1_tipoOP_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Ind1.Text = "(1)";
            lbl_Ind2.Text = "(2)";
            lbl_Ind3.Text = "(3)";

            lbl_A_N.Text = "{A}";
            lbl_B_N.Text = "{B}";

            lbl_A_N1.Text = "{A}";
            lbl_B_N1.Text = "{B}";


            ComboBox comboBox = (ComboBox)sender;
            int index = (int)comboBox.SelectedIndex;

            switch (index)
            {
                case 0:
                    this.txt_expresion1.Text="2*[k]-1";
                    this.txt_expresion2.Text = "Pow([n],2)";
                    x.opExp = OpExp1.sum;
                    pic_op.Image = Properties.Resources.sumatoria;
                    break;
                case 1:
                    this.txt_expresion1.Text="[k]/([k]+1)";
                    this.txt_expresion2.Text = "1/([n]+1)";
                    x.opExp = OpExp1.prod;
                    pic_op.Image = Properties.Resources.productoria;
                    break;
                case 2:
                    this.txt_expresion1.Text="No Implementada";
                    this.txt_expresion2.Text = "No Implementada";
                    x.opExp = OpExp1.simple ;
                    pic_op.Image = Properties.Resources.simples;
                    break;
                default:
                    break;
            }
        }

        private void btn_aplicar_Click(object sender, EventArgs e)
        {
            try
            {
            x.Asignar(txt_expresion1.Text, cbo_igualdad.Text , txt_expresion2.Text);
            lbl_Ind1.Text = x.Induccion_exp1_N1;
            lbl_Ind2.Text = x.Induccion_Tesis;
            lbl_Ind3.Text = x.Induccion_Hipotesis ;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (lbl_Ind1.Text=="(1)")
            {
                MessageBox.Show("Debe desarrollar la induccion para poder probar para un valor n");
                return;
            }

            x.CalcularParaN((decimal)txt_N.Value);
            lbl_A_N.Text = x.Res_Exp1_A_str;
            lbl_B_N.Text = x.Res_Exp1_B_str;

            lbl_A_N1.Text = x.Res_Exp2_A_str;
            lbl_B_N1.Text = x.Res_Exp2_B_str;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Help x = new Form_Help(HelpDocument.Doc_UnII_TP4_A_EJ_2C);
            x.ShowDialog();

          
        }

   

    }
}
