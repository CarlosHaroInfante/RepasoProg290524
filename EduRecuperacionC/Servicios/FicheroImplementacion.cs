using EduRecuperacionC.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    internal class FicheroImplementacion : FicheroInterfaz
    {
        public void escribirFichero(string mensaje)
        {


            try
            {
                string rutaCarpetaLogs = "C:\\Users\\Carlos\\Desktop\\Programación\\EduRecuperacionC\\CarpetaLog\\";

                string rutaFicheroLog2 = string.Concat(rutaCarpetaLogs, Utilidades.crearNombreLog());

                using (StreamWriter escribir = new StreamWriter(rutaFicheroLog2, true))
                {

                    escribir.Write(mensaje + "\n");
                    escribir.Close();

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al crear/escribir en el fichero log " + ex.Message);

            }
        }

        public void alumnosFichero(string alumno)
        {

            try {
                string rutaCarpetaAlumnos = "C:\\Users\\Carlos\\Desktop\\Programación\\EduRecuperacionC\\alumnos.txt";
                //StreamWriter escribirAlumnos = new StreamWriter(rutaCarpetaAlumnos, true);
                //string rutaFicheroAlumos = string.Concat(rutaCarpetaAlumnos, "alumnos.txt");

               using(StreamWriter escribirAlumnos2 = new StreamWriter(rutaCarpetaAlumnos, true))
                {
                    escribirAlumnos2.WriteLine(alumno +  "\n");
                    escribirAlumnos2.Close();
                }
                Console.WriteLine("Se ha escrito correctamente");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al crear/escribir en el fichero log " + ex.Message);

            }

        }
    }
}
