using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NameStartup.MVC;



namespace NameStartup.Vistas
{
    public partial class Form_Categorias : Plantilla 
    {
        public Form_Categorias()
        {
            InitializeComponent();
        }

        private void Form_Categorias_Load(object sender, EventArgs e)
        {
            this.lbl_Proyecto.Text = "Proyecto: " + _Mycontroler.MyModel.MyProyects.ProyectoSeleccionado;
            this.categoryBindingSource.DataSource  = _Mycontroler.MyModel.MyCategorias.ListCategory;
           // this.dataGridView2.DataSource = bindingSource_Palabras.DataSource;

        }

        private void txt_newpalabra_KeyDown(object sender, KeyEventArgs e)
        {
            if( e.KeyCode==Keys.Enter)
            {
           //  this.bindingSource_Palabras.Add(txt_newpalabra.Text.Trim().ToLower());

            }

        }

        private void btn_CrearProyecto_Click(object sender, EventArgs e)
        {
            try
            {
                _Mycontroler.MyModel.MyProyects.Guardar_Proyecto(_Mycontroler.MyModel.MyCategorias);
                MessageBox.Show("El proyecto:" +_Mycontroler.MyModel.MyProyects.ProyectoSeleccionado +" .Se guardo Bien!!!");
            }
            catch (Exception)
            {

                MessageBox.Show("El proyecto:" + _Mycontroler.MyModel.MyProyects.ProyectoSeleccionado + " .No se guardo Bien. Sorry!!!");
            }
         
        }


        
        private void OpenURLInBrowser(string url)
        {
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "http://" + url;
            }
            try
            {
                webBrowser1.Navigate(new Uri(url));
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }

        private void UrlTextBox_SelectionChangeCommitted(object sender, EventArgs e)
        {

            navegar(UrlTextBox.SelectedItem.ToString());
            //if (String.IsNullOrEmpty(UrlTextBox.SelectedItem.ToString()) || UrlTextBox.SelectedItem.Equals("about:blank"))
            //{
            //    MessageBox.Show("Enter a valid URL.");
            //    UrlTextBox.Focus();
            //    return;
            //}
            //OpenURLInBrowser(UrlTextBox.SelectedItem.ToString());
        }

        private void nameLabel1_Click(object sender, EventArgs e)
        {

        }

        private void navegar(string direccion)
        {
            if (String.IsNullOrEmpty(direccion ) || direccion.Equals("about:blank"))
            {
                MessageBox.Show("Enter a valid URL.");
                UrlTextBox.Focus();
                return;
            }
            OpenURLInBrowser(direccion );
        }

        private void UrlTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                navegar(this.UrlTextBox.Text);
            }
            else
            {
                base.OnKeyDown(e);
            }
        }

        private void btn_GenerarNames_Click(object sender, EventArgs e)
        {
            //_Mycontroler.MyModel.MyProyects.Guardar_Proyecto(_Mycontroler.MyModel.MyCategorias);
            _Mycontroler.MyModel.MyCategorias.GenerarNames();
            _Mycontroler.Navegar(Acciones.Ver_Names);
        }


    }
}
