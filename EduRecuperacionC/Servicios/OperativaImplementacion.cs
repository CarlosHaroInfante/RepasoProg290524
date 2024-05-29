using EduRecuperacionC.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
                FicheroInterfaz fichero = new FicheroImplementacion();
                string mensaje;
        public void altaAlumno()
        {
                
                string control = "";
            try {

                do {

                    AlumnoDto alumnoNuevo = new AlumnoDto();

                    Console.WriteLine("Nombre del alumno");
                    alumnoNuevo.Nombre = Console.ReadLine();

                    Console.WriteLine("Apellido 1 del alumno");
                    alumnoNuevo.Apellido1 = Console.ReadLine();

                    Console.WriteLine("Apellido 2 del alumno");
                    alumnoNuevo.Apellido2 = Console.ReadLine();

                    Console.WriteLine("DNI del alumno");
                    alumnoNuevo.Dni = Console.ReadLine();

                    Console.WriteLine("Dirección del alumno");
                    alumnoNuevo.Direccion = Console.ReadLine();

                    Console.WriteLine("Teléfono del alumno");
                    alumnoNuevo.Telefono = Console.ReadLine();

                    Console.WriteLine("email del alumno");
                    alumnoNuevo.Email = Console.ReadLine();

                    alumnoNuevo.Id = idAuto();

                    Program.alumno.Add(alumnoNuevo);
                    mensaje = "Alumno añadido correctamente";

                    fichero.escribirFichero(mensaje);

                    Console.WriteLine("Quieres añadir un nuevo alumno  SI [S]/ NO [N]");
                    control = Console.ReadLine();
                }
                while (control.Equals("S"));

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al añadir el nuevo alumno" + ex.Message);
                mensaje = "Error al añadir el alumno a la lista";
                fichero.escribirFichero(mensaje);
                throw;
                
            }

        }


        public void bajaAlumno()
        {

            foreach(AlumnoDto alumnos in Program.alumno){
                Console.WriteLine(alumnos.ToString());
            }
            string control = "";

            
            do { 
            Console.WriteLine("DNI del cliente que quieres eliminar");
            string dniEliminar = Console.ReadLine();
            AlumnoDto aux = new AlumnoDto();
            foreach(AlumnoDto alumnoEliminado in Program.alumno) { 


                    if (dniEliminar.Equals(alumnoEliminado.Dni))
                    {
                        
                       aux = alumnoEliminado;
                       break;
                    
                    }
                    else
                    {
                        Console.WriteLine("Ningún alumno con ese dni");
                    }
            } 
                Program.alumno.Remove(aux);
                mensaje = "Alumno eliminado correctamente";
                fichero.escribirFichero(mensaje);
                Console.WriteLine("Deseas eliminar otro alumno SI [S]/ NO [N]");
                control = Console.ReadLine();

            }
            while(control.Equals("S"));



        }
        public void mostrarAlumno()
        {
            Console.WriteLine("Mostrar alumnos por consola");
            foreach (AlumnoDto alumno in Program.alumno)
            {
                Console.WriteLine(alumno.ToString());
            }


        }


        public void escribirFicheroAlumno()
        {
            Console.WriteLine("Escribir en fichero los alumnos");
            string alumno;
            foreach (AlumnoDto alumno1 in Program.alumno)
            {
                alumno = alumno1.ToString();
                fichero.alumnosFichero(alumno);
            }


        }


        /// <summary>
        /// Método que de manera automática va contando los id.
        /// Carlos Haro Infante - 28/05/24
        /// </summary>
        private long idAuto()
        {

            int tamanioLista = Program.alumno.Count;

            long id;

            if(Program.alumno.Count > 0)
            {
                id = Program.alumno[tamanioLista - 1].Id + 1;
            }
            else
            {
                id = 1;
            }

            return id;

        }
    }
}
