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
    public partial class CrearBD : Form
    {
        public CrearBD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManejadorDeDatos.Core.ADMarchivos.CrearArchivo(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
