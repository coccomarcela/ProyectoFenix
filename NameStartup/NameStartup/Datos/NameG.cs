using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NameStartup.Datos
{
    public class NameGx
    {
        private int _nivel;

        public int Nivel
        {
            get { return _nivel; }
            set { _nivel = value; }
        }

        private string _Categorias;

        public string Categorias
        {
            get { return _Categorias; }
            set { _Categorias = value; }
        }

        private string _Palabras;

        public string Palabras
        {
            get { return _Palabras; }
            set
            {
                _Palabras = value;

            }
        }

        NombresGenerados Nombre;

           private List<NombresGenerados> _Names= new List<NombresGenerados>();

        public List<NombresGenerados> Names
        {
            get { return _Names; }
            set { _Names = value; }
        }



        public List<string> f;
        public List<string> f1;
        public List<string> f2;
     //   string[] p;

        public void GenerarNamesG()
        {


            if (Nivel == 2)
            {
                // nivel2_Fraccion();
                nivel2_names();
            }
            else
            {
                // nivel2_Fraccion();
                // nivel3_fraccion();
                nivel3_names();
            }
          //  p = null;
            f = null;
            f1 = null;
            f2 = null;
        }

        private void nivel2_names()
        {
            //Orden 1-2
            foreach (string p1 in f)
            {
                foreach (string p2 in f1)
                {
                    Nombre = new NombresGenerados();
                    Nombre.Name = p1 + p2;
                    Names.Add(Nombre);

                    Nombre = new NombresGenerados();
                    Nombre.Name = p2 + p1;
                    Names.Add(Nombre);
                    //  Names.Add(p1 + p2);
                }
            }
            ////orden 2-1
            //foreach (string p1 in f1)
            //{
            //    foreach (string p2 in f)
            //    {
            //        Nombre = new NombresGenerados();
            //        Nombre.Name = p1 + p2;
            //        Names.Add(Nombre);
            //       // Names.Add(p1 + p2);
            //    }
            //}


        }

        private void nivel3_names()
        {

            foreach (string p1 in f)
            {
                foreach (string p2 in f1)
                {
                    foreach (string p3 in f2)
                    {
                        //Orden 1-2-3
                        Nombre = new NombresGenerados();
                        Nombre.Name = p1 + p2 + p3;
                        Names.Add(Nombre);

                        //Orden 1-3-2
                        Nombre = new NombresGenerados();
                        Nombre.Name = p1 + p3 + p2;
                        Names.Add(Nombre);

                        //Orden 2-1-3
                        Nombre = new NombresGenerados();
                        Nombre.Name = p2 + p1 + p3;
                        Names.Add(Nombre);

                        //Orden 2-3-1
                        Nombre = new NombresGenerados();
                        Nombre.Name = p2 + p3 + p1;
                        Names.Add(Nombre);

                        //Orden 3-1-2
                        Nombre = new NombresGenerados();
                        Nombre.Name = p3 + p1 + p2;
                        Names.Add(Nombre);

                        //Orden 3-2-1
                        Nombre = new NombresGenerados();
                        Nombre.Name = p3 + p2 + p1;
                        Names.Add(Nombre);
                        // Names.Add(p1 + p2+p3);
                    }

                }
            }

            ////Orden 1-3-2
            //foreach (string p1 in f)
            //{
            //    foreach (string p2 in f2)
            //    {
            //        foreach (string p3 in f1)
            //        {
            //            Nombre = new NombresGenerados();
            //            Nombre.Name = p1 + p2+p3;
            //            Names.Add(Nombre);
            //           // Names.Add(p1 + p2 + p3);
            //        }

            //    }
            //}

            ////Orden 2-1-3
            //foreach (string p1 in f1)
            //{
            //    foreach (string p2 in f)
            //    {
            //        foreach (string p3 in f2)
            //        {
            //            Nombre = new NombresGenerados();
            //            Nombre.Name = p1 + p2 + p3;
            //            Names.Add(Nombre);
            //           // Names.Add(p1 + p2 + p3);
            //        }

            //    }
            //}

            ////Orden 2-3-1
            //foreach (string p1 in f1)
            //{
            //    foreach (string p2 in f2)
            //    {
            //        foreach (string p3 in f)
            //        {
            //            Nombre = new NombresGenerados();
            //            Nombre.Name = p1 + p2 + p3;
            //            Names.Add(Nombre);
            //           // Names.Add(p1 + p2 + p3);
            //        }

            //    }
            //}
            ////Orden 3-1-2
            //foreach (string p1 in f2)
            //{
            //    foreach (string p2 in f)
            //    {
            //        foreach (string p3 in f1)
            //        {
            //            Nombre = new NombresGenerados();
            //            Nombre.Name = p1 + p2 + p3;
            //            Names.Add(Nombre);
            //           // Names.Add(p1 + p2 + p3);
            //        }

            //    }
            //}

            ////Orden 3-2-1
            //foreach (string p1 in f2)
            //{
            //    foreach (string p2 in f1)
            //    {
            //        foreach (string p3 in f)
            //        {
            //            Nombre = new NombresGenerados();
            //            Nombre.Name = p1 + p2 + p3;
            //            Names.Add(Nombre);
            //            //Names.Add(p1 + p2 + p3);
            //        }

            //    }
            //}


        }
    }

    public class NombresGenerados
    {
        private int _Longitud;

        public int LongitudPalabra
        {
            get { return _Longitud; }
            set { _Longitud = value; }
        }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                LongitudPalabra = _Name.Length;
            }
        }

        private Boolean _MeGusta = false;

        public Boolean MeGusta
        {
            get { return _MeGusta; }
            set { _MeGusta = value; }
        }


        private int _puntaje = 0;

        public int Puntaje
        {
            get { return _puntaje; }
            set { _puntaje = value; }
        }

        private bool _domdispo = false;

        public bool DominioDisponible
        {
            get { return _domdispo; }
            set { _domdispo = value; }
        }

        private string _Categorias;

        public string Categorias
        {
            get { return _Categorias; }
            set { _Categorias = value; }
        }

        private string _PalabrasGen;

        public string PalabrasOrigen
        {
            get { return _PalabrasGen; }
            set { _PalabrasGen = value; }
        }





    }

}