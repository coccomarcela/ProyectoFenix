using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NameStartup.MVC;

namespace NameStartup
{
    public partial class NameGeneratorStartups : Form
    {
        Controler c;
        public NameGeneratorStartups()
        {
            InitializeComponent();
        }

        private void NameGeneratorStartups_Load(object sender, EventArgs e)
        {
            c = new Controler(this);
        }

        private void LinkToPerfilLinkedin_Click(object sender, EventArgs e)
        {
           // System.Diagnostics.Process.Start("http://www.linkedin.com/pub/marcela-elizabet-cocco/18/1a7/819");
            c.Navegar(Acciones.Ver_AboutMy);
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            c.Navegar(Acciones.Ver_Bienvenida);
        }

       
    }
}
