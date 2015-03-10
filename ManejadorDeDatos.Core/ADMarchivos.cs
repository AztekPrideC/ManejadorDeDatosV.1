using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejadorDeDatos.Core
{
    public class ADMarchivos
    {

        private string rutaArchivo;
        private string archivo;
            public ADMarchivos()
            {

            }

            public ADMarchivos(string ruta, string archivo)
            {
                    this.rutaArchivo = ruta;
                    this.archivo = archivo;

            }

        //crud
            public static void CrearArchivo(string nombreArchivo)
            {
           
                var BD = File.CreateText(nombreArchivo+".txt");
                BD.Close();

               
            }


            public static void reNombrar(string nombreArchivo,string nuevoNombre) 
            {
                
                File.Move(nombreArchivo+".txt", nuevoNombre+".txt");
        
            }


            public static string abrirArchivo(string ruta) 
            {
                string res = "";
                System.IO.StreamReader file = new System.IO.StreamReader(ruta);
                res = file.ReadToEnd();
                file.Close();
                return res;
            
            
            
            }

    }
}
