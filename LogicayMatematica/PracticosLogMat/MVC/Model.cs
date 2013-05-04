using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace PracticosLogMat.MVC
{
    public class Model
    {

     





        private Acciones _MyAccionActual = Acciones.Ver_Bienvenida;

        public Acciones MyAccionActual
        {
            get { return _MyAccionActual; }
            set { _MyAccionActual = value; }
        }

        private Acciones _MyAccionAnterior = Acciones.Ver_Bienvenida;

        public Acciones MyAccionAnterior
        {
            get { return _MyAccionAnterior; }
            set { _MyAccionAnterior = value; }
        }


        private Vistas _MyVistaActual;

        public Vistas MyVistaActual
        {
            get { return _MyVistaActual; }
            set { _MyVistaActual = value; }
        }

        private Vistas _MyVistaAnterior;

        public Vistas MyVistaAnterior
        {
            get { return _MyVistaAnterior; }
            set { _MyVistaAnterior = value; }
        }
    }
}
