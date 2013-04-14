using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NameStartup.Datos
{
    public class Category
    {


        private bool _valida = false;

        public bool valida
        {
            get { return _valida; }
            set { _valida = value; }
        }




        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value.Trim(); }
        }

        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private List<Palabra> _ListWords = new List<Palabra>();

        public List<Palabra> ListWords
        {
            get { return _ListWords; }
            set { _ListWords = value; }
        }




    }

    public class Palabra
    {
        private string _word="";

        public string Word
        {
            get { return _word; }
            set
            {


                _word = value.Replace(" ", "").Trim().ToLower();



            }

        }





        private List<String> _wordFraccion;

        public List<String> WordFraccion
        {
            get
            {//*Get

                if (_word.Length == 0)
                {
                    return null;
                }

                if (_wordFraccion == null)
                {
                    _wordFraccion = new List<string>();
                }
                else if (_wordFraccion.Count > 0)
                {
                    _wordFraccion.Clear();
                }

                for (int i = 0; i < _word.Length; i++)
                {
                    try
                    {
                        _wordFraccion.Add(_word.Substring(i, 2));
                        _wordFraccion.Add(_word.Substring(i, 3));
                        _wordFraccion.Add(_word.Substring(i, 4));
                    }
                    catch 
                    {
                        break;
                    }


                }


                return _wordFraccion;
            }//*Get

        }



    }
    
    public class Categories
    {

        public Categories()
        {
        }

        private List<NombresGenerados> MysNames = null;

        public List<NombresGenerados> _MysNames
        {
            get { return MysNames; }
            set { MysNames = value; }
        }



        private List<NameGx> _NamesG;

        public List<NameGx> NamesG
        {
            get { return _NamesG; }
            set { _NamesG = value; }
        }


        private List<Category> _listCategory = new List<Category>();

        public List<Category> ListCategory
        {
            get { return _listCategory; }
            set { _listCategory = value; }
        }


        public void Categories_CrearDefault()
        {

            Category c;

            c = new Category();

            c.Name = "Mision";
            c.Descripcion = "Palabras o Frases cortas que definan la misión del Proyecto";
            ListCategory.Add(c);

            c = new Category();

            c.Name = "Valor";
            c.Descripcion = "Palabras o Frases cortas que definan como sera o que caracteristicas tendra el Proyecto";
            ListCategory.Add(c);

            c = new Category();

            c.Name = "Vision";
            c.Descripcion = "Palabras o Frases cortas que definan esas aspiraciones-sueños-deseos quet tenemos sobre Proyecto";
            ListCategory.Add(c);

            c = new Category();

            c.Name = "Cosas Locas";
            c.Descripcion = "Palabras o Frases cortas Locas que se te ocurren u ocurrieron durante la definición del Proyecto";
            ListCategory.Add(c);



        }

        public void AgregarCategory(Category c)
        {

            ListCategory.Add(c);

        }

        public void GenerarNames()
        {
            //Validar Categorias
            foreach (Category c in ListCategory)
            {
                if (c.ListWords.Count > 0)
                {
                    c.valida = true;
                }
            }
            //Validar que exista mas de una categoria valida
            CatVal = ListCategory.FindAll(c => c.valida == true);
            if (CatVal.Count <= 1)
            {
                System.Windows.Forms.MessageBox.Show("Debe existir mas de una categoria con palabras asociadas");
                return;
            }

            //Procesar Categorias
            ProcesarCategorias();
            //CatVal.Clear();


            //Generar Names;
            ProcesarNames();
        }

        private void ProcesarNames()
        {
            foreach (NameGx n in NamesG)
            {
                n.GenerarNamesG();
            }
        }
        List<Category> CatVal;
        private void ProcesarCategorias()
        {

            NameGx n;

            List<NameGx> NamesGpr = new List<NameGx>();
            int indx1 = 0;
            foreach (Category c in CatVal)
            {
                foreach (Category c1 in CatVal)
                {
                    indx1 = CatVal.IndexOf(c1);
                    if (c.Name != c1.Name & indx1 > CatVal.IndexOf(c))
                    {//ValidoName c-c1

                        //Creo Palabras de Segundo Nivel
                        foreach (Palabra p in c.ListWords)
                        {
                            foreach (Palabra p1 in c1.ListWords)
                            {
                                //Aqui Crear Names * par
                                n = new NameGx();
                                n.Nivel = 2;
                                n.Categorias = c.Name + "-" + c1.Name;
                                n.Palabras = p.Word + "-" + p1.Word;
                                n.f = p.WordFraccion;
                                n.f1 = p1.WordFraccion;
                                NamesGpr.Add(n);

                                //Crear Por 3 nivel

                                foreach (Category c2 in CatVal)
                                {//3 Categoria
                                    if (CatVal.IndexOf(c2) > indx1)
                                    {
                                        foreach (Palabra p2 in c2.ListWords)
                                        {
                                            //Aqui Crear Names * par
                                            n = new NameGx();
                                            n.Nivel = 3;
                                            n.Categorias = c.Name + "-" + c1.Name + "-" + c2.Name;
                                            n.Palabras = p.Word + "-" + p1.Word + "-" + p2.Word;
                                            n.f = p.WordFraccion;
                                            n.f1 = p1.WordFraccion;
                                            n.f2 = p2.WordFraccion;
                                            NamesGpr.Add(n);
                                        }
                                    }
                                }//3 Categoria


                            }

                        }


                        //******************************


                    }//ValidoName c-c1-c2


                }//3 Categoria



            }//ValidoName c-c1

            NamesG = NamesGpr;

        }







        public void AgregarMisNames()
        {

            if (_MysNames == null)
            {
                MysNames = new List<NombresGenerados>();
            }

            foreach (NameGx n in NamesG)
            {
                List<NombresGenerados> nom = n.Names.FindAll(nx => nx.MeGusta == true);
                foreach (NombresGenerados i in nom)
                {
                    //if (MysNames.FindAll(nx => nx.Name == i.Name).Count == 0)
                    //{
                    i.PalabrasOrigen = n.Palabras;
                    i.Categorias = n.Categorias;
                    MysNames.Add(i);
                    // }

                }

            }

        }

    }

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

        private List<NombresGenerados> _Names = new List<NombresGenerados>();

        public List<NombresGenerados> Names
        {
            get { return _Names; }
            set { _Names = value; }
        }
        public List<string> f;
        public List<string> f1;
        public List<string> f2;
        string[] p;

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
            p = null;
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