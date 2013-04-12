using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NameStartup.Datos;

namespace NameStartup.MVC
{
   public  class Model
    {

        private Projects _MyProyects;

        public Projects MyProyects
        {
            get { return _MyProyects; }
            set { _MyProyects = value; }
        }

        
        
        private Categories _Categorias;

        public Categories MyCategorias
        {
            get { return _Categorias; }
            set { _Categorias = value; }
        }

        
        

        
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
