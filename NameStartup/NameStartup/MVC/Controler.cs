using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NameStartup.Vistas;

namespace NameStartup.MVC
{
    public enum Vistas
    {
        Bienvenida,
        AboutMy,
        Categorias,
        Names
    }

    public enum Acciones
    {
        Ver_Bienvenida,
        Ver_AboutMy,
        Ver_Categorias,
        Ver_Names
    }

    public class Controler
    {
        private NameGeneratorStartups _MyContenedor;

        public Controler(NameGeneratorStartups c)
        {
            MyContenedor = c;
            NavegarA(Vistas.Bienvenida);


        }

        public NameGeneratorStartups MyContenedor
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
                case Acciones.Ver_AboutMy:
                    v = Vistas.AboutMy ;
                    break;
                case Acciones.Ver_Categorias :
                    v = Vistas.Categorias ;
                    break;
                case Acciones.Ver_Names :
                    v = Vistas.Names;
                    break;
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

            switch (v)
            {
                case Vistas.Bienvenida:
                    myModel.MyProyects = null;
                    myModel.MyProyects =new NameStartup.Datos.Projects ();
                    control = new Form_Bienvenida();
                    break;
                case Vistas.AboutMy :
                    control = new Form_AboutMy ();
                    control.Text = "Cocco Marcela";
                    break;

                case Vistas.Categorias :
                    control = new Form_Categorias ();
                    control.Text = "Categorias";
                    break;
                case Vistas.Names :
                    control = new Form_Names();
                    control.Text = "Names";
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

            control._Mycontroler = this;
            control.MdiParent = MyContenedor;
            control.Dock = DockStyle.Fill;
            control.Show();

        }


    }
}