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
    public partial class Rename : Form
    {
        public Rename()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estas seguro/a de cambiar el nombre?", "Salir", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                ManejadorDeDatos.Core.ADMarchivos.reNombrar(txt1.Text,txt2.Text);

            }
            else if (result == DialogResult.No)
            {
               
            }
        }
    }
}
