using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace NameStartup.Datos
{
   public  class Projects
    {
        private string _ProyectoSeleccionado;
        private string fullPath;
        public string ProyectoSeleccionado
        {
            get { return _ProyectoSeleccionado; }
            set { 
                _ProyectoSeleccionado = value.Trim().ToUpper();
                fullPath = "c:\\NameG\\" + _ProyectoSeleccionado + ".xml";
            }
        }
        

        List<string> FileList=new List<string> ();

        private bool _Existproject=false ;

        public bool ExistProject
        {
            get { return _Existproject; }
            set { _Existproject = value; }
        }

        

        private List <Projectx> _ProjectList=new List<Projectx>();
        public List <Projectx> MyProjects
        {
            get { return _ProjectList; }
            set { _ProjectList = value; }
        }
                
        String _PathNameG = "c:\\NameG";
        
        public Projects()
        {
            // 1)Verifico si existen Ruta para almacenar Proyectos
            if (!Directory.Exists(_PathNameG))
            {
                //si no existe el directorio lo creo
                Directory.CreateDirectory(_PathNameG);
            }

            //2)Obtengo la lista de archivos(proyectos)
            FileList = Directory.GetFiles(_PathNameG).ToList();
            
            //3)Verifico si existen proyectos

            if (FileList.Count > 0)
            {
                _Existproject = true;

                //creo lista de proyectos
                Crear_ListProject(FileList);
                //libero lista de archivos
                FileList.Clear();
            }
           

        }

        private void Crear_ListProject(List <string> ls)
        {
            Projectx p;
            foreach (string l in ls)
            {
                p = new Projectx();
                p.PathProject = l;
                _ProjectList.Add(p);
            }
        }

        public Categories Iniciar_Proyecto(String NameProject)
        {
            ProyectoSeleccionado  = NameProject;
            //1)Verifico si existe el proyecto
            if (MyProjects.FindAll(p => p.Name == NameProject).Count > 0)
            {
                return Obtener_Proyecto();
            }
            else
            {
                return Crear_NuevoProyecto();
            }

          
        }

         Categories  Crear_NuevoProyecto()
        {
            

            //2)serializo y guardo
            Categories ProjectClass = new Categories();
            ProjectClass.Categories_CrearDefault();
            
            try
            {
                // Serializamos el objeto
                using (Stream savestream = new FileStream(fullPath, FileMode.Create))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Categories ));
                    serializer.Serialize(savestream, ProjectClass  );
                }

                //Agrego Nuevo Projecto a la lista
                Projectx p = new Projectx();
                p.PathProject = ProyectoSeleccionado  ;
                _ProjectList.Add(p);


                ExistProject  = true;

                return ProjectClass;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("El proyecto no se pudo crear: " + ex.Message );
               
            }

           


        }


          Categories  Obtener_Proyecto()
        {

           
            Categories ProjectClass;

            try
            {
                // Deserializamos el objeto
                using (Stream loadStream = new FileStream(fullPath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Categories));
                    ProjectClass = (Categories )serializer.Deserialize(loadStream);
                }

                return ProjectClass;

            }
            catch (Exception ex)
            {
                throw new ArgumentException("El proyecto no se pudo crear: " + ex.Message);

            }




        }


        public void Guardar_Proyecto(Categories ProjectClass)
        {
           
                     

            try
            {
               // ProjectClass.NamesG.Clear();
                // Serializamos el objeto
                using (Stream savestream = new FileStream(fullPath, FileMode.Create))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Categories));
                    serializer.Serialize(savestream, ProjectClass);
                   
                }

            }
            catch (Exception ex)
            {
                throw new ArgumentException("El proyecto no se pudo crear: " + ex.Message);

            }




        }

       
    }

    public class Projectx
    {
        private string _path;

        public string PathProject
        {
            get { return _path; }
            set { 
                _path = value;
                _Name = Path.GetFileName(_path).Replace(".xml","");
            
            }
        }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        
        
    }
}
