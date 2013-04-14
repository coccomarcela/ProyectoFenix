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
        public void ProcesarCategorias()
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

   

}