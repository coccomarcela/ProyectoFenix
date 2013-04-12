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
    public partial class Form_Bienvenida : Plantilla
    {
        private string _projectName="";

        public string projectName
        {
            get { return _projectName; }
            set { _projectName = value; }
        }

        
        public Form_Bienvenida()
        {
            InitializeComponent();
        }

       

        private void  generarProject(string myName,bool esNuevo)
        {

            panel_progressBar.Visible = true;
            if (esNuevo == true) { ProgressMensage = "Creando Proyecto{"+myName+"}...."; }
            else { ProgressMensage = "Abriendo Proyecto{" + myName + "}..."; }
            ProgressPorcentaje = 25;
            projectName = myName;
            backgroundWorker1.RunWorkerAsync();


        }

        private void Form_Bienvenida_Load(object sender, EventArgs e)
        {
            this.projectxBindingSource.DataSource = _Mycontroler.MyModel.MyProyects.MyProjects;
        }

        private void list_ProyectosExistentes_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.list_ProyectosExistentes.Text.Trim().Length == 0)
            {
                return;
            }
        

            if (MessageBox.Show("Ha Seleccionado el proyecto:{ " +this.list_ProyectosExistentes.Text + "} Desea Abrirlo?" ,"Abrir Proyecto", MessageBoxButtons.YesNo,MessageBoxIcon.Question ) == DialogResult.Yes)
            {
                generarProject(this.list_ProyectosExistentes.Text,false );
            }    

          
        }

        private void txt_NameProyect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (txt_NameProyect.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Debe ingresar el nombre del nuevo Proyecto");
                    return;
                }

                if (MessageBox.Show("Confirma que desea crear el nuevo Proyecto:{ " + this.txt_NameProyect .Text + "}", "Crear Proyecto Nuevo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    generarProject(txt_NameProyect.Text,true );
                }  

                
            }
            else
            {
                base.OnKeyDown(e);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
           
           
            if (((BackgroundWorker)sender).CancellationPending == true)
            {
                //===============================================
                //Si este componente todabia se encuentra realizando un 
                //proceso lo detiene para liberarlo y solicitar nuevamnete la peticion
                //al subproceso
                //================================================
               
                e.Cancel = true;
                return;
            }
            else
            {

                //===============================================
                //Debe detallar que acciones async se realizara
                //================================================

                backgroundWorker1.ReportProgress(ProgressPorcentaje);
                _Mycontroler.MyModel.MyCategorias = _Mycontroler.MyModel.MyProyects.Iniciar_Proyecto(projectName );

            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                //Dim s As New MsgBox_PrevisoraDelParana(MsgBox_PrevisoraDelParana.TemaFormAlerta.Tema_Pregunta, "Esta Seguro de Abandonar esta Operacion", HorizontalAlignment.Center)

            }
            else if (e.Error != null)
            {
                //Me.tbProgress.Text = "Error: " & e.Error.Message
                 MessageBox.Show("Error Comuniquese con su Operador de Sistemas: " + e.Error.Message );
                


                
            }
            else
            {

                //===========================================================
                //Operaciones que se realizan despues de laobtencion async
                //===========================================================

                 _Mycontroler.Navegar(Acciones.Ver_Categorias);

            }

        }

       
    }
}
