using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuPricinpal
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void nuevoArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearBD nuevaPestaña = new CrearBD();
            nuevaPestaña.Show();
        }

        private void renombrarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rename nuevaPestaña = new Rename();
            nuevaPestaña.Show();
        }
    }
}
