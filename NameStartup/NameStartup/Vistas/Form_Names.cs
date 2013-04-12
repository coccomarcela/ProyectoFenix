using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NameStartup.Vistas
{
    public partial class Form_Names : NameStartup.MVC.Plantilla 
    {
        public Form_Names()
        {
            InitializeComponent();
        }

        private void Form_Names_Load(object sender, EventArgs e)
        {

            this.lbl_Proyecto.Text = "Proyecto: " + _Mycontroler.MyModel.MyProyects.ProyectoSeleccionado;
            nameGxBindingSource.DataSource = _Mycontroler.MyModel.MyCategorias.NamesG;

        }

       
    }
}
