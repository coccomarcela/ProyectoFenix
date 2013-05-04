using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PracticosLogMat.Vistas;


namespace PracticosLogMat.MVC
{
    public enum Vistas
    {
        Bienvenida,
       UnII_TP4_A_EJ_2C
    }

    public enum Acciones
    {
        Ver_Bienvenida,
        Ver_UnII_TP4_A_EJ_2C
     
    }

    public class Controler
    {
        

        public Controler(FormIni c)
        {
            MyContenedor = c;
            NavegarA(Vistas.Bienvenida);


        }

        private FormIni _MyContenedor;
        public FormIni MyContenedor
        {
            get { return _MyContenedor; }
            set { _MyContenedor = value; }
        }

        private Model myModel = new Model();

        public Model MyModel
        {
            get { return myModel; }
            set { myModel = value; }
        }





        public void Navegar(Acciones a)
        {
            Vistas v;
            MyModel.MyAccionAnterior = MyModel.MyAccionActual;
            MyModel.MyAccionActual = a;

            switch (a)
            {
                case Acciones.Ver_Bienvenida:
                    v = Vistas.Bienvenida;
                    break;
                case Acciones.Ver_UnII_TP4_A_EJ_2C:
                    v=Vistas.UnII_TP4_A_EJ_2C ;
                    break;
                //case Acciones.Ver_AboutMy:
                //    v = Vistas.AboutMy;
                //    break;
                //case Acciones.Ver_Categorias:
                //    v = Vistas.Categorias;
                //    break;
                //case Acciones.Ver_Names:
                //    v = Vistas.Names;
                //    break;
                default:
                    v = Vistas.Bienvenida;
                    break;
            }

            NavegarA(v);
        }


        private void NavegarA(Vistas v)
        {
            Plantilla control;
            myModel.MyVistaAnterior = MyModel.MyVistaAnterior;
            MyModel.MyVistaActual = v;
            string Title="Logica y Matematica Computacional - 2013";

            switch (v)
            {
                case Vistas.Bienvenida:
                    control = new Form_Bienvenida();
                    control.Text = Title;
                    break;
                case Vistas.UnII_TP4_A_EJ_2C:
                    control = new Form_UnII_TP4_A_EJ_2C();
                    control.Text = Title + "-->TP N° 4 --Ejercicio: A-2-C" ;
                    break;

              
                default:
                    control = new Form_Bienvenida();
                    break;
            }


            Form activeMDIChild = MyContenedor.ActiveMdiChild;

            if (activeMDIChild != null)
            {
                MyContenedor.ActiveMdiChild.Close();
            }

            MyContenedor.Text =  control.Text;
            control._Mycontroler = this;
            control.MdiParent = MyContenedor;
            control.Dock = DockStyle.Fill;
            control.Show();

        }


    }
}