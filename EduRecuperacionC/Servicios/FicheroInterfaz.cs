using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    /// <summary>
    /// Interfaz que contienen los métodos relacionados con ficheros.
    /// Carlos Haro Infante - 28/05/24
    /// </summary>

    internal interface FicheroInterfaz
    {
        /// <summary>
        /// Método que contiene la creación del fichero log, además escribe y cierra el fichero.
        /// Carlos Haro Infante - 28/05/24
        /// </summary>
        public void escribirFichero(string mensaje);
    

    /// <summary>
    /// Método que contiene la creación del fichero de alumnos, sobrecargando la información.
    /// Carlos Haro Infante - 28/05/24
    /// </summary>
    public void alumnosFichero(string alumno);
}
}
