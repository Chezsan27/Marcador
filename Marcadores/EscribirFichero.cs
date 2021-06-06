using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marcadores
{
    class EscribirFichero
    {
        private string RUTA_DEFAULT = Environment.CurrentDirectory+ @"\";
        private string rutaGuardado;
        private string rutaArchivoConfiguracion = @"C:\ProgramData\";

        public string RutaGuardado { get => rutaGuardado; set => rutaGuardado = value; }
        public string RUTA_DEFAULT1 { get => RUTA_DEFAULT; set => RUTA_DEFAULT = value; }

        public EscribirFichero()
        {
            leerFichero();
        }
        private void leerFichero()
        {
            StreamReader fichero;
            String linea;
            if (File.Exists(rutaArchivoConfiguracion+"rutaGuardado.txt"))
            {
                try
                {
                    fichero = File.OpenText(rutaArchivoConfiguracion + "rutaGuardado.txt");
                    linea = fichero.ReadLine();
                    rutaGuardado = linea;
                    fichero.Close();
                }
                catch (FileNotFoundException)
                {

                    MessageBox.Show("No se encuentra el fichero");
                }       
            }
            else
            {
                escribirCambioRuta(RUTA_DEFAULT);               
            }
       
        }
        public void escribirCambioRuta(string nuevaRuta)
        {
            StreamWriter fichero;
            fichero = File.CreateText(rutaArchivoConfiguracion + "rutaGuardado.txt");


            fichero.WriteLine(nuevaRuta);
            fichero.Close();
        }
        public void escribirFichero(String nombreFichero, String texto)
        {
            
            StreamWriter fichero;
            try
            {
                fichero = File.CreateText(rutaGuardado + nombreFichero);

                fichero.WriteLine(texto);

                fichero.Close();
            }
            catch(System.IO.DirectoryNotFoundException)
            {
                MessageBox.Show("El directorio guardado no existe o se ha movido");
                MessageBox.Show("Se establecerá el directorio por defecto (Directorio donde se encuentra la aplicación)");
                rutaGuardado = RUTA_DEFAULT1;
                escribirCambioRuta(RUTA_DEFAULT1);
            }      
           

        }
    }
   
}
