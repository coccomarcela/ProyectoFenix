using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PracticosLogMat.MVC;
using System.IO;

namespace PracticosLogMat.Vistas
{
    public enum HelpDocument
    {
       Doc_UnII_TP4_A_EJ_2C 
    }
    public partial class Form_Help : PlantillaPopUP
    {
        string Title="";
        string PathDocument="";
        public Form_Help(HelpDocument d)
        {
            InitializeComponent();

            switch (d)
            {
                case HelpDocument.Doc_UnII_TP4_A_EJ_2C:
                    Title = "Practico N°4 - Numeros Naturales [UnII-TP4-A-EJ-2C]";
                    PathDocument = Path.Combine(Environment.CurrentDirectory, @"..\..\Documentacion\Doc_UnII-TP4-A-EJ-2C.rtf");;

                    break;
                default:
                    break;
            }




          
            try
            {
            this.Text = Title;
            richTextBox1.LoadFile(PathDocument,
            RichTextBoxStreamType.RichText);
            }
            catch (Exception)
            {
                
                throw;
            }
          
        }
    }
}
