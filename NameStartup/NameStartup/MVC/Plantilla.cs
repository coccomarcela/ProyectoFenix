using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NameStartup.MVC
{
    public partial class Plantilla : Form
    {
        public Controler _Mycontroler;

        private string _progressMenssage="";

        public string ProgressMensage
        {
            get { return _progressMenssage; }
            set { 
                _progressMenssage = value;
                label_progress.Text = _progressMenssage;
            }
        }


        private int _progressporcentaje=0;

        public int ProgressPorcentaje
        {
            get { return _progressporcentaje; }
            set {
                _progressporcentaje = value;
                ProgressBar1.Value1  = _progressporcentaje ;
                ProgressBar1.Text = ProgressMensage;
            }
        }


        


        public Plantilla()
        {
            InitializeComponent();
        }
    }
}
