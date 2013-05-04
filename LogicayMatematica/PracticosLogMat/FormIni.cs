using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PracticosLogMat.MVC;

namespace PracticosLogMat
{
    public partial class FormIni : Form
    {
        Controler c;

        public FormIni()
        {
            InitializeComponent();
        }

        private void FormIni_Load(object sender, EventArgs e)
        {
            c = new Controler(this);
        }

        private void aNumerosNaturalesInduccionMatematicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c.Navegar(Acciones.Ver_UnII_TP4_A_EJ_2C);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://ar.linkedin.com/in/coccomarcela/");
        }

        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://marcelacocco.blogspot.com.ar/");
        }

       
    }
}
